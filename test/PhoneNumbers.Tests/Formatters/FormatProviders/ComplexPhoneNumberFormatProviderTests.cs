using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers.Tests.Formatters.FormatProviders;

/// <summary>
/// Contains unit tests for the <see cref="ComplexPhoneNumberFormatProvider"/> class.
/// </summary>
public class ComplexPhoneNumberFormatProviderTests
{
    [Theory]
    [InlineData("1234", "####")]
    [InlineData("12345", "#####")]
    [InlineData("123456", "### ###")]
    [InlineData("1234567", "### ####")]
    [InlineData("12345678", "#### ####")]
    [InlineData("123456789", "### ### ###")]
    [InlineData("1234567890", "##########")]
    public void GetFormat_International_No_Ndc(string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(null, null, sn), true));

    [Theory]
    [InlineData("1", "12345", "# #####")]
    [InlineData("1", "123456", "# ### ###")]
    [InlineData("1", "1234567", "# ### ####")]
    [InlineData("1", "12345678", "# #### ####")]
    [InlineData("1", "123456789", "# ### ### ###")]
    [InlineData("1", "1234567890", "# ##########")]
    [InlineData("12", "12345", "## #####")]
    [InlineData("12", "123456", "## ### ###")]
    [InlineData("12", "1234567", "## ### ####")]
    [InlineData("12", "12345678", "## #### ####")]
    [InlineData("12", "123456789", "## ### ### ###")]
    [InlineData("12", "1234567890", "## ##########")]
    [InlineData("123", "12345", "### #####")]
    [InlineData("123", "123456", "### ### ###")]
    [InlineData("123", "1234567", "### ### ####")]
    [InlineData("123", "12345678", "### #### ####")]
    [InlineData("123", "123456789", "### ### ### ###")]
    [InlineData("123", "1234567890", "### ##########")]
    [InlineData("1234", "12345", "#### #####")]
    [InlineData("1234", "123456", "#### ### ###")]
    [InlineData("1234", "1234567", "#### ### ####")]
    [InlineData("1234", "12345678", "#### #### ####")]
    [InlineData("1234", "123456789", "#### ### ### ###")]
    [InlineData("1234", "1234567890", "#### ##########")]
    [InlineData("12345", "12345", "##### #####")]
    [InlineData("12345", "123456", "##### ### ###")]
    [InlineData("12345", "1234567", "##### ### ####")]
    [InlineData("12345", "12345678", "##### #### ####")]
    [InlineData("12345", "123456789", "##### ### ### ###")]
    [InlineData("12345", "1234567890", "##### ##########")]
    public void GetFormat_International_With_Ndc(string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(null, ndc, sn), true));

    [Theory]
    [InlineData("1234", "####")]
    [InlineData("12345", "#####")]
    [InlineData("123456", "### ###")]
    [InlineData("1234567", "### ####")]
    [InlineData("12345678", "#### ####")]
    [InlineData("123456789", "### ### ###")]
    [InlineData("1234567890", "##########")]
    public void GetFormat_National_Closed_Plan_No_TrunkPrefix_No_Ndc(string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(null, null, sn), false));

    [Theory]
    [InlineData("1", "1234", "# ####")]
    [InlineData("1", "12345", "# #####")]
    [InlineData("1", "123456", "# ### ###")]
    [InlineData("1", "1234567", "# ### ####")]
    [InlineData("1", "12345678", "# #### ####")]
    [InlineData("1", "123456789", "# ### ### ###")]
    [InlineData("1", "1234567890", "# ##########")]
    [InlineData("12", "1234", "## ####")]
    [InlineData("12", "12345", "## #####")]
    [InlineData("12", "123456", "## ### ###")]
    [InlineData("12", "1234567", "## ### ####")]
    [InlineData("12", "12345678", "## #### ####")]
    [InlineData("12", "123456789", "## ### ### ###")]
    [InlineData("12", "1234567890", "## ##########")]
    [InlineData("123", "1234", "### ####")]
    [InlineData("123", "12345", "### #####")]
    [InlineData("123", "123456", "### ### ###")]
    [InlineData("123", "1234567", "### ### ####")]
    [InlineData("123", "12345678", "### #### ####")]
    [InlineData("123", "123456789", "### ### ### ###")]
    [InlineData("123", "1234567890", "### ##########")]
    [InlineData("1234", "1234", "#### ####")]
    [InlineData("1234", "12345", "#### #####")]
    [InlineData("1234", "123456", "#### ### ###")]
    [InlineData("1234", "1234567", "#### ### ####")]
    [InlineData("1234", "12345678", "#### #### ####")]
    [InlineData("1234", "123456789", "#### ### ### ###")]
    [InlineData("1234", "1234567890", "#### ##########")]
    [InlineData("12345", "1234", "##### ####")]
    [InlineData("12345", "12345", "##### #####")]
    [InlineData("12345", "123456", "##### ### ###")]
    [InlineData("12345", "1234567", "##### ### ####")]
    [InlineData("12345", "12345678", "##### #### ####")]
    [InlineData("12345", "123456789", "##### ### ### ###")]
    [InlineData("12345", "1234567890", "##### ##########")]
    public void GetFormat_National_Closed_Plan_No_TrunkPrefix_With_Ndc(string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(null, ndc, sn), false));

    [Theory]
    [InlineData("0", "1234", "0####")]
    [InlineData("0", "12345", "0#####")]
    [InlineData("0", "123456", "0### ###")]
    [InlineData("0", "1234567", "0### ####")]
    [InlineData("0", "12345678", "0#### ####")]
    [InlineData("0", "123456789", "0### ### ###")]
    [InlineData("0", "1234567890", "0##########")]
    public void GetFormat_National_Closed_Plan_With_TrunkPrefix_No_Ndc(string trunkPrefix, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, null, sn), false));

    [Theory]
    [InlineData("0", "1", "1234", "0# ####")]
    [InlineData("0", "1", "12345", "0# #####")]
    [InlineData("0", "1", "123456", "0# ### ###")]
    [InlineData("0", "1", "1234567", "0# ### ####")]
    [InlineData("0", "1", "12345678", "0# #### ####")]
    [InlineData("0", "1", "123456789", "0# ### ### ###")]
    [InlineData("0", "1", "1234567890", "0# ##########")]
    [InlineData("0", "12", "1234", "0## ####")]
    [InlineData("0", "12", "12345", "0## #####")]
    [InlineData("0", "12", "123456", "0## ### ###")]
    [InlineData("0", "12", "1234567", "0## ### ####")]
    [InlineData("0", "12", "12345678", "0## #### ####")]
    [InlineData("0", "12", "123456789", "0## ### ### ###")]
    [InlineData("0", "12", "1234567890", "0## ##########")]
    [InlineData("0", "123", "1234", "0### ####")]
    [InlineData("0", "123", "12345", "0### #####")]
    [InlineData("0", "123", "123456", "0### ### ###")]
    [InlineData("0", "123", "1234567", "0### ### ####")]
    [InlineData("0", "123", "12345678", "0### #### ####")]
    [InlineData("0", "123", "123456789", "0### ### ### ###")]
    [InlineData("0", "123", "1234567890", "0### ##########")]
    [InlineData("0", "1234", "1234", "0#### ####")]
    [InlineData("0", "1234", "12345", "0#### #####")]
    [InlineData("0", "1234", "123456", "0#### ### ###")]
    [InlineData("0", "1234", "1234567", "0#### ### ####")]
    [InlineData("0", "1234", "12345678", "0#### #### ####")]
    [InlineData("0", "1234", "123456789", "0#### ### ### ###")]
    [InlineData("0", "1234", "1234567890", "0#### ##########")]
    [InlineData("0", "12345", "1234", "0##### ####")]
    [InlineData("0", "12345", "12345", "0##### #####")]
    [InlineData("0", "12345", "123456", "0##### ### ###")]
    [InlineData("0", "12345", "1234567", "0##### ### ####")]
    [InlineData("0", "12345", "12345678", "0##### #### ####")]
    [InlineData("0", "12345", "123456789", "0##### ### ### ###")]
    [InlineData("0", "12345", "1234567890", "0##### ##########")]
    public void GetFormat_National_Closed_Plan_With_TrunkPrefix_With_Ndc(string trunkPrefix, string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, ndc, sn), false));

    [Theory]
    [InlineData("1", "1234", "(#) ####")]
    [InlineData("1", "12345", "(#) #####")]
    [InlineData("1", "123456", "(#) ### ###")]
    [InlineData("1", "1234567", "(#) ### ####")]
    [InlineData("1", "12345678", "(#) #### ####")]
    [InlineData("1", "123456789", "(#) ### ### ###")]
    [InlineData("1", "1234567890", "(#) ##########")]
    [InlineData("12", "1234", "(##) ####")]
    [InlineData("12", "12345", "(##) #####")]
    [InlineData("12", "123456", "(##) ### ###")]
    [InlineData("12", "1234567", "(##) ### ####")]
    [InlineData("12", "12345678", "(##) #### ####")]
    [InlineData("12", "123456789", "(##) ### ### ###")]
    [InlineData("12", "1234567890", "(##) ##########")]
    [InlineData("123", "1234", "(###) ####")]
    [InlineData("123", "12345", "(###) #####")]
    [InlineData("123", "123456", "(###) ### ###")]
    [InlineData("123", "1234567", "(###) ### ####")]
    [InlineData("123", "12345678", "(###) #### ####")]
    [InlineData("123", "123456789", "(###) ### ### ###")]
    [InlineData("123", "1234567890", "(###) ##########")]
    [InlineData("1234", "1234", "(####) ####")]
    [InlineData("1234", "12345", "(####) #####")]
    [InlineData("1234", "123456", "(####) ### ###")]
    [InlineData("1234", "1234567", "(####) ### ####")]
    [InlineData("1234", "12345678", "(####) #### ####")]
    [InlineData("1234", "123456789", "(####) ### ### ###")]
    [InlineData("1234", "1234567890", "(####) ##########")]
    [InlineData("12345", "1234", "(#####) ####")]
    [InlineData("12345", "12345", "(#####) #####")]
    [InlineData("12345", "123456", "(#####) ### ###")]
    [InlineData("12345", "1234567", "(#####) ### ####")]
    [InlineData("12345", "12345678", "(#####) #### ####")]
    [InlineData("12345", "123456789", "(#####) ### ### ###")]
    [InlineData("12345", "1234567890", "(#####) ##########")]
    public void GetFormat_National_Open_Plan_No_TrunkPrefix_With_Ndc_Geo(string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateGeographicPhoneNumber(null, ndc, sn, true), false));

    [Theory]
    [InlineData("1", "1234", "# ####")]
    [InlineData("1", "12345", "# #####")]
    [InlineData("1", "123456", "# ### ###")]
    [InlineData("1", "1234567", "# ### ####")]
    [InlineData("1", "12345678", "# #### ####")]
    [InlineData("1", "123456789", "# ### ### ###")]
    [InlineData("1", "1234567890", "# ##########")]
    [InlineData("12", "1234", "## ####")]
    [InlineData("12", "12345", "## #####")]
    [InlineData("12", "123456", "## ### ###")]
    [InlineData("12", "1234567", "## ### ####")]
    [InlineData("12", "12345678", "## #### ####")]
    [InlineData("12", "123456789", "## ### ### ###")]
    [InlineData("12", "1234567890", "## ##########")]
    [InlineData("123", "1234", "### ####")]
    [InlineData("123", "12345", "### #####")]
    [InlineData("123", "123456", "### ### ###")]
    [InlineData("123", "1234567", "### ### ####")]
    [InlineData("123", "12345678", "### #### ####")]
    [InlineData("123", "123456789", "### ### ### ###")]
    [InlineData("123", "1234567890", "### ##########")]
    [InlineData("1234", "1234", "#### ####")]
    [InlineData("1234", "12345", "#### #####")]
    [InlineData("1234", "123456", "#### ### ###")]
    [InlineData("1234", "1234567", "#### ### ####")]
    [InlineData("1234", "12345678", "#### #### ####")]
    [InlineData("1234", "123456789", "#### ### ### ###")]
    [InlineData("1234", "1234567890", "#### ##########")]
    [InlineData("12345", "1234", "##### ####")]
    [InlineData("12345", "12345", "##### #####")]
    [InlineData("12345", "123456", "##### ### ###")]
    [InlineData("12345", "1234567", "##### ### ####")]
    [InlineData("12345", "12345678", "##### #### ####")]
    [InlineData("12345", "123456789", "##### ### ### ###")]
    [InlineData("12345", "1234567890", "##### ##########")]
    public void GetFormat_National_Open_Plan_No_TrunkPrefix_With_Ndc_NonGeo(string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(null, ndc, sn, true), false));

    [Theory]
    [InlineData("0", "1", "1234", "(0#) ####")]
    [InlineData("0", "1", "12345", "(0#) #####")]
    [InlineData("0", "1", "123456", "(0#) ### ###")]
    [InlineData("0", "1", "1234567", "(0#) ### ####")]
    [InlineData("0", "1", "12345678", "(0#) #### ####")]
    [InlineData("0", "1", "123456789", "(0#) ### ### ###")]
    [InlineData("0", "1", "1234567890", "(0#) ##########")]
    [InlineData("0", "12", "1234", "(0##) ####")]
    [InlineData("0", "12", "12345", "(0##) #####")]
    [InlineData("0", "12", "123456", "(0##) ### ###")]
    [InlineData("0", "12", "1234567", "(0##) ### ####")]
    [InlineData("0", "12", "12345678", "(0##) #### ####")]
    [InlineData("0", "12", "123456789", "(0##) ### ### ###")]
    [InlineData("0", "12", "1234567890", "(0##) ##########")]
    [InlineData("0", "123", "1234", "(0###) ####")]
    [InlineData("0", "123", "12345", "(0###) #####")]
    [InlineData("0", "123", "123456", "(0###) ### ###")]
    [InlineData("0", "123", "1234567", "(0###) ### ####")]
    [InlineData("0", "123", "12345678", "(0###) #### ####")]
    [InlineData("0", "123", "123456789", "(0###) ### ### ###")]
    [InlineData("0", "123", "1234567890", "(0###) ##########")]
    [InlineData("0", "1234", "1234", "(0####) ####")]
    [InlineData("0", "1234", "12345", "(0####) #####")]
    [InlineData("0", "1234", "123456", "(0####) ### ###")]
    [InlineData("0", "1234", "1234567", "(0####) ### ####")]
    [InlineData("0", "1234", "12345678", "(0####) #### ####")]
    [InlineData("0", "1234", "123456789", "(0####) ### ### ###")]
    [InlineData("0", "1234", "1234567890", "(0####) ##########")]
    [InlineData("0", "12345", "1234", "(0#####) ####")]
    [InlineData("0", "12345", "12345", "(0#####) #####")]
    [InlineData("0", "12345", "123456", "(0#####) ### ###")]
    [InlineData("0", "12345", "1234567", "(0#####) ### ####")]
    [InlineData("0", "12345", "12345678", "(0#####) #### ####")]
    [InlineData("0", "12345", "123456789", "(0#####) ### ### ###")]
    [InlineData("0", "12345", "1234567890", "(0#####) ##########")]
    public void GetFormat_National_Open_Plan_With_TrunkPrefix_With_Ndc_Geo(string trunkPrefix, string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateGeographicPhoneNumber(trunkPrefix, ndc, sn, true), false));

    [Theory]
    [InlineData("0", "1", "1234", "0# ####")]
    [InlineData("0", "1", "12345", "0# #####")]
    [InlineData("0", "1", "123456", "0# ### ###")]
    [InlineData("0", "1", "1234567", "0# ### ####")]
    [InlineData("0", "1", "12345678", "0# #### ####")]
    [InlineData("0", "1", "123456789", "0# ### ### ###")]
    [InlineData("0", "1", "1234567890", "0# ##########")]
    [InlineData("0", "12", "1234", "0## ####")]
    [InlineData("0", "12", "12345", "0## #####")]
    [InlineData("0", "12", "123456", "0## ### ###")]
    [InlineData("0", "12", "1234567", "0## ### ####")]
    [InlineData("0", "12", "12345678", "0## #### ####")]
    [InlineData("0", "12", "123456789", "0## ### ### ###")]
    [InlineData("0", "12", "1234567890", "0## ##########")]
    [InlineData("0", "123", "1234", "0### ####")]
    [InlineData("0", "123", "12345", "0### #####")]
    [InlineData("0", "123", "123456", "0### ### ###")]
    [InlineData("0", "123", "1234567", "0### ### ####")]
    [InlineData("0", "123", "12345678", "0### #### ####")]
    [InlineData("0", "123", "123456789", "0### ### ### ###")]
    [InlineData("0", "123", "1234567890", "0### ##########")]
    [InlineData("0", "1234", "1234", "0#### ####")]
    [InlineData("0", "1234", "12345", "0#### #####")]
    [InlineData("0", "1234", "123456", "0#### ### ###")]
    [InlineData("0", "1234", "1234567", "0#### ### ####")]
    [InlineData("0", "1234", "12345678", "0#### #### ####")]
    [InlineData("0", "1234", "123456789", "0#### ### ### ###")]
    [InlineData("0", "1234", "1234567890", "0#### ##########")]
    [InlineData("0", "12345", "1234", "0##### ####")]
    [InlineData("0", "12345", "12345", "0##### #####")]
    [InlineData("0", "12345", "123456", "0##### ### ###")]
    [InlineData("0", "12345", "1234567", "0##### ### ####")]
    [InlineData("0", "12345", "12345678", "0##### #### ####")]
    [InlineData("0", "12345", "123456789", "0##### ### ### ###")]
    [InlineData("0", "12345", "1234567890", "0##### ##########")]
    public void GetFormat_National_Open_Plan_With_TrunkPrefix_With_Ndc_NonGeo(string trunkPrefix, string ndc, string sn, string expectedMask) =>
        Assert.Equal(
            expectedMask,
            ComplexPhoneNumberFormatProvider.Default.GetFormat(
                TestHelper.CreateNonGeographicPhoneNumber(trunkPrefix, ndc, sn, true), false));
}
