namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class without <see cref="CountryNumber"/>s using area codes.
/// </summary>
public class DefaultPhoneNumberParserTests_CountryNumbers_WithoutNationalDestinationCodes
{
    private readonly CountryInfo _countryInfo = TestHelper.CreateCountryInfo(nsnLengths: new[] { 5 });

    private readonly PhoneNumberParser _parser;

    public DefaultPhoneNumberParserTests_CountryNumbers_WithoutNationalDestinationCodes() =>
        _parser = new DefaultPhoneNumberParser(
            _countryInfo,
            new[]
            {
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("10000-10999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = PhoneNumberHint.None,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("12000-12999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = PhoneNumberHint.Pager,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("13000-13999") },
                    Kind = PhoneNumberKind.MobilePhoneNumber,
                    Hint = PhoneNumberHint.Virtual,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("20000-20999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = PhoneNumberHint.None,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("28000-28999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = PhoneNumberHint.Freephone,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("29000-29999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = PhoneNumberHint.PremiumRate,
                },
                new CountryNumber
                {
                    GeographicArea = "Springfield",
                    SubscriberNumberRanges = new[] { NumberRange.Create("30000-30999") },
                    Kind = PhoneNumberKind.GeographicPhoneNumber,
                    Hint = PhoneNumberHint.None,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("31000-31999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = PhoneNumberHint.SharedCost,
                },
                new CountryNumber
                {
                    SubscriberNumberRanges = new[] { NumberRange.Create("41000-41999") },
                    Kind = PhoneNumberKind.NonGeographicPhoneNumber,
                    Hint = PhoneNumberHint.MachineToMachine,
                },
            });

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
