namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Slovenia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SI_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Slovenia);

    [Theory]
    [InlineData("049000000", "49", "000000")]
    [InlineData("049999999", "49", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("081000000", "810", "00000")]
    [InlineData("081099999", "810", "99999")]
    [InlineData("081700000", "817", "00000")]
    [InlineData("081799999", "817", "99999")]
    [InlineData("081800000", "8180", "0000")]
    [InlineData("081809999", "8180", "9999")]
    [InlineData("081890000", "8189", "0000")]
    [InlineData("081899999", "8189", "9999")]
    [InlineData("081900000", "819", "00000")]
    [InlineData("081999999", "819", "99999")]
    [InlineData("082100000", "821", "00000")]
    [InlineData("082199999", "821", "99999")]
    [InlineData("082200000", "8220", "0000")]
    [InlineData("082209999", "8220", "9999")]
    [InlineData("082290000", "8229", "0000")]
    [InlineData("082299999", "8229", "9999")]
    [InlineData("082300000", "823", "00000")]
    [InlineData("082399999", "823", "99999")]
    [InlineData("082700000", "827", "00000")]
    [InlineData("082799999", "827", "99999")]
    [InlineData("082800000", "8280", "0000")]
    [InlineData("082809999", "8280", "9999")]
    [InlineData("082890000", "8289", "0000")]
    [InlineData("082899999", "8289", "9999")]
    [InlineData("082900000", "829", "00000")]
    [InlineData("082999999", "829", "99999")]
    [InlineData("083900000", "839", "00000")]
    [InlineData("083999999", "839", "99999")]
    [InlineData("088000000", "88", "000000")]
    [InlineData("088999999", "88", "999999")]
    [InlineData("089100000", "891", "00000")]
    [InlineData("089199999", "891", "99999")]
    [InlineData("089300000", "893", "00000")]
    [InlineData("089399999", "893", "99999")]
    public void Parse_Known_NonGeographicPhoneNumber_8X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("059000000", "590", "00000")]
    [InlineData("059099999", "590", "99999")]
    [InlineData("059900000", "599", "00000")]
    [InlineData("059999999", "599", "99999")]
    public void Parse_Known_NonGeographicPhoneNumber_5XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("080000000", "80", "000000")]
    [InlineData("080999999", "80", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("0910000000000", "91", "0000000000")]
    [InlineData("0919999999999", "91", "9999999999")]
    public void Parse_Known_NonGeographicPhoneNumber_MachineToMachine(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.True(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("090000000", "90", "000000")]
    [InlineData("090999999", "90", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Slovenia, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
