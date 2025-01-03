namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for San marino <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SM_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SanMarino);

    [Theory]
    [InlineData("000000", "000000")]
    [InlineData("099999", "099999")]
    [InlineData("500000", "500000")]
    [InlineData("599999", "599999")]
    [InlineData("800000", "800000")]
    [InlineData("899999", "899999")]
    [InlineData("0000000", "0000000")]
    [InlineData("0999999", "0999999")]
    [InlineData("5000000", "5000000")]
    [InlineData("5999999", "5999999")]
    [InlineData("8000000", "8000000")]
    [InlineData("8999999", "8999999")]
    [InlineData("00000000", "00000000")]
    [InlineData("09999999", "09999999")]
    [InlineData("50000000", "50000000")]
    [InlineData("59999999", "59999999")]
    [InlineData("80000000", "80000000")]
    [InlineData("89999999", "89999999")]
    [InlineData("000000000", "000000000")]
    [InlineData("099999999", "099999999")]
    [InlineData("500000000", "500000000")]
    [InlineData("599999999", "599999999")]
    [InlineData("800000000", "800000000")]
    [InlineData("899999999", "899999999")]
    [InlineData("0000000000", "0000000000")]
    [InlineData("0999999999", "0999999999")]
    [InlineData("5000000000", "5000000000")]
    [InlineData("5999999999", "5999999999")]
    [InlineData("8000000000", "8000000000")]
    [InlineData("8999999999", "8999999999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SanMarino, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("700000", "700000")]
    [InlineData("799999", "799999")]
    [InlineData("7000000", "7000000")]
    [InlineData("7999999", "7999999")]
    [InlineData("70000000", "70000000")]
    [InlineData("79999999", "79999999")]
    [InlineData("700000000", "700000000")]
    [InlineData("799999999", "799999999")]
    [InlineData("7000000000", "7000000000")]
    [InlineData("7999999999", "7999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SanMarino, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
