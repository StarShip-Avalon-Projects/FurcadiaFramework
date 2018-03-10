IF "%~1"=="" GOTO BuildAll
IF "%~1"=="VersionBump" GOTO VersionBump

:VersionBump
msbuild /t:IncrementVersions /property:Configuration=Debug Solution.build 
set BUILD_STATUS=%ERRORLEVEL% 
if not %BUILD_STATUS%==0 goto fail 

:BuildAll
msbuild /t:BuildALL  /property:Configuration=Debug Solution.build /flp:logfile=MonkeySystemDebug.log;verbosity=diagnostic
set BUILD_STATUS=%ERRORLEVEL% 
if not %BUILD_STATUS%==0 goto fail 

:backupSources
"c:\program files\winrar\rar.exe" a -r -xpackages\* -x*\packages\* -x\.svn\* -xsilvermonkey.ini -x*\Build\* -x*\.vs\* -x*\.git\* -n*.resx -x*Plugins\* -xbackup*\* -x*\bin\* -x*\src\ -x*\obj\* -n*.*proj -n*.cmd -nbin\*.dll -nbin\*.exe -nbin\*.bat -n*.sln -n*.wxs -n*.build -n*.snk -n*.xslt -n*.csv -n*.pal -n*.rtf -n*.vb -n*.t4 -n*.tt -n*.png -n*.jpg -n*.jpeg -n*.bmp -n*.exe -n*.datasource -n*.md -n*.ico -n*.manifest -n*.wix -n*.cs -n*.ds -n*.ms -n*.ini -nlicense*.* -nlicense -n*.content -n*.settings -n*.aml -n*.xml -n*.htm -n*.html -n*.css -n*.sln -n*.resx -n*.txt -n*.dll -n*.nsh -n*.nsi -n*.log -n*.tokens -n*.config -n*.iss Build\Installer\SilverMonkey_Src.rar *.*
rem set BUILD_STATUS=%ERRORLEVEL% 
rem if not %BUILD_STATUS%==0 goto fail 

:BuildRelease
msbuild /t:Build;BackupSource /property:Configuration=Release Solution.build  /flp:logfile=MonkeySystemRelease.log;verbosity=diagnostic
 set BUILD_STATUS=%ERRORLEVEL% 
if %BUILD_STATUS%==0 goto eof 
if not %BUILD_STATUS%==0 goto fail  
 
:fail 
pause 
exit /b 1


:eof
exit /b 0