# A script for building, testing and viewing code coverage locally
$scriptPath = Split-Path $script:MyInvocation.MyCommand.Path
$testResults = Join-Path $scriptPath -ChildPath 'test\PhoneNumber.Tests\TestResults'

if (Test-Path $testResults) {
    Remove-Item -Path $testResults -Recurse
}

dotnet tool update --global dotnet-reportgenerator-globaltool

dotnet clean --verbosity minimal
dotnet build --configuration Release --verbosity minimal
dotnet test --no-restore --verbosity minimal /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=.\TestResults\
dotnet pack --no-build --configuration Release

Set-Location "test\PhoneNumbers.Tests"
reportgenerator "-reports:.\TestResults\coverage.cobertura.xml" "-targetdir:.\TestResults\Coverage" -reporttypes:HTML
Start-Process ".\TestResults\Coverage\index.htm"
Set-Location "..\.."
