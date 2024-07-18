namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for North macedonia <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_MK_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.NorthMacedonia);

    [Theory]
    [InlineData("022000000", "2", "2000000", "Skopje")]
    [InlineData("029999999", "2", "9999999", "Skopje")]
    public void Parse_Known_GeographicPhoneNumber_2_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.NorthMacedonia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("031200000", "31", "200000", "Kumanovo, Kriva Palanka, Kratovo")]
    [InlineData("031999999", "31", "999999", "Kumanovo, Kriva Palanka, Kratovo")]
    [InlineData("032200000", "32", "200000", "Štip, Probištip, Sveti Nikole, Radoviš")]
    [InlineData("032999999", "32", "999999", "Štip, Probištip, Sveti Nikole, Radoviš")]
    [InlineData("033200000", "33", "200000", "Kočani, Berovo, Delcevo, Vinica")]
    [InlineData("033999999", "33", "999999", "Kočani, Berovo, Delcevo, Vinica")]
    [InlineData("034200000", "34", "200000", "Gevgelija, Valandovo, Strumica, Dojran")]
    [InlineData("034999999", "34", "999999", "Gevgelija, Valandovo, Strumica, Dojran")]
    public void Parse_Known_GeographicPhoneNumber_3X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.NorthMacedonia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("042200000", "42", "200000", "Gostivar")]
    [InlineData("042999999", "42", "999999", "Gostivar")]
    [InlineData("043200000", "43", "200000", "Veles, Kavadarci, Negotino")]
    [InlineData("043999999", "43", "999999", "Veles, Kavadarci, Negotino")]
    [InlineData("044200000", "44", "200000", "Tetovo")]
    [InlineData("044999999", "44", "999999", "Tetovo")]
    [InlineData("045200000", "45", "200000", "Kičevo, Makedonski Brod")]
    [InlineData("045999999", "45", "999999", "Kičevo, Makedonski Brod")]
    [InlineData("046200000", "46", "200000", "Ohrid, Struga, Debar")]
    [InlineData("046999999", "46", "999999", "Ohrid, Struga, Debar")]
    [InlineData("047200000", "47", "200000", "Bitola, Demir Hisar, Resen")]
    [InlineData("047999999", "47", "999999", "Bitola, Demir Hisar, Resen")]
    [InlineData("048200000", "48", "200000", "Prilep, Kruševo")]
    [InlineData("048999999", "48", "999999", "Prilep, Kruševo")]
    public void Parse_Known_GeographicPhoneNumber_4X_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.NorthMacedonia, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
