@echo off
echo build start...
if exist "%~dp0build.log" (del /Q "%~dp0build.log")
%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe "D:\Code\U9demo\plug\Code\UFIDA.U9.Cust.BLT.ShipPlan.AmountBP\UFIDA.U9.Cust.BLT.ShipPlan.TranoutPushBP\UFIDA.U9.Cust.BLT.ShipPlan.TranoutPushBP.csproj" /t:Clean;Rebuild /p:WarningLevel=0;Configuration=Release 
echo build end