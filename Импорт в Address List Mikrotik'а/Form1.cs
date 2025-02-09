/*
    Данная программа является свободным программным обеспечением, распространяющимся по лицензии MIT.
    Копия лицензии: https://opensource.org/licenses/MIT

    Copyright (c) 2025 Otto
    Автор: Otto
    Версия: 09.02.25

    GitHub страница: https://github.com/Otto17/AddAddressListMikrotik
    GitFlic страница: https://gitflic.ru/project/otto/addaddressaistmikrotik

    г. Омск 2025
*/


using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace Импорт_в_Address_List_Mikrotik_а
{
    public partial class Form1 : Form
    {
        // Поле для хранения пути выбранного файла
        private string selectedFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            // Расположение формы по центру монитора при запуске
            this.StartPosition = FormStartPosition.CenterScreen;

            // Устанавливаем скрытие поля пароля (по умолчанию)
            Password.UseSystemPasswordChar = true;

            // Делаем поле Timeout неактивным (по умолчанию)
            Timeout.Enabled = false;

            // Подписываемся на события элементов управления
            ShowPasswd.CheckedChanged += ShowPasswd_CheckedChanged;
            ButtonSelect.Click += ButtonSelect_Click;
            ButtonStart.Click += ButtonStart_Click;
            AllowTimeout.CheckedChanged += AllowTimeout_CheckedChanged;
        }

        // Обработчик изменения состояния чекбокса для показа/скрытия пароля
        private void ShowPasswd_CheckedChanged(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !ShowPasswd.Checked;
        }

        // Обработчик изменения состояния чекбокса AllowTimeout
        private void AllowTimeout_CheckedChanged(object sender, EventArgs e)
        {
            Timeout.Enabled = AllowTimeout.Checked;
        }

        // Обработчик нажатия кнопки выбора файла
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Text files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                // Очищаем LabelCreated при выборе нового файла
                LabelCreated.Text = "...";

                // Обрезаем длинное имя файла по целым словам
                LabelSelect.Text = TruncateFileName(Path.GetFileName(selectedFilePath), LabelSelect.Width, LabelSelect.Font);
            }
        }

        // Метод для обрезки длинного имени файла по целым словам
        private string TruncateFileName(string fileName, int maxWidth, System.Drawing.Font font)
        {
            using var g = LabelSelect.CreateGraphics();
            string[] words = fileName.Split(' ');
            string truncatedText = "";

            foreach (string word in words)
            {
                string tempText = string.IsNullOrEmpty(truncatedText) ? word : truncatedText + " " + word;
                if (g.MeasureString(tempText, font).Width > maxWidth)
                    break;
                truncatedText = tempText;
            }

            return truncatedText + (truncatedText.Length < fileName.Length ? "..." : "");
        }

        // Обработчик нажатия кнопки "Старт"
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            // Проверка, заполнены ли все поля
            if (string.IsNullOrWhiteSpace(IP.Text) ||
                string.IsNullOrWhiteSpace(Port.Text) ||
                string.IsNullOrWhiteSpace(Login.Text) ||
                string.IsNullOrWhiteSpace(Password.Text) ||
                string.IsNullOrWhiteSpace(List.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }

            // Проверяем выбран ли файл и существует ли он
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Файл не выбран или не существует.");
                return;
            }

            // Проверяем, нужно ли использовать timeout
            string timeoutValue = "";
            if (AllowTimeout.Checked)
            {
                timeoutValue = Timeout.Text.Trim();
                if (!IsValidTimeout(timeoutValue))
                {
                    MessageBox.Show("Некорректный формат времени! Используйте:\n" +
                                    "- '5:17:00' (часы:минуты:секунды)\n" +
                                    "- '2d 00:37:25' (дни часы:минуты:секунды)\n" +
                                    "- '2d00:37:25' (дни_часы:минуты:секунды)");
                    return;
                }

                // Убираем пробел перед отправкой в MikroTik
                timeoutValue = NormalizeTimeout(timeoutValue);
            }

            ButtonStart.Enabled = false;
            LabelCreated.Text = "Начало загрузки...";

            // Считываем и обрабатываем строки из файла
            string[] addressLines;
            try
            {
                addressLines = File.ReadAllLines(selectedFilePath)
                                  .SelectMany(line => line.Split([','], StringSplitOptions.RemoveEmptyEntries))
                                  .Select(addr => addr.Trim())
                                  .Where(addr => !string.IsNullOrEmpty(addr))
                                  .ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла: " + ex.Message);
                ButtonStart.Enabled = true;
                return;
            }

            // Получаем данные для подключения по SSH из формы
            string host = IP.Text.Trim();
            if (!int.TryParse(Port.Text.Trim(), out int port))
            {
                MessageBox.Show("Некорректный порт.");
                ButtonStart.Enabled = true;
                return;
            }
            string username = Login.Text.Trim();
            string password = Password.Text;
            string listName = List.Text.Trim();

            // Подключаемся к Mikrotik по SSH и выполняем команды
            try
            {
                using (var sshClient = new SshClient(host, port, username, password))
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            sshClient.Connect();
                        }
                        catch (SshAuthenticationException)
                        {
                            MessageBox.Show("Ошибка аутентификации. Проверьте логин и пароль.");
                            return;
                        }
                        catch (SshConnectionException)
                        {
                            MessageBox.Show("Ошибка подключения к SSH. Проверьте IP и порт.");
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Неизвестная ошибка подключения: " + ex.Message);
                            return;
                        }
                    });

                    if (!sshClient.IsConnected)
                    {
                        ButtonStart.Enabled = true;
                        return;
                    }

                    foreach (string address in addressLines)
                    {
                        if (!IsValidAddress(address))
                        {
                            MessageBox.Show($"Некорректный адрес: {address}");
                            continue;
                        }

                        // Формируем команду, добавляя timeout только если он включён
                        string commandText = $"/ip firewall address-list add address={address} list={listName}";
                        if (AllowTimeout.Checked && !string.IsNullOrEmpty(timeoutValue))
                            commandText += $" timeout={timeoutValue}";

                        var command = sshClient.CreateCommand(commandText);
                        string result = command.Execute();

                        if (!string.IsNullOrEmpty(command.Error))
                        {
                            MessageBox.Show($"Ошибка выполнения команды: {command.Error}");
                            continue;
                        }

                        UpdateLabelCreated(address);
                        await Task.Delay(100);
                    }

                    sshClient.Disconnect();
                }

                MessageBox.Show("Список успешно загружен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении SSH-команд: " + ex.Message);
            }
            finally
            {
                ButtonStart.Enabled = true;
            }
        }

        // Метод проверки корректности IP-адреса, маски или домена
        private bool IsValidAddress(string address)
        {
            return System.Net.IPAddress.TryParse(address, out _) ||
                   System.Text.RegularExpressions.Regex.IsMatch(address, @"^\d{1,3}(\.\d{1,3}){3}/\d{1,2}$") ||
                   System.Text.RegularExpressions.Regex.IsMatch(address, @"^[a-zA-Z0-9.-]+$");
        }

        // Проверка формата Timeout
        private bool IsValidTimeout(string timeout)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(timeout, @"^(\d{1,2}:\d{2}:\d{2}|\d+d ?\d{1,2}:\d{2}:\d{2})$");
        }

        // Метод нормализации timeout (убираем пробел между днями и временем)
        private string NormalizeTimeout(string timeout)
        {
            return timeout.Replace("d ", "d");
        }

        // Метод для обновления LabelCreated с последним загруженным адресом
        private void UpdateLabelCreated(string text)
        {
            if (LabelCreated.InvokeRequired)
            {
                LabelCreated.Invoke(new Action(() => { LabelCreated.Text = text; }));
            }
            else
            {
                LabelCreated.Text = text;
            }
        }

        // Ссылка на страницу автора
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitflic.ru/project/otto/addaddressaistmikrotik");
        }
    }
}
