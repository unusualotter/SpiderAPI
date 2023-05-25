@echo off
dotnet build
timeout /t 3 /nobreak
copy "C:\SpiderAPI\bin\Debug\net6.0\SpiderAPI.dll" "C:\Program Files (x86)\Steam\steamapps\common\A Webbing Journey Demo" /Y
"C:\Program Files (x86)\Steam\steamapps\common\A Webbing Journey Demo\A Webbing Journey.exe"