namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class with <see cref="CountryNumber"/>s using area codes.
/// </summary>
public class DefaultPhoneNumberParserTests_CountryNumbers_WithNationalDestinationCodes
{
    private readonly CountryInfo _countryInfo = TestHelper.CreateCountryInfo(
        ndcLengths: [3, 2],
        nsnLengths: [7]);

    private readonly PhoneNumberParser _parser;

    public DefaultPhoneNumberParserTests_CountryNumbers_WithNationalDestinationCodes() =>
        _parser = new DefaultPhoneNumberParser(
            _countryInfo,
            [
                new CountryNumber(
                    GeographicArea: "Springfield",
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.GeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("40")],
                    SubscriberNumberRanges: [NumberRange.Create("10000-20999"), NumberRange.Create("40000-90999")]),
                new CountryNumber(
                    GeographicArea: "Springfield B",
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.GeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("403")],
                    SubscriberNumberRanges: [NumberRange.Create("1000-2099")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("70")],
                    SubscriberNumberRanges: [NumberRange.Create("10000-10999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Pager,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("71")],
                    SubscriberNumberRanges: [NumberRange.Create("12000-12999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Virtual,
                    Kind: PhoneNumberKind.MobilePhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("72")],
                    SubscriberNumberRanges: [NumberRange.Create("13000-13999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("50")],
                    SubscriberNumberRanges: [NumberRange.Create("20000-20999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.Freephone,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("60")],
                    SubscriberNumberRanges: [NumberRange.Create("28000-28999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.PremiumRate,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("70")],
                    SubscriberNumberRanges: [NumberRange.Create("28000-28999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.SharedCost,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("80")],
                    SubscriberNumberRanges: [NumberRange.Create("28000-28999")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.MachineToMachine,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("90")],
                    SubscriberNumberRanges: [NumberRange.Create("28000-28999")]),
            ]);

    [Fact]
    public void Parse_GeographicPhoneNumber()
    {
        var phoneNumber = _parser.Parse("4010000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal("40", geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, geographicPhoneNumber.Country);
        Assert.Equal("Springfield", geographicPhoneNumber.GeographicArea);
        Assert.Equal("10000", geographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, geographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_GeographicPhoneNumber_In_Sub_NationalDestinationCode()
    {
        var phoneNumber = _parser.Parse("4031000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal("403", geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, geographicPhoneNumber.Country);
        Assert.Equal("Springfield B", geographicPhoneNumber.GeographicArea);
        Assert.Equal("1000", geographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.GeographicPhoneNumber, geographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_Invalid_Number() =>
        Assert.Equal("The national significant number 9005500 is not a valid Zulu phone number.", _parser.Parse("9005500").ParseError);

    [Fact]
    public void Parse_MobilePhoneNumber()
    {
        var phoneNumber = _parser.Parse("7010000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal("70", mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal("10000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_MobilePhoneNumber_Pager()
    {
        var phoneNumber = _parser.Parse("7112000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal("71", mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.True(mobilePhoneNumber.IsPager);
        Assert.False(mobilePhoneNumber.IsVirtual);
        Assert.Equal("12000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_MobilePhoneNumber_Virtual()
    {
        var phoneNumber = _parser.Parse("7213000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<MobilePhoneNumber>(phoneNumber);

        var mobilePhoneNumber = (MobilePhoneNumber)phoneNumber;
        Assert.Equal("72", mobilePhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, mobilePhoneNumber.Country);
        Assert.False(mobilePhoneNumber.IsPager);
        Assert.True(mobilePhoneNumber.IsVirtual);
        Assert.Equal("13000", mobilePhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.MobilePhoneNumber, mobilePhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber()
    {
        var phoneNumber = _parser.Parse("5020000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("50", nonGeographicPhoneNumber.NationalDestinationCode);
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
        var phoneNumber = _parser.Parse("6028000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("60", nonGeographicPhoneNumber.NationalDestinationCode);
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
        var phoneNumber = _parser.Parse("9028000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("90", nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_PremiumRate()
    {
        var phoneNumber = _parser.Parse("7028000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("70", nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact]
    public void Parse_NonGeographicPhoneNumber_SharedCost()
    {
        var phoneNumber = _parser.Parse("8028000").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("80", nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(_countryInfo, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.True(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal("28000", nonGeographicPhoneNumber.SubscriberNumber);
        Assert.Equal(PhoneNumberKind.NonGeographicPhoneNumber, nonGeographicPhoneNumber.Kind);
    }

    [Fact] // This scenario exists within Germany
    public void Parse_When_Nsn_Shorter_Than_Some_Ndc_Lengths()
    {
        var parser = new DefaultPhoneNumberParser(
            TestHelper.CreateCountryInfo(ndcLengths: [5, 2], nsnLengths: [7, 4]),
            [
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("10000")],
                    SubscriberNumberRanges: [NumberRange.Create("00-99")]),
                new CountryNumber(
                    GeographicArea: null,
                    Hint: PhoneNumberHint.None,
                    Kind: PhoneNumberKind.NonGeographicPhoneNumber,
                    NationalDestinationCodeRanges: [NumberRange.Create("18")],
                    SubscriberNumberRanges: [NumberRange.Create("00-99")]),
            ]);

        var phoneNumber = parser.Parse("1801").PhoneNumber;
        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal("18", nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal("01", nonGeographicPhoneNumber.SubscriberNumber);
    }
}
