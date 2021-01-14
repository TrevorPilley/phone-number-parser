# Contributing

Contributions are welcome, however, please file an issue first and let's have a discussion before you open a pull request.

## Building the project

The project multi targets .NET Standard 2.0, 2.1 and .NET 5.0 so you will need to have the relevant SDK's installed in order to build the solution locally.

Firstly clone or fork the repository.

There is a `build.ps1` to build, test, view code coverage and create a nuget package on Windows and a `build.sh` for those on macOS (not currently tested on linux or Windows Subsystem for Linux but it may still work).

## Rasising a bug

Please raise bugs for any you might find, at some point I'll get an issue template sorted but if you could at least provide details so I can reproduce it that will help improve the chances of it being fixed.

Before raising a bug, please check whether the issue still exists in the latest version and whether there is an existing issue already raised to avoid a duplicate.

## Adding a new country

All features should be implemented in an isolated feature branch and pull requested against `main`, you will need to rebase before the PR will be accepted and the commits will be squashed into a single `Adds country X` commit in `main` to keep the repository history clean.

If you are adding a new country, please do the following.

### Add the CountryInfo

1. Add a new static `CountryInfo` property with the country code as the name, for example:

```csharp
public static CountryInfo ZZ { get; } = new()
{
    CallingCode = "+NN",
    Iso3166Code = "ZZ",
    NsnLengths = new ReadOnlyCollection<int>(new[] { N }),
};
```

2. If the country uses area codes, set the `AreaCodeLengths` property as appropriate and declare in descending order.
3. If the country doens't use the ITU default `InternationalCallPrefix` of `00`, set the property appropriately.
4. If the country uses trunk prefixes, set the `TrunkPrefix` appropriately.
5. Add a new `CountryInfo_ZZ_Tests` class with the appropriate tests (see an existing implementation).

### Add the data file

1. Add a `{Iso3166Code}_numbers.txt` in `/src/PhoneNumbers/DataFiles/` and set as an embedded resource within the project file.

The structre of the file must follow:

`Kind|AreaCodeRanges|GeographicalArea|LocalNumberRanges|Hint`

### Add a parser

1. If the `DefaultPhoneNumberParser` can parse the file, add tests for the country using the `DefaultPhoneNumberParser` as appropriate - typically the min and max permitted local number(s) are tested within each area code/number kind.
2. If country requires more complex logic to determine the area code, or the performance of the `DefaultPhoneNumberParser` is not acceptable then add a custom parser `{Iso3166Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file.
3. Add a unit test for in `PhoneNumberParserFactoryTests` to assert the expected parser is returned for the `{Iso3166Code}`.

### Add a formatter

1. If necessary, add a `{Iso3166Code}PhoneNumberFormatter` overriding the base methods as appropriate with unit tests.
2. Set as the formatter for the country info `Formatter = new {Iso3166Code}PhoneNumberFormatter(),` and update the tests.
