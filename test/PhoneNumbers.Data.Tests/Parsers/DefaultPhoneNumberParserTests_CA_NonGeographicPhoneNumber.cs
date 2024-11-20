namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Canada <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CA_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Canada);

    [Theory]
    [InlineData("6002000000", "600", "2000000")]
    [InlineData("6002049999", "600", "2049999")]
    [InlineData("6002220000", "600", "2220000")]
    [InlineData("6002229999", "600", "2229999")]
    [InlineData("6002500000", "600", "2500000")]
    [InlineData("6002509999", "600", "2509999")]
    [InlineData("6003450000", "600", "3450000")]
    [InlineData("6003459999", "600", "3459999")]
    [InlineData("6005670000", "600", "5670000")]
    [InlineData("6005679999", "600", "5679999")]
    [InlineData("6006000000", "600", "6000000")]
    [InlineData("6006009999", "600", "6009999")]
    [InlineData("6007000000", "600", "7000000")]
    [InlineData("6007029999", "600", "7029999")]
    [InlineData("6007770000", "600", "7770000")]
    [InlineData("6007779999", "600", "7779999")]
    [InlineData("6008880000", "600", "8880000")]
    [InlineData("6008889999", "600", "8889999")]
    [InlineData("6009990000", "600", "9990000")]
    [InlineData("6009999999", "600", "9999999")]
    [InlineData("6222000000", "622", "2000000")]
    [InlineData("6222109999", "622", "2109999")]
    [InlineData("6222120000", "622", "2120000")]
    [InlineData("6223109999", "622", "3109999")]
    [InlineData("6223120000", "622", "3120000")]
    [InlineData("6224109999", "622", "4109999")]
    [InlineData("6224120000", "622", "4120000")]
    [InlineData("6225109999", "622", "5109999")]
    [InlineData("6225120000", "622", "5120000")]
    [InlineData("6226109999", "622", "6109999")]
    [InlineData("6226120000", "622", "6120000")]
    [InlineData("6227109999", "622", "7109999")]
    [InlineData("6227120000", "622", "7120000")]
    [InlineData("6228109999", "622", "8109999")]
    [InlineData("6228120000", "622", "8120000")]
    [InlineData("6229109999", "622", "9109999")]
    [InlineData("6229120000", "622", "9120000")]
    [InlineData("6229999999", "622", "9999999")]
    [InlineData("6330000000", "633", "0000000")]
    [InlineData("6339999999", "633", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_6XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Canada, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("7102000000", "710", "2000000")]
    [InlineData("7102109999", "710", "2109999")]
    [InlineData("7102120000", "710", "2120000")]
    [InlineData("7103109999", "710", "3109999")]
    [InlineData("7103120000", "710", "3120000")]
    [InlineData("7104109999", "710", "4109999")]
    [InlineData("7104120000", "710", "4120000")]
    [InlineData("7105109999", "710", "5109999")]
    [InlineData("7105120000", "710", "5120000")]
    [InlineData("7106109999", "710", "6109999")]
    [InlineData("7106120000", "710", "6120000")]
    [InlineData("7107109999", "710", "7109999")]
    [InlineData("7107120000", "710", "7120000")]
    [InlineData("7108109999", "710", "8109999")]
    [InlineData("7108120000", "710", "8120000")]
    [InlineData("7109109999", "710", "9109999")]
    [InlineData("7109120000", "710", "9120000")]
    [InlineData("7109999999", "710", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_7XX_NationalDestinationCode(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Canada, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("8000000000", "800", "0000000")]
    [InlineData("8002709999", "800", "2709999")]
    [InlineData("8002720000", "800", "2720000")]
    [InlineData("8003889999", "800", "3889999")]
    [InlineData("8003900000", "800", "3900000")]
    [InlineData("8004149999", "800", "4149999")]
    [InlineData("8004160000", "800", "4160000")]
    [InlineData("8004839999", "800", "4839999")]
    [InlineData("8004850000", "800", "4850000")]
    [InlineData("8005339999", "800", "5339999")]
    [InlineData("8005350000", "800", "5350000")]
    [InlineData("8006229999", "800", "6229999")]
    [InlineData("8006240000", "800", "6240000")]
    [InlineData("8007029999", "800", "7029999")]
    [InlineData("8007040000", "800", "7040000")]
    [InlineData("8007439999", "800", "7439999")]
    [InlineData("8007450000", "800", "7450000")]
    [InlineData("8007509999", "800", "7509999")]
    [InlineData("8007520000", "800", "7520000")]
    [InlineData("8009039999", "800", "9039999")]
    [InlineData("8009050000", "800", "9050000")]
    [InlineData("8009069999", "800", "9069999")]
    [InlineData("8009080000", "800", "9080000")]
    [InlineData("8009109999", "800", "9109999")]
    [InlineData("8009129999", "800", "9129999")]
    [InlineData("8009999999", "800", "9999999")]
    [InlineData("8330000000", "833", "0000000")]
    [InlineData("8339109999", "833", "9109999")]
    [InlineData("8339120000", "833", "9120000")]
    [InlineData("8339999999", "833", "9999999")]
    [InlineData("8440000000", "844", "0000000")]
    [InlineData("8449109999", "844", "9109999")]
    [InlineData("8449120000", "844", "9120000")]
    [InlineData("8449999999", "844", "9999999")]
    [InlineData("8550000000", "855", "0000000")]
    [InlineData("8559109999", "855", "9109999")]
    [InlineData("8559120000", "855", "9120000")]
    [InlineData("8559999999", "855", "9999999")]
    [InlineData("8660000000", "866", "0000000")]
    [InlineData("8669109999", "866", "9109999")]
    [InlineData("8669120000", "866", "9120000")]
    [InlineData("8669999999", "866", "9999999")]
    [InlineData("8770000000", "877", "0000000")]
    [InlineData("8779109999", "877", "9109999")]
    [InlineData("8779120000", "877", "9120000")]
    [InlineData("8779999999", "877", "9999999")]
    [InlineData("8880000000", "888", "0000000")]
    [InlineData("8889109999", "888", "9109999")]
    [InlineData("8889120000", "888", "9120000")]
    [InlineData("8889999999", "888", "9999999")]
    public void Parse_Known_NonGeographicPhoneNumber_Freephone(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Canada, nonGeographicPhoneNumber.Country);
        Assert.True(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.False(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }

    [Theory]
    [InlineData("9003230000", "900", "3230000")]
    [InlineData("9003239999", "900", "3239999")]
    [InlineData("9004160000", "900", "4160000")]
    [InlineData("9004169999", "900", "4169999")]
    [InlineData("9004510000", "900", "4510000")]
    [InlineData("9004519999", "900", "4519999")]
    [InlineData("9004560000", "900", "4560000")]
    [InlineData("9004569999", "900", "4569999")]
    [InlineData("9005240000", "900", "5240000")]
    [InlineData("9005249999", "900", "5249999")]
    [InlineData("9005280000", "900", "5280000")]
    [InlineData("9005289999", "900", "5289999")]
    [InlineData("9005480000", "900", "5480000")]
    [InlineData("9005489999", "900", "5489999")]
    [InlineData("9005610000", "900", "5610000")]
    [InlineData("9005619999", "900", "5619999")]
    [InlineData("9005650000", "900", "5650000")]
    [InlineData("9005659999", "900", "5659999")]
    [InlineData("9006040000", "900", "6040000")]
    [InlineData("9006069999", "900", "6069999")]
    [InlineData("9006300000", "900", "6300000")]
    [InlineData("9006309999", "900", "6309999")]
    [InlineData("9006430000", "900", "6430000")]
    [InlineData("9006439999", "900", "6439999")]
    [InlineData("9006700000", "900", "6700000")]
    [InlineData("9006709999", "900", "6709999")]
    [InlineData("9006770000", "900", "6770000")]
    [InlineData("9006779999", "900", "6779999")]
    [InlineData("9006900000", "900", "6900000")]
    [InlineData("9006909999", "900", "6909999")]
    [InlineData("9007830000", "900", "7830000")]
    [InlineData("9007839999", "900", "7839999")]
    [InlineData("9007880000", "900", "7880000")]
    [InlineData("9007899999", "900", "7899999")]
    [InlineData("9008210000", "900", "8210000")]
    [InlineData("9008219999", "900", "8219999")]
    [InlineData("9008300000", "900", "8300000")]
    [InlineData("9008309999", "900", "8309999")]
    [InlineData("9008700000", "900", "8700000")]
    [InlineData("9008709999", "900", "8709999")]
    [InlineData("9008760000", "900", "8760000")]
    [InlineData("9008769999", "900", "8769999")]
    [InlineData("9009040000", "900", "9040000")]
    [InlineData("9009069999", "900", "9069999")]
    public void Parse_Known_NonGeographicPhoneNumber_PremiumRate(string value, string NationalDestinationCode, string subscriberNumber)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<NonGeographicPhoneNumber>(phoneNumber);

        var nonGeographicPhoneNumber = (NonGeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Canada, nonGeographicPhoneNumber.Country);
        Assert.False(nonGeographicPhoneNumber.IsFreephone);
        Assert.False(nonGeographicPhoneNumber.IsMachineToMachine);
        Assert.True(nonGeographicPhoneNumber.IsPremiumRate);
        Assert.False(nonGeographicPhoneNumber.IsSharedCost);
        Assert.Equal(NationalDestinationCode, nonGeographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, nonGeographicPhoneNumber.SubscriberNumber);
    }
}
