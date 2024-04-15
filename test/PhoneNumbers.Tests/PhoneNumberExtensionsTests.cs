namespace PhoneNumbers.Tests;

public class PhoneNumberExtensionsTests
{
    [Fact]
    public void NdcIsOptional_False_For_Geographic_Number_With_Local_Dialling_Allowed_Where_NDC_Is_National_Dialling_Only() =>
        Assert.False(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", true, PhoneNumberHint.NationalDiallingOnly).NdcIsOptional());

    [Fact]
    public void NdcIsOptional_True_For_Geographic_Number_With_Local_Dialling_Allowed_Where_NDC_Is_Not_National_Dialling_Only() =>
        Assert.True(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", true, PhoneNumberHint.None).NdcIsOptional());

    [Theory]
    [InlineData("+447106865391", "GB", "07106865391")]  // UK number from UK
    [InlineData("+441481717000", "GB", "01481717000")]  // Guernsey number from UK (countries share calling code)
    [InlineData("+33140477283", "GB", "0033140477283")] // France number from UK
    [InlineData("+33140477283", "US", "01133140477283")] // France number from US
    [InlineData("+12124841200", "GB", "0012124841200")] // US number from UK
    [InlineData("+447106865391", "US", "011447106865391")] // UK number from US
    [InlineData("+25420424200", "TZ", "00520424200")] // Kenya from Tanzania (uses 005 instead of +255)
    [InlineData("+255222199760", "KE", "007222199760")] // Tanzania from Kenya (uses 007 instead of +254)
    public void NumberToDialFrom_CountryInfo(string source, string countryCode, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(source).NumberToDialFrom(ParseOptions.Default.GetCountryInfo(countryCode)));

    [Theory]
    [InlineData("+441146548866", "+441142726444", "6548866")]      // UK Geo to Geo within NDC, local dialling permitted, NDC not required
    [InlineData("+441202653887", "+441202454877", "01202653887")]  // UK Geo to Geo within NDC, local dialling permitted, NDC required for local dialling due to number shortages
    [InlineData("+441773878912", "+441142726444", "01773878912")]  // UK Geo to Geo different NDC
    [InlineData("+443038709123", "+441142726444", "03038709123")]  // UK Geo to NonGeo
    [InlineData("+447106865391", "+441142726444", "07106865391")]  // UK Geo to Mobile
    [InlineData("+441481717000", "+441142726444", "01481717000")]  // UK Geo to Guernsey Geo, countries share calling code
    [InlineData("+441142726444", "+447106865391", "01142726444")]  // UK Mobile to Geo
    [InlineData("+447712674523", "+447106865391", "07712674523")]  // UK Mobile to Mobile
    [InlineData("+443038709123", "+447106865391", "03038709123")]  // UK Mobile to NonGeo
    [InlineData("+33140477283", "+447106865391", "0033140477283")] // UK Mobile to France Geo
    [InlineData("+33601876543", "+447106865391", "0033601876543")] // UK Mobile to France Mobile
    [InlineData("+447712674523", "+12124841200", "011447712674523")] // US to UK Mobile
    [InlineData("+85229616333", "+85229615432", "29616333")] // HK to HK
    [InlineData("+25420424200", "+255222199760", "00520424200")] // Kenya from Tanzania (uses 005 instead of +255)
    [InlineData("+255222199760", "+25420424200", "007222199760")] // Tanzania from Kenya (uses 007 instead of +254)
    // Italy to San Marino
    // San Marino to Italy
    // Singapore to Malaysia
    // Malaysia to Singapore
    public void NumberToDialFrom_PhoneNumber(string destination, string source, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(destination).NumberToDialFrom(PhoneNumber.Parse(source)));
}
