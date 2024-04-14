namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Tanzania <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TZ_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Tanzania);

    [Theory]
    [InlineData("0410000000", "41", "0000000")]
    [InlineData("0419999999", "41", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0510000000", "51", "0000000")]
    [InlineData("0519999999", "51", "9999999")]
    [InlineData("0580000000", "58", "0000000")]
    [InlineData("0589999999", "58", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_5X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0800110000", "800", "110000")]
    [InlineData("0800129999", "800", "129999")]
    [InlineData("0800710000", "800", "710000")]
    [InlineData("0800719999", "800", "719999")]
    [InlineData("0800750000", "800", "750000")]
    [InlineData("0800759999", "800", "759999")]
    [InlineData("0800780000", "800", "780000")]
    [InlineData("0800789999", "800", "789999")]
    [InlineData("0808000000", "808", "000000")]
    [InlineData("0808009999", "808", "009999")]
    [InlineData("0808110000", "808", "110000")]
    [InlineData("0808119999", "808", "119999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0300010000000", "30001", "0000000")]
    [InlineData("0300019999999", "30001", "9999999")]
    [InlineData("0300050000000", "30005", "0000000")]
    [InlineData("0300059999999", "30005", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0900010000", "900", "010000")]
    [InlineData("0900019999", "900", "019999")]
    [InlineData("0901000000", "901", "000000")]
    [InlineData("0901009999", "901", "009999")]
    [InlineData("0901120000", "901", "120000")]
    [InlineData("0901129999", "901", "129999")]
    [InlineData("0901220000", "901", "220000")]
    [InlineData("0901229999", "901", "229999")]
    [InlineData("0901650000", "901", "650000")]
    [InlineData("0901659999", "901", "659999")]
    [InlineData("0901760000", "901", "760000")]
    [InlineData("0901769999", "901", "769999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Tanzania, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
