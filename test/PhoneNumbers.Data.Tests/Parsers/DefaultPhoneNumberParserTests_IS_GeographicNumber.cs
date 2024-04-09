namespace PhoneNumbers.Tests.Parsers;

/// <summary>
/// Contains unit tests for the <see cref="DefaultPhoneNumberParser"/> class for Iceland <see cref="PhoneNumber"/>s.
/// </summary>
public class DefaultPhoneNumberParserTests_IS_GeographicNumber
{
    private static readonly PhoneNumberParser s_parser = DefaultPhoneNumberParser.Create(CountryInfo.Iceland);

    [Theory]
    [InlineData("4100000", "4100000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4129999", "4129999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4140000", "4140000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4169999", "4169999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4190000", "4190000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4279999", "4279999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4300000", "4300000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4400000", "4400000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4429999", "4429999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4440000", "4440000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4459999", "4459999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4480000", "4480000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4489999", "4489999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4500000", "4500000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4539999", "4539999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4550000", "4550000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4569999", "4569999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4580000", "4580000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4589999", "4589999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4600000", "4600000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4810000", "4810000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4839999", "4839999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4860000", "4860000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4889999", "4889999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4920000", "4920000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4969999", "4969999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4970000", "4970000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4979999", "4979999", "Excluding Reykjavík and Capital Region")]
    [InlineData("4990000", "4990000", "Excluding Reykjavík and Capital Region")]
    [InlineData("4999999", "4999999", "Excluding Reykjavík and Capital Region")]
    [InlineData("5050000", "5050000", "Reykjavík and Capital Region")]
    [InlineData("5059999", "5059999", "Reykjavík and Capital Region")]
    [InlineData("5100000", "5100000", "Reykjavík and Capital Region")]
    [InlineData("5179999", "5179999", "Reykjavík and Capital Region")]
    [InlineData("5190000", "5190000", "Reykjavík and Capital Region")]
    [InlineData("5209999", "5209999", "Reykjavík and Capital Region")]
    [InlineData("5220000", "5220000", "Reykjavík and Capital Region")]
    [InlineData("5229999", "5229999", "Reykjavík and Capital Region")]
    [InlineData("5250000", "5250000", "Reykjavík and Capital Region")]
    [InlineData("5259999", "5259999", "Reykjavík and Capital Region")]
    [InlineData("5270000", "5270000", "Reykjavík and Capital Region")]
    [InlineData("5289999", "5289999", "Reykjavík and Capital Region")]
    [InlineData("5300000", "5300000", "Reykjavík and Capital Region")]
    [InlineData("5359999", "5359999", "Reykjavík and Capital Region")]
    [InlineData("5370000", "5370000", "Reykjavík and Capital Region")]
    [InlineData("5379999", "5379999", "Reykjavík and Capital Region")]
    [InlineData("5390000", "5390000", "Reykjavík and Capital Region")]
    [InlineData("5409999", "5409999", "Reykjavík and Capital Region")]
    [InlineData("5430000", "5430000", "Reykjavík and Capital Region")]
    [InlineData("5479999", "5479999", "Reykjavík and Capital Region")]
    [InlineData("5500000", "5500000", "Reykjavík and Capital Region")]
    [InlineData("5729999", "5729999", "Reykjavík and Capital Region")]
    [InlineData("5750000", "5750000", "Reykjavík and Capital Region")]
    [InlineData("5759999", "5759999", "Reykjavík and Capital Region")]
    [InlineData("5770000", "5770000", "Reykjavík and Capital Region")]
    [InlineData("5789999", "5789999", "Reykjavík and Capital Region")]
    [InlineData("5800000", "5800000", "Reykjavík and Capital Region")]
    [InlineData("5839999", "5839999", "Reykjavík and Capital Region")]
    [InlineData("5850000", "5850000", "Reykjavík and Capital Region")]
    [InlineData("5919999", "5919999", "Reykjavík and Capital Region")]
    [InlineData("5930000", "5930000", "Reykjavík and Capital Region")]
    [InlineData("5969999", "5969999", "Reykjavík and Capital Region")]
    [InlineData("5980000", "5980000", "Reykjavík and Capital Region")]
    [InlineData("5999999", "5999999", "Reykjavík and Capital Region")]
    [InlineData("43809999", "43809999", "Excluding Reykjavík and Capital Region")]
    [InlineData("464789999", "464789999", "Excluding Reykjavík and Capital Region")]
    public void Parse_Known_GeographicPhoneNumber(string value, string subscriberNumber, string geographicArea)
    {
        var parseResult = s_parser.Parse(value);
        parseResult.ThrowIfFailure();

        var phoneNumber = parseResult.PhoneNumber;

        Assert.NotNull(phoneNumber);
        Assert.IsType<GeographicPhoneNumber>(phoneNumber);

        var geographicPhoneNumber = (GeographicPhoneNumber)phoneNumber;
        Assert.Equal(CountryInfo.Iceland, geographicPhoneNumber.Country);
        Assert.Equal(geographicArea, geographicPhoneNumber.GeographicArea);
        Assert.Null(geographicPhoneNumber.NationalDestinationCode);
        Assert.Equal(subscriberNumber, geographicPhoneNumber.SubscriberNumber);
    }
}
