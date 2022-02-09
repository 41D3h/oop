@echo off
set /p root=Source file located at: 
if not exist %root%\ (
	@echo on
    echo Directory %root% not found!
	@echo off
	goto :end
)

cd %root%

@echo off
set /p fileName=Source file name (without .cs): 
if not exist %fileName%.cs (
	@echo on
    echo File %fileName%.cs not found!
	@echo off
	goto :end
)

@echo off
set currentDir=%cd%

cd /d %windir%\Microsoft.NET\Framework\v4.0.30319

csc.exe /out:%currentDir%\%fileName%.exe %currentDir%\%fileName%.cs

@echo off
set /p run=Execute (y/n): 
if "%run%%"=="y" (
	cd /d %currentDir%
	%filename%.exe
)
:end
cd /d %currentDir%/..