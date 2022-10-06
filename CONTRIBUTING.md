# Contributing

Contributions are welcome, however, please file an issue first and let's have a discussion before you open a pull request.

## Building the project

The project multi targets .NET Standard 2.0 + 2.1 and .NET 6.0 so you will need to have the relevant SDK's installed in order to build the solution locally. It also uses some C# 10 language features so you will need an IDE that supports C# 10.

Firstly clone or fork the repository.

There is a `build.ps1` to build, test, view code coverage and create a nuget package on Windows and a `build.sh` for those on macOS (not currently tested on Linux or Windows Subsystem for Linux but it may still work).

## Raising a bug

Please raise bugs for any you might find, at some point I'll get an issue template sorted but if you could at least provide details so I can reproduce it that will help improve the chances of it being fixed.

Before raising a bug, please check whether the issue still exists in the latest version and whether there is an existing issue already raised to avoid a duplicate.

## Adding a new country

All features should be implemented in an isolated feature branch and pull requested against `main` (or a `build/x.y.z` branch if one exists), you will need to rebase before the PR will be accepted and the commits will be squashed into a single `Adds country X` commit in `main` to keep the repository history clean.

If you are adding a new country, please do the following.

### Add the CountryInfo

1. Add a new static `CountryInfo` property in the relevant `CountryInfo_{Continent}.cs` file with the country name as the name, for example:

```csharp
public static CountryInfo CountryName { get; } = new()
{
    CallingCode = "+NN",
    Continent = Africa/Asia/Europe/Oceania/NorthAmerica/SouthAmerica, // as appropriate
    Iso3166Code = "ZZ",
    Name = "CountryName",
    NsnLengths = new ReadOnlyCollection<int>(new[] { N }),
};
```

2. If the country uses national destination codes (aka. area codes), set the `NdcLengths` property as appropriate and declare in descending order.
3. If the country doesn't use the ITU default `InternationalCallPrefix` of `00`, set the property appropriately.
4. If the country uses a trunk prefix, set the `TrunkPrefix` appropriately.
5. If the country uses an open dialling plan, where within a geographic area local dialling can be done without including the trunk code or area code, set `RequireNdcForLocalGeographicDialling = false`
6. Add a new `CountryInfo_CountryName` test in the `CountryInfo_{Continent}_Tests.cs` file asserting the property values (see an existing implementation).

### Add the data file

1. Add a `{Iso3166Code}.txt` in `/src/PhoneNumbers/DataFiles/` and set as an embedded resource within the project file.

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

#### Hint

Optional but can be one of:

- `D` _data only (such as a 4G tablet), where Kind is M_
- `F` _a Freephone number, where Kind is N_
- `M` _a Machine-to-Machine (M2M) number, where Kind is N_
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
2. If country requires more complex logic to determine the national destination code, or the performance of the `DefaultPhoneNumberParser` is not acceptable then add a custom parser `{Iso3166Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file.
3. Add a unit test for in `PhoneNumberParserFactoryTests` to assert the expected parser is returned for the `{Iso3166Code}`.
4. Add a unit test for `Parse` and `TryParse` methods in `PhoneNumber_Parse_Tests.cs` and `PhoneNumber_TryParse_Tests.cs` for the `{Iso3166Code}` to check the country code is assigned.
