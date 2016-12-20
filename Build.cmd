@echo off

msbuild /t:Rebuild /p:Configuration=InspectCode /p:Platform=x64 /v:m "%~dp0\PropertiesBug.sln"
