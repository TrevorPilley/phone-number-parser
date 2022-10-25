namespace PhoneNumbers.Tests;

public class PhoneNumber_TryParse_Tests
{
    [Fact]
    public void TryParse_Value_With_Austria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+43171100", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Belarus_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+375172171185", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Belgium_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3250444646", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Bulgaria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35929492760", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Croatia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+38517007007", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_CzechRepublic_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+420224004111", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Denmark_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4533926700", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Egypt_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+20235344239", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Estonia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3726672072", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Finland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+358295390361", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_France_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+33140477283", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Germany_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+49228141177", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Gibraltar_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35020074636", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Greece_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+302106151000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Guernsey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441481717000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_HongKong_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+85229616333", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Hungary_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3614680666", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Ireland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+35318049600", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_IsleOfMan_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441624696300", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Italy_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+393492525255", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Jersey_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+441534716800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Kosovo_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+38338212345", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Macau_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+85328000000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Moldova_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+37322251317", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Monaco_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+37798988800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Netherlands_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+31702140214", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Nigeria_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+23494617000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Norway_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4722824600", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Poland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+48222455856", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Portugal_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+351217211000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Romania_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+40372845414", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_SanMarino_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+3780549882555", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Serbia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+381112026828", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Singapore_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+6563773800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Slovakia_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+421257881101", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_SouthAfrica_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+27215616800", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Spain_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+34912582852", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Sweden_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+4686785500", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_Switzerland_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+41584605511", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Ukraine_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+380442819196", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void TryParse_Value_With_UnitedKingdom_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("+442079813000", out var phoneNumber));
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }
}
