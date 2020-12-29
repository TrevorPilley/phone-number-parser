#!/bin/sh

rm -r test/PhoneNumbers.Tests/TestResults/

dotnet tool update --global dotnet-reportgenerator-globaltool

dotnet clean --verbosity minimal
dotnet build --verbosity minimal
dotnet test --no-restore --verbosity minimal /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/

cd test/PhoneNumbers.Tests
reportgenerator "-reports:./TestResults/coverage.cobertura.xml" "-targetdir:./TestResults/Coverage" -reporttypes:HTML
open "./TestResults/Coverage/index.htm"

dotnet pack --no-build
