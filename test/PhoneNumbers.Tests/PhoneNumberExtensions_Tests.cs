namespace PhoneNumbers.Tests;

public class PhoneNumberExtensions_Tests
{
    [Theory]
    [InlineData("+441142726444", "+441146548866", "6548866")]     // UK Geo to Geo within NDC, local dialling permitted, NDC not required
    [InlineData("+441202454877", "+441202653887", "01202653887")] // UK Geo to Geo within NDC, local dialling permitted, NDC required for local dialling due to number shortages
    [InlineData("+441142726444", "+441773878912", "01773878912")] // UK Geo to Geo different NDC
    [InlineData("+441142726444", "+443038709123", "03038709123")] // UK Geo to NonGeo
    [InlineData("+441142726444", "+447106865391", "07106865391")] // UK Geo to Mobile
    [InlineData("+441142726444", "+441481717000", "01481717000")] // UK Geo to Guernsey Geo, countries share calling code
    public void NumberToDialFor(string source, string destination, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(source).NumberToDialFor(PhoneNumber.Parse(destination)));
}
