@echo off
cls
:choosecura
set choice=
@echo. 
@echo ----------------------------------------------------
@echo Press 2 if you have Cura 5.2.xx
@echo Press 3 if you have Cura 5.3.xx
REM @echo Press 4 if you have Cura 5.4.xx
@echo ----------------------------------------------------
@echo. 
set /p choice=Press number and Enter 
if '%choice%'=='2' goto setcura
if '%choice%'=='3' goto setcura
REM if '%choice%'=='4' goto setcura
@echo Invalid choice
goto choosecura

:setcura
cls
set targetdir=%appdata%\cura\5.%choice%\


@echo Downloading....
@echo. 
curl -LJ# https://github.com/phnxdrgn536/FLSun-v400/archive/refs/heads/main.zip -o main.zip
tar -zxf main.zip 
xcopy /e /y /q .\FLSun-v400-main\cura %targetdir%


cls
:choosefw
set choice=
@echo. 
@echo ----------------------------------------------------
@echo Press 1 if you have STOCK firmware
@echo Press 2 if you have UPDATED firmware 
@echo ----------------------------------------------------
@echo. 
set /p choice=Press number and Enter 
if '%choice%'=='1' goto stock
if '%choice%'=='2' goto updated
@echo Invalid choice
goto choosefw

:stock
copy /-Y %targetdir%\definitions\flsun_v400_STOCK.def.json %targetdir%\definitions\flsun_v400.def.json
goto end

:updated
copy /-Y %targetdir%\definitions\flsun_v400_updated_firmware.def.json %targetdir%\definitions\flsun_v400.def.json

:end
cls
@echo All done
@echo. 
pause 

