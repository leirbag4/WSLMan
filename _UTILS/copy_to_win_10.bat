@echo off

SET origin="..\WSLMan\bin\Debug\net7.0-windows\WSLMan.exe"
SET origin2="..\WSLMan\bin\Debug\net7.0-windows\WSLMan.dll"
SET dest="\\DESKTOP-SFHM6G6\programs\wslman\WSLMan.exe"
SET dest2="\\DESKTOP-SFHM6G6\programs\wslman\WSLMan.dll"

xcopy /y %origin% %dest%
xcopy /y %origin2% %dest2%

pause
