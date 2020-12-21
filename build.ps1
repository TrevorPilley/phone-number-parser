# A script for building, testing and viewing code coverage locally
$scriptPath = Split-Path $script:MyInvocation.MyCommand.Path
$testResults = Join-Path $scriptPath -ChildPath 'test\PhoneNumber.Tests\TestResults'

if (Test-Path $testResults) {
    Remove-Item -Path $testResults -Recurse
}

if ((Test-NetConnection).PingSucceeded) {
    dotnet tool update --global dotnet-reportgenerator-globaltool
}

dotnet clean
dotnet build
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=.\TestResults\

Set-Location "test\PhoneNumbers.Tests"
reportgenerator "-reports:.\TestResults\coverage.cobertura.xml" "-targetdir:.\TestResults\Coverage" -reporttypes:HTML
Start-Process ".\TestResults\Coverage\index.htm"
Set-Location "..\.."

dotnet pack --no-build
