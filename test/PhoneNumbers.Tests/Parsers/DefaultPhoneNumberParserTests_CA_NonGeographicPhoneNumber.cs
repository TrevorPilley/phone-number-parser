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
