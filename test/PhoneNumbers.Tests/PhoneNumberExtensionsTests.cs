namespace PhoneNumbers.Tests;

public class PhoneNumberExtensionsTests
{
    [Fact]
    public void NdcIsOptional_False_For_Geographic_Number_In_Open_Dialling_Plan_Which_Is_ClosedDialling() =>
        Assert.False(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", NumberingPlanType.Open, PhoneNumberHint.ClosedDialling).NdcIsOptional());

    [Fact]
    public void NdcIsOptional_True_For_Geographic_Number_In_Open_Dialling_Plan_Which_Is_Not_ClosedDialling() =>
        Assert.True(TestHelper.CreateGeographicPhoneNumber("0", "1", "123", NumberingPlanType.Open, PhoneNumberHint.None).NdcIsOptional());
}
