namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Bahamas <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_BS_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Bahamas);

    [Theory]
    [InlineData("2422250000", "242", "2250000", "New Providence")]
    [InlineData("2422254999", "242", "2254999", "New Providence")]
    [InlineData("2422256000", "242", "2256000", "New Providence")]
    [InlineData("2422259999", "242", "2259999", "New Providence")]
    [InlineData("2423020000", "242", "3020000", "New Providence")]
    [InlineData("2423029999", "242", "3029999", "New Providence")]
    [InlineData("2423210000", "242", "3210000", "New Providence")]
    [InlineData("2423289999", "242", "3289999", "New Providence")]
    [InlineData("2423290000", "242", "3290000", "Andros")]
    [InlineData("2423299999", "242", "3299999", "Andros")]
    [InlineData("2423312000", "242", "3312000", "Rum Cay/San Salvador")]
    [InlineData("2423313999", "242", "3313999", "Rum Cay/San Salvador")]
    [InlineData("2423320000", "242", "3320000", "Eleuthera")]
    [InlineData("2423359999", "242", "3359999", "Eleuthera")]
    [InlineData("2423360000", "242", "3360000", "Exuma")]
    [InlineData("2423369999", "242", "3369999", "Exuma")]
    [InlineData("2423370000", "242", "3370000", "Long Island")]
    [InlineData("2423379999", "242", "3379999", "Long Island")]
    [InlineData("2423391000", "242", "3391000", "Inagua")]
    [InlineData("2423392999", "242", "3392999", "Inagua")]
    [InlineData("2423393000", "242", "3393000", "Mayaguana")]
    [InlineData("2423394999", "242", "3394999", "Mayaguana")]
    [InlineData("2423400000", "242", "3400000", "New Providence")]
    [InlineData("2423419999", "242", "3419999", "New Providence")]
    [InlineData("2423420000", "242", "3420000", "Cat Island")]
    [InlineData("2423429999", "242", "3429999", "Cat Island")]
    [InlineData("2423441000", "242", "3441000", "Ragged Island")]
    [InlineData("2423441999", "242", "3441999", "Ragged Island")]
    [InlineData("2423442000", "242", "3442000", "Crooked Island")]
    [InlineData("2423442999", "242", "3442999", "Crooked Island")]
    [InlineData("2423443000", "242", "3443000", "Acklins")]
    [InlineData("2423443999", "242", "3443999", "Acklins")]
    [InlineData("2423450000", "242", "3450000", "Exuma")]
    [InlineData("2423459999", "242", "3459999", "Exuma")]
    [InlineData("2423460000", "242", "3460000", "Grand Bahama")]
    [InlineData("2423469999", "242", "3469999", "Grand Bahama")]
    [InlineData("2423470000", "242", "3470000", "Bimini and Cat Cay")]
    [InlineData("2423475999", "242", "3475999", "Bimini and Cat Cay")]
    [InlineData("2423480000", "242", "3480000", "Grand Bahama")]
    [InlineData("2423539999", "242", "3539999", "Grand Bahama")]
    [InlineData("2423540000", "242", "3540000", "Cat Island")]
    [InlineData("2423549999", "242", "3549999", "Cat Island")]
    [InlineData("2423550000", "242", "3550000", "Exuma")]
    [InlineData("2423559999", "242", "3559999", "Exuma")]
    [InlineData("2423560000", "242", "3560000", "New Providence")]
    [InlineData("2423569999", "242", "3569999", "New Providence")]
    [InlineData("2423580000", "242", "3580000", "Exuma")]
    [InlineData("2423589999", "242", "3589999", "Exuma")]
    [InlineData("2423610000", "242", "3610000", "New Providence")]
    [InlineData("2423649999", "242", "3649999", "New Providence")]
    [InlineData("2423650000", "242", "3650000", "Abaco")]
    [InlineData("2423679999", "242", "3679999", "Abaco")]
    [InlineData("2423680000", "242", "3680000", "Andros")]
    [InlineData("2423689999", "242", "3689999", "Andros")]
    [InlineData("2423730000", "242", "3730000", "Grand Bahama")]
    [InlineData("2423749999", "242", "3749999", "Grand Bahama")]
    [InlineData("2423770000", "242", "3770000", "New Providence")]
    [InlineData("2423779999", "242", "3779999", "New Providence")]
    [InlineData("2423800000", "242", "3800000", "New Providence")]
    [InlineData("2423849999", "242", "3849999", "New Providence")]
    [InlineData("2423920000", "242", "3920000", "New Providence")]
    [InlineData("2423949999", "242", "3949999", "New Providence")]
    [InlineData("2423960000", "242", "3960000", "New Providence")]
    [InlineData("2423979999", "242", "3979999", "New Providence")]
    [InlineData("2424610000", "242", "4610000", "New Providence")]
    [InlineData("2424619999", "242", "4619999", "New Providence")]
    [InlineData("2425020000", "242", "5020000", "New Providence")]
    [InlineData("2425029999", "242", "5029999", "New Providence")]
    [InlineData("2426010000", "242", "6010000", "New Providence")]
    [InlineData("2426019999", "242", "6019999", "New Providence")]
    [InlineData("2426020000", "242", "6020000", "Grand Bahama")]
    [InlineData("2426029999", "242", "6029999", "Grand Bahama")]
    [InlineData("2426760000", "242", "6760000", "New Providence")]
    [InlineData("2426779999", "242", "6779999", "New Providence")]
    [InlineData("2426870000", "242", "6870000", "Grand Bahama")]
    [InlineData("2426889999", "242", "6889999", "Grand Bahama")]
    [InlineData("2426980000", "242", "6980000", "New Providence")]
    [InlineData("2426989999", "242", "6989999", "New Providence")]
    [InlineData("2426990000", "242", "6990000", "Abaco")]
    [InlineData("2426994999", "242", "6994999", "Abaco")]
    [InlineData("2426995000", "242", "6995000", "Eleuthera")]
    [InlineData("2426996999", "242", "6996999", "Eleuthera")]
    [InlineData("2427020000", "242", "7020000", "New Providence")]
    [InlineData("2427029999", "242", "7029999", "New Providence")]
    public void Parse_Known_GeographicPhoneNumber_2XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Bahamas, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Equal(NationalDestinationCode, geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
