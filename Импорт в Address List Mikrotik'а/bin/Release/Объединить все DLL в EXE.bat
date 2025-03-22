@echo off
setlocal enabledelayedexpansion

:: Путь к ILMerge.exe
set ILMERGE="%USERPROFILE%\.nuget\packages\ilmerge\3.0.41\tools\net452\ILMerge.exe"

:: Имя исходного исполняемого файла
set TARGET="Импорт в Address List Mikrotik'а.exe"

:: Временное имя для исходного файла
set TEMP_TARGET="basic - Импорт в Address List Mikrotik'а.exe"

:: Имя выходного файла (будет таким же, как и исходный)
set OUTPUT=%TARGET%

:: Переименование исходного файла
if exist %TARGET% (
    ren %TARGET% %TEMP_TARGET%
) else (
    echo Исходный файл %TARGET% не найден.
    goto :end
)

:: Создаем строку с перечислением всех DLL файлов в текущей директории
set DLLS=
for %%f in (*.dll) do (
    set DLLS=!DLLS! %%f
)

:: Запуск ILMerge с параметрами
%ILMERGE% /target:winexe /out:%OUTPUT% %TEMP_TARGET% %DLLS%

:: Проверка успешности слияния
if %errorlevel% neq 0 (
    echo Ошибка при слиянии файлов. Откатываем изменения.
    ren %TEMP_TARGET% %TARGET%
    goto :end
)

:: Удаление временного файла после успешного слияния
if exist %TEMP_TARGET% (
    del %TEMP_TARGET%
)

echo Слияние завершено. Создан файл: %OUTPUT%

:: Удаление файлов с определёнными расширениями
for %%e in (.dll .xml .application .config .manifest .pdb) do (
    for %%F in (*%%e) do (
        del "%%F"
    )
)

:: Удаление папки app.publish
if exist "app.publish" (
    rmdir /s /q "app.publish"
)

:end
pause