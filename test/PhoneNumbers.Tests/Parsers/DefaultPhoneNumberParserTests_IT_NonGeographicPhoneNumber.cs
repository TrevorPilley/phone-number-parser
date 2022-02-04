namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Italy <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IT_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Italy);

    [Theory]
    [InlineData("800000000", "800", "000000")]
    [InlineData("800999999", "800", "999999")]
    [InlineData("803000", "803", "000")]
    [InlineData("803999", "803", "999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("45500", "455", "00")]
    [InlineData("45599", "455", "99")]
    [InlineData("47000", "470", "00")]
    [InlineData("47099", "470", "99")]
    [InlineData("47400", "474", "00")]
    [InlineData("47499", "474", "99")]
    [InlineData("4750000", "475", "0000")]
    [InlineData("4759999", "475", "9999")]
    [InlineData("4790000", "479", "0000")]
    [InlineData("4799999", "479", "9999")]
    [InlineData("48000", "480", "00")]
    [InlineData("48099", "480", "99")]
    [InlineData("48400", "484", "00")]
    [InlineData("48499", "484", "99")]
    [InlineData("4850000", "485", "0000")]
    [InlineData("4859999", "485", "9999")]
    [InlineData("4890000", "489", "0000")]
    [InlineData("4899999", "489", "9999")]
    [InlineData("8911100000", "89111", "00000")]
    [InlineData("8911199999", "89111", "99999")]
    [InlineData("892000", "892", "000")]
    [InlineData("892999", "892", "999")]
    [InlineData("894000", "8940", "00")]
    [InlineData("894099", "8940", "99")]
    [InlineData("894400", "8944", "00")]
    [InlineData("894499", "8944", "99")]
    [InlineData("89450000", "8945", "0000")]
    [InlineData("89459999", "8945", "9999")]
    [InlineData("89490000", "8949", "0000")]
    [InlineData("89499999", "8949", "9999")]
    [InlineData("895000", "8950", "00")]
    [InlineData("895099", "8950", "99")]
    [InlineData("895400", "8954", "00")]
    [InlineData("895499", "8954", "99")]
    [InlineData("8955000000", "8955", "000000")]
    [InlineData("8955999999", "8955", "999999")]
    [InlineData("8959000000", "8959", "000000")]
    [InlineData("8959999999", "8959", "999999")]
    [InlineData("899000000", "899", "000000")]
    [InlineData("899999999", "899", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("840000000", "840", "000000")]
    [InlineData("840999999", "840", "999999")]
    [InlineData("841000", "841", "000")]
    [InlineData("841999", "841", "999")]
    [InlineData("847000", "847", "000")]
    [InlineData("847999", "847", "999")]
    [InlineData("848000000", "848", "000000")]
    [InlineData("848999999", "848", "999999")]
    public void Parse_Known_NonGeographicPhoneNumber_SharedCost(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Italy, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.True(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
