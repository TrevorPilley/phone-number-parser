# Contributing

Contributions are welcome, however, please file an issue first and let's have a discussion before you open a pull request.

## Raising a bug

Please raise bugs for any you might find, at some point I'll get an issue template sorted but if you could at least provide details so I can reproduce it that will help improve the chances of it being fixed.

Before raising a bug, please check whether the issue still exists in the latest version and whether there is an existing issue already raised to avoid a duplicate.

## Building the project

The project multi targets .NET 7.0 in addition to .NET Standard 2.1 & 2.0 so you will need to have the relevant SDK's installed in order to build the solution locally. It also utilises C# 11 language features so you will need an IDE that supports it.

Firstly clone or fork the repository.

There is a `build.ps1` to build, test, view code coverage and create a nuget package on Windows and a `build.sh` for those on macOS or Linux.

## Adding a new country

All features should be implemented in an isolated feature branch and pull requested against `main` (or a `build/x.y.z` branch if one exists), you will need to rebase before the PR will be accepted and the commits will be squashed into a single `Adds country X` commit in `main` to keep the repository history clean.

If you are adding a new country, please do the following.

### Add the CountryInfo

1. Add a new static `CountryInfo` property in the relevant `CountryInfo_{Continent}.cs` file with the country name as the name, for example:

```csharp
public static CountryInfo CountryName { get; } = new()
{
    CallingCode = "NN",
    Continent = Africa/Asia/Europe/Oceania/NorthAmerica/SouthAmerica, // as appropriate
    Iso3166Code = "ZZ",
    Name = "CountryName",
    NsnLengths = new ReadOnlyCollection<int>([N]),
};
```

2. If the country uses national destination codes (aka. area codes), also set the `NdcLengths` property as appropriate and declare in descending order (this is important as the default parser tries to match for the longest NDC first).
3. If the country uses a trunk prefix, set the `TrunkPrefix` appropriately.
4. If the country allows local dialling (subscriber number only) within a geographic national destination code, set `AllowLocalGeographicDialling = true,`.
5. By default, the `ComplexPhoneNumberFormatProvider` is used which has defined spacing rules for formatting the subscriber number (e.g. a 6 digit SN is formatted as XXX XXX and a 7 digit SN is formatted XXX XXXX). If the country convention is not to separate out the subscriber number but still separates the national destination code from the subscriber number, use the `SimplePhoneNumberFormatProvider` instead. If the country uses conventions the built in providers don't support, add a custom `{CountryCode}PhoneNumberFormatProvider` and override the base behaviour as appropriate and set as the `FormatProvider` property in the `CountryInfo` definition.
6. Add a new `CountryInfo_CountryName` test in the `CountryInfo_{Continent}_Tests.cs` file asserting the property values (see an existing implementation).
7. Add a new set of tests in the `CountryInfo_{Continent}_ToString_Tests.cs` to cover the various number kinds and NDC/SN length combinations.

### Add the data file

1. Add a `{Iso3166Code}.txt` in `/src/PhoneNumbers/DataFiles/`.

The structure of the file is pipe `|` delimited and the "columns" are as follows:

`Kind|NationalDestinationCodeRanges|GeographicalArea|SubscriberNumberRanges|Hint`

#### Kind

Must be one of:

- `G` _for a geographically assigned number_
- `M` _for a mobile number_
- `N` _for a non-geographically assigned number_

#### National destination code ranges

Can be expressed as either:

- `NNNN` _a single number (typically for geographically assigned numbers)_
- `NNNN-NNNN` _a range of numbers (e.g. 800-804) where the same kind, subscriber number ranges and hint apply)_

Or a combination thereof (e.g. `NNNN,NNNN-NNNN,NNNN-NNNN`).

#### Geographical area

The name of the area a geographically assigned number is allocated to, preferably in the local language of the country the data file relates to rather than English (e.g. `Firenze` rather than `Florence` in Italy).

#### Subscriber number ranges

Can be specified in the same way as national destination code ranges.

Note however for numbering plans that do not use national destination codes but have variable length subscriber numbers which all start with the same digits, each segment needs specifying individually by length. For example, if the numbering plan states NSN starting 26 with a min length of 6 and a max length of 7 the data file would need to contain `260000-269999,2600000-2699999`. If it was defined as `260000-2699999` it would incorrectly include the number `2599999`.

#### Hint

Optional but can be one of:

- `F` _a Freephone number, where Kind is N_
- `M` _a Machine-to-Machine (M2M) number, where Kind is N_
- `N` _a National dialling only restriction where local dialling is usually allowed (AllowLocalGeographicDialling is set to true for the country), where Kind is G_
- `P` _a Pager, where Kind is M_
- `R` _a Premium rate number, where Kind is N_
- `S` _a Shared cost number, where Kind is N_
- `V` _a Virtual number (e.g. personal number), where Kind is M_

#### Comments

A single line comment can be added in a data file by starting the line with a `#`:

```text
# this is a comment
```

### Add a parser

1. If the `DefaultPhoneNumberParser` can parse the file, add tests for the country using the `DefaultPhoneNumberParser` as appropriate - typically the min and max permitted subscriber number(s) are tested within each national destination code/number kind.
2. If country requires more complex logic to determine the national destination code, or the performance of the `DefaultPhoneNumberParser` is not acceptable then add a custom parser named `{Iso3166Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file.
3. Add a unit test for `Parse` in `PhoneNumber_Parse_{Continent}_Tests.cs` to check the number is parsed correctly and the country code is assigned.
