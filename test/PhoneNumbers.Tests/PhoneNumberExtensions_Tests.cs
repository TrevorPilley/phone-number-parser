namespace PhoneNumbers.Tests;

public class PhoneNumberExtensions_Tests
{
    [Theory]
    [InlineData("+441142726444", "+441146548866", "6548866")]      // UK Geo to Geo within NDC, local dialling permitted, NDC not required
    [InlineData("+441202454877", "+441202653887", "01202653887")]  // UK Geo to Geo within NDC, local dialling permitted, NDC required for local dialling due to number shortages
    [InlineData("+441142726444", "+441773878912", "01773878912")]  // UK Geo to Geo different NDC
    [InlineData("+441142726444", "+443038709123", "03038709123")]  // UK Geo to NonGeo
    [InlineData("+441142726444", "+447106865391", "07106865391")]  // UK Geo to Mobile
    [InlineData("+441142726444", "+441481717000", "01481717000")]  // UK Geo to Guernsey Geo, countries share calling code
    [InlineData("+447106865391", "+441142726444", "01142726444")]  // UK Mobile to Geo
    [InlineData("+447106865391", "+447712674523", "07712674523")]  // UK Mobile to Mobile
    [InlineData("+447106865391", "+443038709123", "03038709123")]  // UK Mobile to NonGeo
    [InlineData("+447106865391", "+33140477283", "0033140477283")] // UK Mobile to France Geo
    [InlineData("+447106865391", "+33601876543", "0033601876543")] // UK Mobile to France Mobile
    public void NumberToDialFor(string source, string destination, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(source).NumberToDialFor(PhoneNumber.Parse(destination)));
}
