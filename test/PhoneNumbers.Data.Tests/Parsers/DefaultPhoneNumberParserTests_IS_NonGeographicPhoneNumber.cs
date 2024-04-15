namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Iceland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IS_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Iceland);

    [Theory]
    [InlineData("7500000", "7500000")]
    [InlineData("7509999", "7509999")]
    [InlineData("7550000", "7550000")]
    [InlineData("7559999", "7559999")]
    [InlineData("7570000", "7570000")]
    [InlineData("7579999", "7579999")]
    [InlineData("8010000", "8010000")]
    [InlineData("8099999", "8099999")]
    [InlineData("8780000", "8780000")]
    [InlineData("8809999", "8809999")]
    [InlineData("9090000", "9090000")]
    [InlineData("9099999", "9099999")]
    [InlineData("9540000", "9540000")]
    [InlineData("9549999", "9549999")]
    [InlineData("9580000", "9580000")]
    [InlineData("9589999", "9589999")]
    public void Parse_Known_NonGeographicPhoneNumber(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("8000000", "8000000")]
    [InlineData("8009999", "8009999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("352000000", "352000000")]
    [InlineData("352999999", "352999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0944000", "0944000")]
    [InlineData("9000000", "9000000")]
    [InlineData("9009999", "9009999")]
    [InlineData("9015000", "9015000")]
    [InlineData("9017000", "9017000")]
    [InlineData("9019000", "9019000")]
    [InlineData("9021999", "9021999")]
    [InlineData("9025000", "9025000")]
    [InlineData("9027999", "9027999")]
    [InlineData("9029000", "9029000")]
    [InlineData("9029999", "9029999")]
    [InlineData("9031000", "9031000")]
    [InlineData("9031999", "9031999")]
    [InlineData("9033000", "9033000")]
    [InlineData("9033999", "9033999")]
    [InlineData("9035000", "9035000")]
    [InlineData("9037000", "9037000")]
    [InlineData("9040000", "9040000")]
    [InlineData("9042000", "9042000")]
    [InlineData("9047000", "9047000")]
    [InlineData("9052000", "9052000")]
    [InlineData("9057000", "9057000")]
    [InlineData("9059000", "9059000")]
    [InlineData("9059999", "9059999")]
    [InlineData("9071000", "9071000")]
    [InlineData("9073999", "9073999")]
    [InlineData("9077000", "9077000")]
    [InlineData("9077999", "9077999")]
    [InlineData("9080000", "9080000")]
    [InlineData("9083999", "9083999")]
    [InlineData("9085000", "9085000")]
    [InlineData("9087999", "9087999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Null(nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
