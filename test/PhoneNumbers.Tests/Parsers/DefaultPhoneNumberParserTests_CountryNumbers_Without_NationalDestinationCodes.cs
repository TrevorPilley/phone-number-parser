namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class without <see cref="CountryNumber"/>s using area codes.
/// </summary>
public class DefaultPhoneNumberParserTests_CountryNumbers_WithoutNationalDestinationCodes
{
    private readonly CountryInfo _countryInfo = TestHelper.CreateCountryInfo(nsnLengths: [5]);

    private readonly PhoneNumberParser _parser;

    public DefaultPhoneNumberParserTests_CountryNumbers_WithoutNationalDestinationCodes() =>
        _parser = new DefaultPhoneNumberParser(
            _countryInfo,
            [
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("10000-10999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Pager,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("12000-12999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Virtual,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("13000-13999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("20000-20999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Freephone,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("28000-28999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.PremiumRate,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("29000-29999")]),
                new CountryNumber(
                    GeographicArea: "Springfield",
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.GeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("30000-30999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.SharedCost,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("31000-31999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.MachineToMachine,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: null,
                    SubscriberNumberRanges: [NumberRange.Create("41000-41999")]),
            ]);

    [Fact]
    public void Parse_GeographicPhoneNumber()
    {
        var phoneNumber = _parser.Parse("30000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, geographicPhoneNumber.Country);
        Assert.Equal("Springfield", geographicPhoneNumber.GeographicArea);
        Assert.Equal("30000", geographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, geographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_Invalid_Number() =>
        Assert.Equal("The national significant number 05500 is not a valid Zulu phone number.", _parser.Parse("05500").ParseError);

    [Fact]
    public void Parse_MobilePhoneNumber()
    {
        var phoneNumber = _parser.Parse("10000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal("10000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_MobilePhoneNumber_Pager()
    {
        var phoneNumber = _parser.Parse("12000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal("12000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_MobilePhoneNumber_Virtual()
    {
        var phoneNumber = _parser.Parse("13000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Null(mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal("13000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber()
    {
        var phoneNumber = _parser.Parse("20000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("20000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_Freephone()
    {
        var phoneNumber = _parser.Parse("28000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_MachineToMachine()
    {
        var phoneNumber = _parser.Parse("41000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("41000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_PremiumRate()
    {
        var phoneNumber = _parser.Parse("29000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("29000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_SharedCost()
    {
        var phoneNumber = _parser.Parse("31000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.True(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("31000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }
}
