# Contributing

## Adding a new country

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

1. If the `DefaultPhoneNumberParser` can parse the file, add tests for the country using the `DefaultPhoneNumberParser` as appropriate.
2. If country requires more complex logic to determine the area code, or the performance of the `DefaultPhoneNumberParser` is not acceptable then add a custom parser `{Iso3166Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file.
3. Add a unit test for in `PhoneNumberParserFactoryTests` to assert the expected parser is returned for the `{Iso3166Code}`.

### Add a formatter

1. If necessary, add a `{Iso3166Code}PhoneNumberFormatter` overriding the base methods as appropriate with unit tests.
