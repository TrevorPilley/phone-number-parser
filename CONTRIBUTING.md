# Contributing

## Adding a new country

### Add the CountryInfo

1. Add a new static `CountryInfo` property with the country code as the name (e.g. `public static CountryInfo ZZ { get; } = new CountryInfo { CallingCode = "+NN", Iso3116Code = "ZZ", NsnLengths = new ReadOnlyCollection<int>(new[] { N }), };`).
2. If the country doesn't use area codes, set the `HasAreaCodes` property to `false`.
3. If the country doens't use the ITU default `InternationalCallPrefix` of `00`, set the property appropriately.
4. If the country uses trunk prefixes, set the `TrunkPrefix` appropriately.
5. Add a new `CountryInfoTests_ZZ` class with the appropriate tests (see an existing implementation).
6. If the country uses area codes, add a `{Iso3116Code}_area_codes.txt` (otherwise add a `{Iso3116Code}_number_ranges_.txt`) in `/src/PhoneNumbers/DataFiles/` and set as an embedded resource.
7. If the country uses area codes and has complex logic to determine the area code, add a custom parser `{Iso3116Code}PhoneNumberParser` (see the GB one as an example) and add test cases based upon the data file (alternatively add tests for the country against the `LocalOnlyPhoneNumberParser` or `AreaCodePhoneNumberParser` as appropriate).
8. If necessary, add a ZZPhoneNumberFormatter overriding the base display methods as appropriate with unit tests.
