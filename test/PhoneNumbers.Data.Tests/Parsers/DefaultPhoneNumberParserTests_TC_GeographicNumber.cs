namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Turks and caicos islands <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_TC_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.TurksAndCaicosIslands);

    [Theory]
    [InlineData("6499400000", "649", "9400000", "East Caicos")]
    [InlineData("6499409999", "649", "9409999", "East Caicos")]
    [InlineData("6499410000", "649", "9410000", "Providenciales")]
    [InlineData("6499419999", "649", "9419999", "Providenciales")]
    [InlineData("6499420000", "649", "9420000", "Ambergris Cay")]
    [InlineData("6499429999", "649", "9429999", "Ambergris Cay")]
    [InlineData("6499430000", "649", "9430000", "South Caicos")]
    [InlineData("6499439999", "649", "9439999", "South Caicos")]
    [InlineData("6499440000", "649", "9440000", "Middle Caicos")]
    [InlineData("6499449999", "649", "9449999", "Middle Caicos")]
    [InlineData("6499450000", "649", "9450000", "Salt Cay")]
    [InlineData("6499459999", "649", "9459999", "Salt Cay")]
    [InlineData("6499460000", "649", "9460000", "Grand Turk")]
    [InlineData("6499469999", "649", "9469999", "Grand Turk")]
    [InlineData("6499470000", "649", "9470000", "North Caicos")]
    [InlineData("6499479999", "649", "9479999", "North Caicos")]
    [InlineData("6499480000", "649", "9480000", "Pine Cay")]
    [InlineData("6499489999", "649", "9489999", "Pine Cay")]
    [InlineData("6499490000", "649", "9490000", "Parrot Cay")]
    [InlineData("6499499999", "649", "9499999", "Parrot Cay")]
    [InlineData("6499500000", "649", "9500000", "West Caicos")]
    [InlineData("6499509999", "649", "9509999", "West Caicos")]
    public void Parse_Known_GeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.TurksAndCaicosIslands, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
