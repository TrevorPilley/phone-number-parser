#!/bin/sh

export CollectCoverage='true'
export CoverletOutputFormat='cobertura'
export CoverletOutput='./TestResults/'

rm -r test/PhoneNumbers.Tests/TestResults/

dotnet tool update --global dotnet-reportgenerator-globaltool

dotnet clean --verbosity minimal
dotnet build --verbosity minimal
dotnet test --no-restore --verbosity minimal
dotnet pack --no-build

cd test/PhoneNumbers.Tests
reportgenerator "-reports:./TestResults/coverage.cobertura.xml" "-targetdir:./TestResults/Coverage" -reporttypes:HTML
open "./TestResults/Coverage/index.htm"
