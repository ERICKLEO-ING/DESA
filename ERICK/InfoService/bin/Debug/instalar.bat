@echo off
cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
installutil.exe "D:\DESARROLLO\ERICK\InfoService\bin\Debug\InfoService.exe"

if ERRORLEVEL 1 goto error
exit
:error
echo There was a problem
pause