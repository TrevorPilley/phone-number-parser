namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for American samoa <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_AS_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.AmericanSamoa);

    [Theory]
    [InlineData("16846220000", "684", "6220000", "Fagaitua")]
    [InlineData("16846229999", "684", "6229999", "Fagaitua")]
    [InlineData("16846330000", "684", "6330000", "Fagatogo")]
    [InlineData("16846339999", "684", "6339999", "Fagatogo")]
    [InlineData("16846440000", "684", "6440000", "Satala")]
    [InlineData("16846449999", "684", "6449999", "Satala")]
    [InlineData("16846550000", "684", "6550000", "Ofu")]
    [InlineData("16846559999", "684", "6559999", "Ofu")]
    [InlineData("16846770000", "684", "6770000", "Tau")]
    [InlineData("16846779999", "684", "6779999", "Tau")]
    [InlineData("16846880000", "684", "6880000", "Leone")]
    [InlineData("16846889999", "684", "6889999", "Leone")]
    [InlineData("16846910000", "684", "6910000", "Olotela / Aolaan")]
    [InlineData("16846919999", "684", "6919999", "Olotela / Aolaan")]
    [InlineData("16846990000", "684", "6990000", "Tafuna")]
    [InlineData("16846999999", "684", "6999999", "Tafuna")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.AmericanSamoa, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
