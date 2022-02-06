#!/bin/bash
cd ./Source/genny/
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:AltCover=true
cd ../../
