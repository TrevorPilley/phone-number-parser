namespace PhoneNumbers.Tests;

public class PhoneNumber_Parse_Tests
{
    [Fact]
    public void Parse_Value_For_Austria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+43171100");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Austria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0171100", CountryInfo.Austria.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Belarus_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+375172171185");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Belarus_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("8172171185", CountryInfo.Belarus.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belarus, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Belgium_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3250444646");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Belgium_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("050444646", CountryInfo.Belgium.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Bulgaria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35929492760");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Bulgaria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("029492760", CountryInfo.Bulgaria.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Croatia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38517007007");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Croatia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("017007007", CountryInfo.Croatia.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Croatia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_CzechRepublic_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+420224004111");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_CzechRepublic_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("224004111", CountryInfo.CzechRepublic.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.CzechRepublic, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Denmark_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4533926700");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Denmark_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4533926700", CountryInfo.Denmark.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Denmark, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Egypt_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+20235344239");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Egypt_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0235344239", CountryInfo.Egypt.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Egypt, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Estonia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3726672072");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Estonia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("6672072", CountryInfo.Estonia.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Estonia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Finland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+358295390361");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Finland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0295390361", CountryInfo.Finland.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Finland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_France_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+33140477283");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_France_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("140477283", CountryInfo.France.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.France, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Germany_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+49228141177");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Germany_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0228141177", CountryInfo.Germany.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Germany, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Gibraltar_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35020074636");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Gibraltar_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("20074636", CountryInfo.Gibraltar.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Greece_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+302106151000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Greece_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("2106151000", CountryInfo.Greece.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Greece, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Guernsey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441481717000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }
    [Fact]
    public void Parse_Value_CountryCode_For_Guernsey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("01481717000", CountryInfo.Guernsey.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_HongKong_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85229616333");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_HongKong_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("29616333", CountryInfo.HongKong.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Hungary_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3614680666");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Hungary_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0614680666", CountryInfo.Hungary.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Hungary, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Ireland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+35318049600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Ireland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("018049600", CountryInfo.Ireland.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_IsleOfMan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441624696300");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_IsleOfMan_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("01624696300", CountryInfo.IsleOfMan.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Italy_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+393492525255");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Italy_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("3492525255", CountryInfo.Italy.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Jersey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+441534716800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Jersey_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("01534716800", CountryInfo.Jersey.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Kosovo_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+38338212345");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Kosovo_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("038212345", CountryInfo.Kosovo.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Kosovo, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Macau_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+85328000000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Macau_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("28000000", CountryInfo.Macau.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Moldova_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37322251317");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Moldova_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("022251317", CountryInfo.Moldova.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Moldova, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Monaco_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+37798988800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Monaco_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("98988800", CountryInfo.Monaco.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Netherlands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+31702140214");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Netherlands_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0702140214", CountryInfo.Netherlands.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Nigeria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+23494617000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Nigeria_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("094617000", CountryInfo.Nigeria.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Nigeria, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Norway_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4722824600");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Norway_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("22824600", CountryInfo.Norway.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Norway, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Poland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+48222455856");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Poland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("222455856", CountryInfo.Poland.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Poland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Portugal_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+351217211000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Portugal_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("217211000", CountryInfo.Portugal.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Romania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+40372845414");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Romania_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0372845414", CountryInfo.Romania.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Romania, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_SanMarino_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+3780549882555");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_SanMarino_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0549882555", CountryInfo.SanMarino.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Serbia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+381112026828");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Serbia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0112026828", CountryInfo.Serbia.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Serbia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Singapore_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+6563773800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Singapore_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("63773800", CountryInfo.Singapore.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Slovakia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+421257881101");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Slovakia_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0257881101", CountryInfo.Slovakia.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Slovakia, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_SouthAfrica_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+27215616800");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_SouthAfrica_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0215616800", CountryInfo.SouthAfrica.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.SouthAfrica, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Spain_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+34912582852");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Spain_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("912582852", CountryInfo.Spain.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Sweden_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+4686785500");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Sweden_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("086785500", CountryInfo.Sweden.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Sweden, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_Switzerland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+41584605511");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_Switzerland_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0584605511", CountryInfo.Switzerland.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Ukraine_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+380442819196");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Ukraine_CountryCode_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("0442819196", CountryInfo.Ukraine.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.Ukraine, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_For_UnitedKingdom_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("+442079813000");
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }

    [Fact]
    public void Parse_Value_CountryCode_For_UnitedKingdom_CallingCode()
    {
        var phoneNumber = PhoneNumber.Parse("02079813000", CountryInfo.UnitedKingdom.Iso3166Code);
        Assert.NotNull(phoneNumber);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
    }
}
