#!/bin/sh

rm -r test/PhoneNumbers.Tests/TestResults/

dotnet tool update --global dotnet-reportgenerator-globaltool

dotnet clean --verbosity minimal
dotnet build --verbosity minimal
dotnet test --no-restore --verbosity minimal /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/
dotnet pack --no-build

cd test/PhoneNumbers.Tests
reportgenerator "-reports:./TestResults/coverage.cobertura.xml" "-targetdir:./TestResults/Coverage" -reporttypes:HTML
open "./TestResults/Coverage/index.htm"
