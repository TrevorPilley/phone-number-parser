#!/bin/sh

git submodule update --recursive --remote

dotnet run --project utilities/phone-number-utilities-testgenerator/src/PhoneNumbers.Utilities.TestGenerator/PhoneNumbers.Utilities.TestGenerator.csproj /dataFilePath=/workspaces/phone-number-parser/src/PhoneNumbers/DataFiles

dotnet clean --verbosity minimal
