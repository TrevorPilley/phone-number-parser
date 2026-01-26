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
    [InlineData("GB", "+447106865391", "07106865391")]     // UK number from UK
    [InlineData("GB", "+441481717000", "01481717000")]     // Guernsey number from UK (countries share calling code)
    [InlineData("GB", "+33140477283", "0033140477283")]    // France number from UK
    [InlineData("US", "+33140477283", "01133140477283")]   // France number from US
    [InlineData("GB", "+12124841200", "0012124841200")]    // US number from UK
    [InlineData("US", "+447106865391", "011447106865391")] // UK number from US
    [InlineData("KE", "+255222199760", "007222199760")]    // Tanzania from Kenya (uses 007 instead of +254)
    [InlineData("KE", "+256414348832", "006414348832")]    // Uganda from Kenya (uses 006 instead of +256)
    [InlineData("KE", "+447106865391", "000447106865391")] // United Kingdom from Kenya
    [InlineData("TZ", "+25420424200", "00520424200")]      // Kenya from Tanzania (uses 005 instead of +255)
    [InlineData("TZ", "+256414348832", "006414348832")]    // Uganda from Tanzania (uses 006 instead of +256)
    [InlineData("TZ", "+447106865391", "000447106865391")] // United Kingdom from Tanzania
    [InlineData("UG", "+25420424200", "00520424200")]      // Kenya from Uganda (uses 005 instead of +255)
    [InlineData("UG", "+255222199760", "007222199760")]    // Tanzania from Uganda (uses 006 instead of +256)
    [InlineData("UG", "+447106865391", "000447106865391")] // United Kingdom from Uganda
    [InlineData("IT", "+3780549882555", "0549882555")]     // San Marino NonGeo with Italy NDC from Italy
    [InlineData("IT", "+378882555", "0549882555")]         // San Marino NonGeo with Italy NDC from Italy
    [InlineData("IT", "+378693247", "00378693247")]        // San Marino Mobile from Italy
    [InlineData("IT", "+378598765", "00378598765")]        // San Marino Mobile from Italy
    [InlineData("IT", "+34912582852", "0034912582852")]    // Spain number from Italy
    [InlineData("CA", "+12124841200", "2124841200")]       // US number from Canada
    [InlineData("IE", "+442894484957", "04894484957")]     // Northern Ireland number from Republic of Ireland (via 48 NDC)
    [InlineData("IE", "+447106865391", "00447106865391")]  // United Kingdom number from Republic of Ireland (international)
    [InlineData("IE", "+33140477283", "0033140477283")]    // France number from Republic of Ireland
    [InlineData("FR", "+590590909238", "0590909238")]      // Guadeloupe number from France
    [InlineData("FR", "+262262254127", "0262254127")]      // Réunion number from France
    [InlineData("FR", "+262269645400", "0269645400")]      // Mayotte from France
    [InlineData("FR", "+596596421995", "0596421995")]      // Martinique from France
    public void NumberToDialFrom_CountryInfo(string sourceCountryCode, string destination, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(destination).NumberToDialFrom(ParseOptions.Default.GetCountryInfo(sourceCountryCode)));

    [Fact]
    public void NumberToDialFrom_CountryInfo_Throws_If_CountryInfo_Null()
    {
        var phoneNumber = TestHelper.CreateMobilePhoneNumber(null, "1", "123");
        var exception = Assert.Throws<ArgumentNullException>(() => phoneNumber.NumberToDialFrom(default(CountryInfo)));
        Assert.Equal("countryInfo", exception.ParamName);
    }

    [Fact]
    public void NumberToDialFrom_CountryInfo_Throws_If_PhoneNumber_Null()
    {
        var exception = Assert.Throws<ArgumentNullException>(() => default(PhoneNumber).NumberToDialFrom(CountryInfo.UnitedKingdom));
        Assert.Equal("destination", exception.ParamName);
    }

    [Theory]
    [InlineData("+441142726444", "+441146548866", "6548866")]        // UK Geo to Geo within NDC, local dialling permitted, NDC not required
    [InlineData("+441202454877", "+441202653887", "01202653887")]    // UK Geo to Geo within NDC, local dialling permitted, NDC required for local dialling due to number shortages
    [InlineData("+441142726444", "+441773878912", "01773878912")]    // UK Geo to Geo different NDC
    [InlineData("+441142726444", "+443038709123", "03038709123")]    // UK Geo to NonGeo
    [InlineData("+441142726444", "+447106865391", "07106865391")]    // UK Geo to Mobile
    [InlineData("+441142726444", "+441481717000", "01481717000")]    // UK Geo to Guernsey Geo, countries share calling code
    [InlineData("+447106865391", "+441142726444", "01142726444")]    // UK Mobile to Geo
    [InlineData("+447106865391", "+447712674523", "07712674523")]    // UK Mobile to Mobile
    [InlineData("+447106865391", "+443038709123", "03038709123")]    // UK Mobile to NonGeo
    [InlineData("+447106865391", "+33140477283", "0033140477283")]   // UK Mobile to France Geo
    [InlineData("+447106865391", "+33601876543", "0033601876543")]   // UK Mobile to France Mobile
    [InlineData("+12124841200", "+447712674523", "011447712674523")] // US to UK Mobile
    [InlineData("+85229615432", "+85229616333", "29616333")]         // HK to HK
    [InlineData("+25420424200", "+255222199760", "007222199760")]    // Kenya to Tanzania (uses 007 instead of +255)
    [InlineData("+25420424200", "+256414348832", "006414348832")]    // Kenya to Uganda (uses 006 instead of +256)
    [InlineData("+255222199760", "+25420424200", "00520424200")]     // Tanzania to Kenya (uses 005 instead of +254)
    [InlineData("+255222199760", "+256414348832", "006414348832")]   // Tanzania to Uganda (uses 006 instead of +256)
    [InlineData("+256414348832", "+25420424200", "00520424200")]     // Uganda to Kenya (uses 005 instead of +254)
    [InlineData("+256414348832", "+255222199760", "007222199760")]   // Uganda to Tanzania (uses 007 instead of +255)
    [InlineData("+393492525255", "+3780549882555", "0549882555")]    // Italy to San Marino NonGeo with Italy NDC
    [InlineData("+393492525255", "+378882555", "0549882555")]        // Italy to San Marino NonGeo without Italy NDC
    [InlineData("+393492525255", "+378693247", "00378693247")]       // Italy to San Marino Mobile
    [InlineData("+393492525255", "+378598765", "00378598765")]       // Italy to San Marino IP
    [InlineData("+393492525255", "+34912582852", "0034912582852")]   // Italy to Spain
    [InlineData("+12497121234", "+12494185634", "2494185634")]       // Canada within NDC, local dialling permitted, NDC required
    [InlineData("+18797121234", "+18794185634", "4185634")]          // Canada within NDC, local dialling permitted, NDC not required
    [InlineData("+19517121234", "+19514185634", "9514185634")]       // US within NDC, local dialling permitted, NDC required
    [InlineData("+15597121234", "+15594185634", "4185634")]          // US within NDC, local dialling permitted, NDC not required
    [InlineData("+18093725555", "+18093721909", "8093721909")]       // Dominican Republic, NANP but local dialling not permitted
    [InlineData("+35318049600", "+442894484957", "04894484957")]     // Republic of Ireland number to Northern Ireland (via 48 NDC)
    [InlineData("+35318049600", "+447106865391", "00447106865391")]  // Republic of Ireland number to United Kingdom number (international)
    [InlineData("+35318049600", "+33140477283", "0033140477283")]    // Republic of Ireland number to France
    [InlineData("+33140477283", "+590590909238", "0590909238")]      // France to Guadeloupe
    [InlineData("+33140477283", "+262262254127", "0262254127")]      // France to Réunion
    [InlineData("+33140477283", "+262269645400", "0269645400")]      // France to Mayotte
    [InlineData("+33140477283", "+596596421995", "0596421995")]      // France to Martinique
    public void NumberToDialFrom_PhoneNumber(string source, string destination, string expected) =>
        Assert.Equal(
            expected,
            PhoneNumber.Parse(destination).NumberToDialFrom(PhoneNumber.Parse(source)));

    [Fact]
    public void NumberToDialFrom_PhoneNumber_Throws_If_CountryInfo_Null()
    {
        Assert.Throws<ArgumentNullException>(() => default(PhoneNumber).NumberToDialFrom(TestHelper.CreateMobilePhoneNumber(null, "1", "123")));
        Assert.Throws<ArgumentNullException>(() => TestHelper.CreateMobilePhoneNumber(null, "1", "123").NumberToDialFrom(default(PhoneNumber)));
    }
}
