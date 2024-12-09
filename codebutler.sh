#!/bin/sh

dotnet tool update --global code-butler

find ./src/PhoneNumbers/ -type f -name '*.cs' | while read fname;
do
    dotnet-code-butler "$fname"
done

find ./test/PhoneNumbers.Tests/ -type f -name '*.cs' | while read fname;
do
    dotnet-code-butler "$fname"
done
