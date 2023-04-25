namespace PhoneNumbers.Tests;

public class PhoneNumberExtensionsTests
{
    [Fact]
    public void NdcIsOptional_False_For_Geographic_Number_With_Local_Dialling_Allowed_Where_NDC_Is_National_Dialling_Only() =>
        Assert.False(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", true, PhoneNumberHint.NationalDiallingOnly).NdcIsOptional());

    [Fact]
    public void NdcIsOptional_True_For_Geographic_Number_With_Local_Dialling_Allowed_Where_NDC_Is_Not_National_Dialling_Only() =>
        Assert.True(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", true, PhoneNumberHint.None).NdcIsOptional());
}
