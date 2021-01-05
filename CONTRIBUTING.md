# Contributing

## Adding a new country

### Add the CountryInfo

1. Add a new static `CountryInfo` property with the country code as the name (e.g. `public static CountryInfo ZZ { get; } = new CountryInfo { CallingCode = "+NN", Iso3116Code = "ZZ", NsnLengths = new ReadOnlyCollection<int>(new[] { N }), };`).
2. If the country doesn't use area codes, set the `HasAreaCodes` property to `false`.
3. If the country doens't use the ITU default `InternationalCallPrefix` of `00`, set the property appropriately.
4. If the country uses trunk prefixes, set the `TrunkPrefix` appropriately.
5. Add a new `CountryInfo_ZZ_Tests` class with the appropriate tests (see an existing implementation).

### Add the data file

1. If the country uses area codes, add a `{Iso3116Code}_area_codes.txt` (otherwise add a `{Iso3116Code}_number_ranges_.txt`) in `/src/PhoneNumbers/DataFiles/` and set as an embedded resource within the project file.

### Add a parser

1. If the country uses area codes and has complex logic to determine the area code, add a custom parser `{Iso3116Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file. Alternatively add tests for the country against the `LocalOnlyPhoneNumberParser` or `AreaCodePhoneNumberParser` as appropriate.

### Add a formatter

1. If necessary, add a `{Iso3116Code}PhoneNumberFormatter` overriding the base methods as appropriate with unit tests.
