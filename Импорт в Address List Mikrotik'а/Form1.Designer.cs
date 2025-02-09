namespace Импорт_в_Address_List_Mikrotik_а
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SSHHeading = new System.Windows.Forms.Label();
            this.ListHeading = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.LabelPort = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPasswd = new System.Windows.Forms.Label();
            this.ShowPasswd = new System.Windows.Forms.CheckBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.TextBox();
            this.LabelList = new System.Windows.Forms.Label();
            this.LabelSelect = new System.Windows.Forms.Label();
            this.LabelCreate = new System.Windows.Forms.Label();
            this.LabelCreated = new System.Windows.Forms.Label();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelTimeout = new System.Windows.Forms.Label();
            this.AllowTimeout = new System.Windows.Forms.CheckBox();
            this.Timeout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SSHHeading
            // 
            this.SSHHeading.AutoSize = true;
            this.SSHHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SSHHeading.Location = new System.Drawing.Point(58, 9);
            this.SSHHeading.Name = "SSHHeading";
            this.SSHHeading.Size = new System.Drawing.Size(194, 20);
            this.SSHHeading.TabIndex = 0;
            this.SSHHeading.Text = "Подключение по SSH";
            // 
            // ListHeading
            // 
            this.ListHeading.AutoSize = true;
            this.ListHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListHeading.Location = new System.Drawing.Point(401, 9);
            this.ListHeading.Name = "ListHeading";
            this.ListHeading.Size = new System.Drawing.Size(69, 20);
            this.ListHeading.TabIndex = 0;
            this.ListHeading.Text = "Список";
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelIP.Location = new System.Drawing.Point(12, 50);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(68, 16);
            this.LabelIP.TabIndex = 1;
            this.LabelIP.Text = "IP/Домен:";
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPort.Location = new System.Drawing.Point(199, 50);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(43, 16);
            this.LabelPort.TabIndex = 1;
            this.LabelPort.Text = "Порт:";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(13, 94);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(49, 16);
            this.LabelLogin.TabIndex = 1;
            this.LabelLogin.Text = "Логин:";
            // 
            // LabelPasswd
            // 
            this.LabelPasswd.AutoSize = true;
            this.LabelPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPasswd.Location = new System.Drawing.Point(13, 136);
            this.LabelPasswd.Name = "LabelPasswd";
            this.LabelPasswd.Size = new System.Drawing.Size(59, 16);
            this.LabelPasswd.TabIndex = 1;
            this.LabelPasswd.Text = "Пароль:";
            // 
            // ShowPasswd
            // 
            this.ShowPasswd.AutoSize = true;
            this.ShowPasswd.Location = new System.Drawing.Point(274, 138);
            this.ShowPasswd.Name = "ShowPasswd";
            this.ShowPasswd.Size = new System.Drawing.Size(15, 14);
            this.ShowPasswd.TabIndex = 4;
            this.ShowPasswd.UseVisualStyleBackColor = true;
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IP.Location = new System.Drawing.Point(78, 47);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(119, 22);
            this.IP.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Port.Location = new System.Drawing.Point(244, 47);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(45, 22);
            this.Port.TabIndex = 1;
            this.Port.Text = "22";
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(78, 91);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 22);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(78, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(179, 22);
            this.Password.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(16, 173);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(521, 59);
            this.ButtonStart.TabIndex = 9;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List.Location = new System.Drawing.Point(367, 44);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(170, 22);
            this.List.TabIndex = 5;
            // 
            // LabelList
            // 
            this.LabelList.AutoSize = true;
            this.LabelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelList.Location = new System.Drawing.Point(318, 47);
            this.LabelList.Name = "LabelList";
            this.LabelList.Size = new System.Drawing.Size(41, 16);
            this.LabelList.TabIndex = 1;
            this.LabelList.Text = "Лист:";
            // 
            // LabelSelect
            // 
            this.LabelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelect.Location = new System.Drawing.Point(364, 121);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(173, 16);
            this.LabelSelect.TabIndex = 1;
            this.LabelSelect.Text = "...";
            // 
            // LabelCreate
            // 
            this.LabelCreate.AutoSize = true;
            this.LabelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreate.Location = new System.Drawing.Point(319, 150);
            this.LabelCreate.Name = "LabelCreate";
            this.LabelCreate.Size = new System.Drawing.Size(59, 16);
            this.LabelCreate.TabIndex = 1;
            this.LabelCreate.Text = "Создан:";
            // 
            // LabelCreated
            // 
            this.LabelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreated.Location = new System.Drawing.Point(384, 150);
            this.LabelCreated.Name = "LabelCreated";
            this.LabelCreated.Size = new System.Drawing.Size(153, 16);
            this.LabelCreated.TabIndex = 1;
            this.LabelCreated.Text = "...";
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSelect.Location = new System.Drawing.Point(321, 114);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(37, 27);
            this.ButtonSelect.TabIndex = 8;
            this.ButtonSelect.Text = "...";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "г. Омск 09.02.25";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(94, 235);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 12);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.Text = "Автор Otto";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // LabelTimeout
            // 
            this.LabelTimeout.AutoSize = true;
            this.LabelTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimeout.Location = new System.Drawing.Point(318, 82);
            this.LabelTimeout.Name = "LabelTimeout";
            this.LabelTimeout.Size = new System.Drawing.Size(51, 16);
            this.LabelTimeout.TabIndex = 1;
            this.LabelTimeout.Text = "Время:";
            // 
            // AllowTimeout
            // 
            this.AllowTimeout.AutoSize = true;
            this.AllowTimeout.Location = new System.Drawing.Point(522, 84);
            this.AllowTimeout.Name = "AllowTimeout";
            this.AllowTimeout.Size = new System.Drawing.Size(15, 14);
            this.AllowTimeout.TabIndex = 6;
            this.AllowTimeout.UseVisualStyleBackColor = true;
            // 
            // Timeout
            // 
            this.Timeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Timeout.Location = new System.Drawing.Point(367, 79);
            this.Timeout.Name = "Timeout";
            this.Timeout.Size = new System.Drawing.Size(137, 22);
            this.Timeout.TabIndex = 7;
            this.Timeout.Text = "00:01:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 253);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Timeout);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.AllowTimeout);
            this.Controls.Add(this.ShowPasswd);
            this.Controls.Add(this.LabelPasswd);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LabelCreated);
            this.Controls.Add(this.LabelSelect);
            this.Controls.Add(this.LabelTimeout);
            this.Controls.Add(this.LabelCreate);
            this.Controls.Add(this.LabelList);
            this.Controls.Add(this.LabelPort);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.ListHeading);
            this.Controls.Add(this.SSHHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Импорт в Address List Mikrotik\'а";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SSHHeading;
        private System.Windows.Forms.Label ListHeading;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.Label LabelPort;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPasswd;
        private System.Windows.Forms.CheckBox ShowPasswd;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox List;
        private System.Windows.Forms.Label LabelList;
        private System.Windows.Forms.Label LabelSelect;
        private System.Windows.Forms.Label LabelCreate;
        private System.Windows.Forms.Label LabelCreated;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LabelTimeout;
        private System.Windows.Forms.CheckBox AllowTimeout;
        private System.Windows.Forms.TextBox Timeout;
    }
}

