using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests;

public class CountryInfoTests
{

    [Fact]
    public void Equality_Both_Null()
    {
        var countryInfo1 = default(CountryInfo);
        var countryInfo2 = default(CountryInfo);

        Assert.Equal(countryInfo1, countryInfo2);
        Assert.True(countryInfo1 == countryInfo2);
        Assert.True(countryInfo1 == (object)countryInfo2);
        Assert.False(countryInfo1 != countryInfo2);
        Assert.False(countryInfo1 != (object)countryInfo2);
    }

    [Fact]
    public void Equality_Same_Instance()
    {
        var countryInfo1 = TestHelper.CreateCountryInfo();
        var countryInfo2 = countryInfo1;

        Assert.Equal(countryInfo1, countryInfo2);
        Assert.True(countryInfo1.Equals(countryInfo2));
        Assert.True(countryInfo1.Equals((object)countryInfo2));
        Assert.True(countryInfo1 == countryInfo2);
        Assert.True(countryInfo1 == (object)countryInfo2);
        Assert.False(countryInfo1 != countryInfo2);
        Assert.False(countryInfo1 != (object)countryInfo2);
    }

    [Fact]
    public void Equality_Same_Iso3166Code()
    {
        var countryInfo1 = new CountryInfo
        {
            CallingCode = "-1",
            Continent = "Pangea",
            Iso3166Code = "YZ",
            Name = "Nowhere",
        };

        var countryInfo2 = new CountryInfo
        {
            CallingCode = "-1",
            Continent = "Pangea",
            Iso3166Code = "YZ",
            Name = "Nowhere",
        };

        Assert.Equal(countryInfo1, countryInfo2);
        Assert.True(countryInfo1.Equals(countryInfo2));
        Assert.True(countryInfo1.Equals((object)countryInfo2));
        Assert.True(countryInfo1 == countryInfo2);
        Assert.False(countryInfo1 != countryInfo2);
    }
    [Fact]
    public void GetFormatter_E123_Returns_E123PhoneNumberFormatter() =>
        Assert.IsType<E123PhoneNumberFormatter>(CountryInfo.GetFormatter("E.123"));

    [Fact]
    public void GetFormatter_E164_Returns_E164PhoneNumberFormatter() =>
        Assert.IsType<E164PhoneNumberFormatter>(CountryInfo.GetFormatter("E.164"));

    [Fact]
    public void GetFormatter_N_Returns_NationalPhoneNumberFormatter() =>
        Assert.IsType<NationalPhoneNumberFormatter>(CountryInfo.GetFormatter("N"));

    [Fact]
    public void GetFormatter_RFC3966_Returns_Rfc3966PhoneNumberFormatter() =>
        Assert.IsType<Rfc3966PhoneNumberFormatter>(CountryInfo.GetFormatter("RFC3966"));

    [Fact]
    public void GetFormatter_Throws_For_Invalid_Format() =>
        Assert.Throws<FormatException>(() => CountryInfo.GetFormatter("X"));

    [Fact]
    public void GetFormatter_U_Returns_NationalUnformattedPhoneNumberFormatter() =>
        Assert.IsType<NationalUnformattedPhoneNumberFormatter>(CountryInfo.GetFormatter("U"));

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("35312222222")]
    [InlineData("+35312222222")]
    [InlineData("+35342222222")] // NDC is actually the dummy calling code but since it isn't immediately after the + it doesn't match
    [InlineData("tel:+353-422-22222")] // NDC is actually the dummy calling code but since it isn't immediately after the + it doesn't match
    public void HasCallingCode_False(string value) =>
        Assert.False(TestHelper.CreateCountryInfo().HasCallingCode(value));

    [Theory]
    [InlineData("+422012345678")]
    [InlineData("+422(0)12345678")]
    [InlineData("+422 (0) 123 456 78")]
    [InlineData("+422 (0123) 456 78")]
    [InlineData("tel:+422-123-456-78")]
    public void HasCallingCode_True(string value) =>
        Assert.True(TestHelper.CreateCountryInfo().HasCallingCode(value));

    [Fact]
    public void HasNationalDestinationCodes_False() =>
        Assert.False(TestHelper.CreateCountryInfo(ndcLengths: null).HasNationalDestinationCodes);

    [Fact]
    public void HasNationalDestinationCodes_True() =>
        Assert.True(TestHelper.CreateCountryInfo(ndcLengths: new[] { 2 }).HasNationalDestinationCodes);

    [Fact]
    public void HasTrunkPrefix_False() =>
        Assert.False(TestHelper.CreateCountryInfo(trunkPrefix: null).HasTrunkPrefix);

    [Fact]
    public void HasTrunkPrefix_True() =>
        Assert.True(TestHelper.CreateCountryInfo(trunkPrefix: "0").HasTrunkPrefix);

    [Fact]
    public void Inequality()
    {
        var countryInfo1 = new CountryInfo
        {
            CallingCode = "-1",
            Continent = "Pangea",
            Iso3166Code = "YZ",
            Name = "Nowhere",
        };

        var countryInfo2 = default(CountryInfo);

        Assert.NotEqual(countryInfo1, countryInfo2);
        Assert.NotEqual(countryInfo2, countryInfo1);
        Assert.False(countryInfo1.Equals(countryInfo2));
        Assert.False(countryInfo1.Equals((object)countryInfo2));
        Assert.False(countryInfo1 == countryInfo2);
        Assert.False(countryInfo2 == countryInfo1);
        Assert.False(countryInfo1 == (object)countryInfo2);
        Assert.False(countryInfo2 == (object)countryInfo1);
        Assert.True(countryInfo1 != countryInfo2);
        Assert.True(countryInfo2 != countryInfo1);
        Assert.True(countryInfo1 != (object)countryInfo2);
        Assert.True(countryInfo2 != (object)countryInfo1);

        // change the ISO3166 code
        var countryInfo3 = new CountryInfo
        {
            CallingCode = "-1",
            Continent = "Pangea",
            Iso3166Code = "YY",
            Name = "Nowhere",
        };

        Assert.NotEqual(countryInfo1, countryInfo3);
        Assert.False(countryInfo1.Equals(countryInfo3));
        Assert.False(countryInfo1 == countryInfo3);
        Assert.True(countryInfo1 != countryInfo3);
    }

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(@"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*()_+-={}[]:;""\\'|?/>.<,±`~ėęēêèéëūùûüúìįíîïīõøōœòôöóāãåæâàáäšßśłżžźčçćŵñń'¡¿…")]
    public void ReadNationalSignificantNumber_Not_A_Valid_Value(string value) =>
        Assert.Equal(string.Empty, TestHelper.CreateCountryInfo().ReadNationalSignificantNumber(value));

    [Fact]
    public void ReadNationalSignificantNumber_With_Number_Exceeding_Array_Size_Returns_Truncated_String() =>
        Assert.Equal("1234567891011121", TestHelper.CreateCountryInfo(trunkPrefix: null).ReadNationalSignificantNumber("+4221234567891011121314151617181920"));

    [Theory]
    [InlineData("+42212345678")]        // E.164 format
    [InlineData("+422 123 45678")]      // E.123 format
    [InlineData("+422 (123) 45678")]    // Microsoft canonical address format (E.123 with parenthesis around area code)
    [InlineData("(0123) 45678")]        // N format (open dialling)
    [InlineData("012345678")]           // N format (closed dialling)
    [InlineData("0123 45678-10")]       // DIN 5008 (Germany) with extension number
    [InlineData("0123/45678-10")]       // Very old German number format
    [InlineData("+422012345678")]       // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422(0)12345678")]     // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422 (0) 123 456 78")]
    [InlineData("+422 (0) 123-456-78")]
    [InlineData("+422 (0) 123.456.78")]
    [InlineData("tel:+422-123-456-78,18")]
    [InlineData("tel:+422-123-456-78;18")]
    [InlineData("tel:+422-123-456-78;ext=18")]
    [InlineData("(0) 123 456 78")]
    [InlineData("(0) 123-456-78")]
    [InlineData("(0) 123.456.78")]
    [InlineData("(0) 123/456/78")]
    [InlineData("A sentence containing a valid international formatted number +42212345678 within it.")]
    [InlineData("A sentence containing a valid national formatted number (0123) 45678 within it.")]
    public void ReadNationalSignificantNumber_With_TrunkPrefix(string value) =>
        Assert.Equal(
            "12345678",
            TestHelper
                .CreateCountryInfo(trunkPrefix: "0", nsnLengths: new[] { 8 })
                .ReadNationalSignificantNumber(value));

    [Theory]
    [InlineData("+42216680666")]        // E.164 format
    [InlineData("+422 166 80666")]      // E.123 format
    [InlineData("+422 (166) 80666")]    // Microsoft canonical address format (E.123 with parenthesis around area code)
    [InlineData("(06166) 80666")]       // N format (open dialling)
    [InlineData("0616680666")]          // N format (closed dialling)
    [InlineData("06166 80666-10")]      // DIN 5008 (Germany) with extension number
    [InlineData("06166/80666-10")]      // Very old German number format
    [InlineData("+4220616680666")]      // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422(06)16680666")]    // E.164 format plus trunk prefix (not a correct format)
    [InlineData("+422 (06) 166 80666")]
    [InlineData("+422 (06) 166-80666")]
    [InlineData("+422 (06) 166.80666")]
    [InlineData("tel:+422-166-80666,18")]
    [InlineData("tel:+422-166-80666;18")]
    [InlineData("tel:+422-166-80666;ext=18")]
    [InlineData("(06)16680666")]
    [InlineData("(06) 166 80666")]
    [InlineData("(06) 166-80666")]
    [InlineData("(06) 166.80666")]
    [InlineData("(06) 166/80666")]
    [InlineData("A sentence containing a valid international formatted number +42216680666 within it.")]
    [InlineData("A sentence containing a valid national formatted number (06166) 80666 within it.")]
    public void ReadNationalSignificantNumber_With_TrunkPrefix_MultiDigit(string value) =>
        Assert.Equal(
            "16680666",
            TestHelper
                .CreateCountryInfo(trunkPrefix: "06", nsnLengths: new[] { 8 })
                .ReadNationalSignificantNumber(value));

    [Theory]
    [InlineData("+42212345678")]        // E.164 format
    [InlineData("+422 123 45678")]      // E.123 format
    [InlineData("+422 (123) 45678")]    // Microsoft canonical address format (E.123 with parenthesis around area code)
    [InlineData("123 45678")]           // N format (open dialling)
    [InlineData("12345678")]            // N format (closed dialling)
    [InlineData("123 45678-10")]        // DIN 5008 (Germany) with extension number
    [InlineData("123/45678-10")]        // Very old German number format
    [InlineData("+422 123 456 78")]
    [InlineData("+422 123-456-78")]
    [InlineData("+422 123.456.78")]
    [InlineData("tel:+422-123-456-78,18")]
    [InlineData("tel:+422-123-456-78;18")]
    [InlineData("tel:+422-123-456-78;ext=18")]
    [InlineData("123 456 78")]
    [InlineData("123-456-78")]
    [InlineData("123.456.78")]
    [InlineData("123/456/78")]
    [InlineData("A sentence containing a valid international formatted number +42212345678 within it.")]
    [InlineData("A sentence containing a valid national formatted number 123 45678 within it.")]
    public void ReadNationalSignificantNumber_Without_TrunkPrefix(string value) =>
        Assert.Equal(
            "12345678",
            TestHelper
                .CreateCountryInfo(trunkPrefix: null, nsnLengths: new[] { 8 })
                .ReadNationalSignificantNumber(value));

    [Fact]
    public void ShareCallingCodeWith()
    {
        Assert.False(CountryInfo.Canada.SharesCallingCodeWith(CountryInfo.France));

        Assert.True(CountryInfo.Canada.SharesCallingCodeWith(CountryInfo.UnitedStates));
        Assert.True(CountryInfo.Guernsey.SharesCallingCodeWith(CountryInfo.IsleOfMan));
        Assert.True(CountryInfo.Guernsey.SharesCallingCodeWith(CountryInfo.Jersey));
        Assert.True(CountryInfo.Guernsey.SharesCallingCodeWith(CountryInfo.UnitedKingdom));
        Assert.True(CountryInfo.UnitedKingdom.SharesCallingCodeWith(CountryInfo.Guernsey));
        Assert.True(CountryInfo.UnitedKingdom.SharesCallingCodeWith(CountryInfo.IsleOfMan));
        Assert.True(CountryInfo.UnitedKingdom.SharesCallingCodeWith(CountryInfo.Jersey));
    }

    [Fact]
    public void When_Constructed()
    {
        var countryInfo = (CountryInfo)Activator.CreateInstance(typeof(CountryInfo), true);

        Assert.False(countryInfo.AllowsLocalGeographicDialling);
        Assert.Null(countryInfo.CallingCode);
        Assert.Null(countryInfo.Continent);
        Assert.False(countryInfo.HasNationalDestinationCodes);
        Assert.False(countryInfo.HasTrunkPrefix);
        Assert.Null(countryInfo.Iso3166Code);
        Assert.Null(countryInfo.Name);
        Assert.Empty(countryInfo.NdcLengths);
        Assert.Empty(countryInfo.NsnLengths);
        Assert.False(countryInfo.SharesCallingCode);
        Assert.Null(countryInfo.TrunkPrefix);
    }
}
