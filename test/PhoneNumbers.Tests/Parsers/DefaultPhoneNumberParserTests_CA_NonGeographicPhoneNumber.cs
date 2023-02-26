namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Canada <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_CA_NonGeographicPhoneNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Canada);

    [Theory]
    [InlineData("16002000000", "600", "2000000")]
    [InlineData("16009999999", "600", "9999999")]
    [InlineData("16222000000", "622", "2000000")]
    [InlineData("16229999999", "622", "9999999")]
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
    [InlineData("17102000000", "710", "2000000")]
    [InlineData("17102109999", "710", "2109999")]
    [InlineData("17102120000", "710", "2120000")]
    [InlineData("17103109999", "710", "3109999")]
    [InlineData("17103120000", "710", "3120000")]
    [InlineData("17104109999", "710", "4109999")]
    [InlineData("17104120000", "710", "4120000")]
    [InlineData("17105109999", "710", "5109999")]
    [InlineData("17105120000", "710", "5120000")]
    [InlineData("17106109999", "710", "6109999")]
    [InlineData("17106120000", "710", "6120000")]
    [InlineData("17107109999", "710", "7109999")]
    [InlineData("17107120000", "710", "7120000")]
    [InlineData("17108109999", "710", "8109999")]
    [InlineData("17108120000", "710", "8120000")]
    [InlineData("17109109999", "710", "9109999")]
    [InlineData("17109120000", "710", "9120000")]
    [InlineData("17109999999", "710", "9999999")]
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
    [InlineData("18000000000", "800", "0000000")]
    [InlineData("18002709999", "800", "2709999")]
    [InlineData("18002720000", "800", "2720000")]
    [InlineData("18003889999", "800", "3889999")]
    [InlineData("18003900000", "800", "3900000")]
    [InlineData("18004149999", "800", "4149999")]
    [InlineData("18004160000", "800", "4160000")]
    [InlineData("18004839999", "800", "4839999")]
    [InlineData("18004850000", "800", "4850000")]
    [InlineData("18005339999", "800", "5339999")]
    [InlineData("18005350000", "800", "5350000")]
    [InlineData("18006229999", "800", "6229999")]
    [InlineData("18006240000", "800", "6240000")]
    [InlineData("18007029999", "800", "7029999")]
    [InlineData("18007040000", "800", "7040000")]
    [InlineData("18007439999", "800", "7439999")]
    [InlineData("18007450000", "800", "7450000")]
    [InlineData("18007509999", "800", "7509999")]
    [InlineData("18007520000", "800", "7520000")]
    [InlineData("18009039999", "800", "9039999")]
    [InlineData("18009050000", "800", "9050000")]
    [InlineData("18009069999", "800", "9069999")]
    [InlineData("18009080000", "800", "9080000")]
    [InlineData("18009109999", "800", "9109999")]
    [InlineData("18009129999", "800", "9129999")]
    [InlineData("18009999999", "800", "9999999")]
    [InlineData("18330000000", "833", "0000000")]
    [InlineData("18339109999", "833", "9109999")]
    [InlineData("18339120000", "833", "9120000")]
    [InlineData("18339999999", "833", "9999999")]
    [InlineData("18440000000", "844", "0000000")]
    [InlineData("18449109999", "844", "9109999")]
    [InlineData("18449120000", "844", "9120000")]
    [InlineData("18449999999", "844", "9999999")]
    [InlineData("18550000000", "855", "0000000")]
    [InlineData("18559109999", "855", "9109999")]
    [InlineData("18559120000", "855", "9120000")]
    [InlineData("18559999999", "855", "9999999")]
    [InlineData("18660000000", "866", "0000000")]
    [InlineData("18669109999", "866", "9109999")]
    [InlineData("18669120000", "866", "9120000")]
    [InlineData("18669999999", "866", "9999999")]
    [InlineData("18770000000", "877", "0000000")]
    [InlineData("18779109999", "877", "9109999")]
    [InlineData("18779120000", "877", "9120000")]
    [InlineData("18779999999", "877", "9999999")]
    [InlineData("18880000000", "888", "0000000")]
    [InlineData("18889109999", "888", "9109999")]
    [InlineData("18889120000", "888", "9120000")]
    [InlineData("18889999999", "888", "9999999")]
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
    [InlineData("19003230000", "900", "3230000")]
    [InlineData("19003239999", "900", "3239999")]
    [InlineData("19004160000", "900", "4160000")]
    [InlineData("19004169999", "900", "4169999")]
    [InlineData("19004510000", "900", "4510000")]
    [InlineData("19004519999", "900", "4519999")]
    [InlineData("19004560000", "900", "4560000")]
    [InlineData("19004569999", "900", "4569999")]
    [InlineData("19005240000", "900", "5240000")]
    [InlineData("19005249999", "900", "5249999")]
    [InlineData("19005280000", "900", "5280000")]
    [InlineData("19005289999", "900", "5289999")]
    [InlineData("19005480000", "900", "5480000")]
    [InlineData("19005489999", "900", "5489999")]
    [InlineData("19005610000", "900", "5610000")]
    [InlineData("19005619999", "900", "5619999")]
    [InlineData("19005650000", "900", "5650000")]
    [InlineData("19005659999", "900", "5659999")]
    [InlineData("19006040000", "900", "6040000")]
    [InlineData("19006049999", "900", "6049999")]
    [InlineData("19006050000", "900", "6050000")]
    [InlineData("19006059999", "900", "6059999")]
    [InlineData("19006060000", "900", "6060000")]
    [InlineData("19006069999", "900", "6069999")]
    [InlineData("19006300000", "900", "6300000")]
    [InlineData("19006309999", "900", "6309999")]
    [InlineData("19006430000", "900", "6430000")]
    [InlineData("19006439999", "900", "6439999")]
    [InlineData("19006700000", "900", "6700000")]
    [InlineData("19006709999", "900", "6709999")]
    [InlineData("19006770000", "900", "6770000")]
    [InlineData("19006779999", "900", "6779999")]
    [InlineData("19006900000", "900", "6900000")]
    [InlineData("19006909999", "900", "6909999")]
    [InlineData("19007830000", "900", "7830000")]
    [InlineData("19007839999", "900", "7839999")]
    [InlineData("19007880000", "900", "7880000")]
    [InlineData("19007889999", "900", "7889999")]
    [InlineData("19007890000", "900", "7890000")]
    [InlineData("19007899999", "900", "7899999")]
    [InlineData("19008210000", "900", "8210000")]
    [InlineData("19008219999", "900", "8219999")]
    [InlineData("19008300000", "900", "8300000")]
    [InlineData("19008309999", "900", "8309999")]
    [InlineData("19008700000", "900", "8700000")]
    [InlineData("19008709999", "900", "8709999")]
    [InlineData("19008760000", "900", "8760000")]
    [InlineData("19008769999", "900", "8769999")]
    [InlineData("19009040000", "900", "9040000")]
    [InlineData("19009049999", "900", "9049999")]
    [InlineData("19009050000", "900", "9050000")]
    [InlineData("19009059999", "900", "9059999")]
    [InlineData("19009060000", "900", "9060000")]
    [InlineData("19009069999", "900", "9069999")]
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
