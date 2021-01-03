# Contributing

## Adding a new country

### Add the CountryInfo

1. Add a new static `CountryInfo` property with the country code as the name (e.g. `public static CountryInfo ZZ { get; } = new CountryInfo { CallingCode = "+NN", InternationalCallPrefix = "NN", Iso3116Code = "ZZ", NsnLengths = new ReadOnlyCollection<int>(new[] { N }), TrunkPrefix = "N", };`).
2. If the country doesn't use area codes, set the `HasAreaCodes` property to `false`.
3. Add a new `CountryInfoTests_ZZ` class with the appropriate tests (see an existing implementation).
4. Add a new PhoneNumberParser extending PhoneNumberParser with a private constructor calling the base constructor and passing the CountryInfo.ZZ property added in step 1 and a static Create method (e.g. `public sealed class ZZPhoneNumberParser : PhoneNumberParser`).
5. Add the new `PhoneNumberParser` in the `ParseOptions.Parsers` list and include in ParseOptionsTests.
6. Add a new ZZPhoneNumberParserTests class with appropriate tests.
7. If necessary, add a ZZPhoneNumberFormatter overriding the base display methods as appropriate with unit tests.
