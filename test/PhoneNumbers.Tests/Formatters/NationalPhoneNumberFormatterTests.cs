using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests.Formatters;

/// <summary>
/// Contains unit tests for the <see cref="NationalPhoneNumberFormatter"/> class.
/// </summary>
public class NationalPhoneNumberFormatterTests
{
    [Fact]
    public void CanFormat_Returns_False_For_Not_N() =>
        Assert.False(NationalPhoneNumberFormatter.Instance.CanFormat("E.164"));

    [Fact]
    public void CanFormat_Returns_False_For_Null() =>
        Assert.False(NationalPhoneNumberFormatter.Instance.CanFormat(null));

    [Fact]
    public void CanFormat_Returns_True_For_N() =>
        Assert.True(NationalPhoneNumberFormatter.Instance.CanFormat("N"));

    [Fact]
    public void Format_Geographic_With_Ndc_And_Sn_With_TrunkPrefix() =>
        Assert.Equal(
            "012345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateGeographicPhoneNumber("0", "12345", "667788")));

    [Fact]
    public void Format_Mobile_With_Ndc_And_Sn_With_TrunkPrefix() =>
        Assert.Equal(
            "012345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateMobilePhoneNumber("0", "12345", "667788")));

    [Fact]
    public void Format_NonGeographic_With_Ndc_And_Sn_With_TrunkPrefix() =>
        Assert.Equal(
            "012345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", "12345", "667788")));

    [Fact]
    public void Format_Geographic_With_Ndc_And_Sn_With_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "(012345) 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateGeographicPhoneNumber("0", "12345", "667788", false)));

    [Fact]
    public void Format_Mobile_With_Ndc_And_Sn_With_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "012345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateMobilePhoneNumber("0", "12345", "667788", false)));

    [Fact]
    public void Format_NonGeographic_With_Ndc_And_Sn_With_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "012345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", "12345", "667788", false)));

    [Fact]
    public void Format_NonGeographic_With_Sn_With_TrunkPrefix() =>
        Assert.Equal(
            "0667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", null, "667788")));

    [Fact]
    public void Format_Geographic_With_Ndc_And_Sn_Without_TrunkPrefix() =>
        Assert.Equal(
            "12345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateGeographicPhoneNumber(null, "12345", "667788")));

    [Fact]
    public void Format_Mobile_With_Ndc_And_Sn_Without_TrunkPrefix() =>
        Assert.Equal(
            "12345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateMobilePhoneNumber(null, "12345", "667788")));

    [Fact]
    public void Format_NonGeographic_With_Ndc_And_Sn_Without_TrunkPrefix() =>
        Assert.Equal(
            "12345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber(null, "12345", "667788")));

    [Fact]
    public void Format_Geographic_With_Ndc_And_Sn_Without_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "(12345) 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateGeographicPhoneNumber(null, "12345", "667788", false)));

    [Fact]
    public void Format_Mobile_With_Ndc_And_Sn_Without_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "12345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateMobilePhoneNumber(null, "12345", "667788", false)));

    [Fact]
    public void Format_NonGeographic_With_Ndc_And_Sn_Without_TrunkPrefix_Ndc_Not_Required_For_Local_Dialling() =>
        Assert.Equal(
            "12345 667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber(null, "12345", "667788", false)));

    [Fact]
    public void Format_NonGeographic_With_Sn_Without_TrunkPrefix() =>
        Assert.Equal(
            "667788",
            NationalPhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber(null, null, "667788")));

    [Fact]
    public void Instance()
    {
        Assert.NotNull(NationalPhoneNumberFormatter.Instance);
        Assert.Same(NationalPhoneNumberFormatter.Instance, NationalPhoneNumberFormatter.Instance);
    }
}
