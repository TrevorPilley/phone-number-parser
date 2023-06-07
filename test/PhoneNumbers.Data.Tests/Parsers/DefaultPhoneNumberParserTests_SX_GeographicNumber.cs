namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Sint maarten <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_SX_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.SintMaarten);

    [Theory]
    [InlineData("7215420000", "721", "5420000", "Philipsburg/Pointe Blanche/Guana Bay/Oyster Pond")]
    [InlineData("7215439999", "721", "5439999", "Philipsburg/Pointe Blanche/Guana Bay/Oyster Pond")]
    [InlineData("7215440000", "721", "5440000", "Colebay/Pelican/Caybay")]
    [InlineData("7215449999", "721", "5449999", "Colebay/Pelican/Caybay")]
    [InlineData("7215450000", "721", "5450000", "Simpson Bay/Beacon Hill/Maho/Cupecoy")]
    [InlineData("7215459999", "721", "5459999", "Simpson Bay/Beacon Hill/Maho/Cupecoy")]
    [InlineData("7215470000", "721", "5470000", "Dutch Quarter/Middle Region/Belvedere")]
    [InlineData("7215479999", "721", "5479999", "Dutch Quarter/Middle Region/Belvedere")]
    [InlineData("7215480000", "721", "5480000", "Cul de Sac/Ebenezer/South Reward/Betty’s Estate/Saunders")]
    [InlineData("7215489999", "721", "5489999", "Cul de Sac/Ebenezer/South Reward/Betty’s Estate/Saunders")]
    public void Parse_Known_GeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.SintMaarten, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
