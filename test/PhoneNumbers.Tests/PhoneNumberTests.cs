using PhoneNumbers.Formatters;

namespace PhoneNumbers.Tests;

public class PhoneNumberTests
{
    [Theory]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void Parse_Value(string input) =>
        Assert.NotNull(PhoneNumber.Parse(input));

    [Theory]
    [InlineData("0114 272 6444")]
    [InlineData("0114-272-6444")]
    [InlineData("0114.272.6444")]
    [InlineData("(0114) 272 6444")]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void Parse_Value_CountryCode(string input) =>
        Assert.NotNull(PhoneNumber.Parse(input, "GB"));

    [Fact]
    public void Parse_Value_CountryCode_Throws_If_CountryCode_Not_Supported()
    {
        var exception = Assert.Throws<ParseException>(() => PhoneNumber.Parse("0123456789", "ZZ"));
        Assert.Equal("The country code ZZ is not currently supported, or is not enabled in the ParseOptions.", exception.Message);
    }

    [Fact]
    public void Parse_Value_CountryCode_Throws_If_ParseOptions_Null() =>
        Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", "GB", default));

    [Fact]
    public void Parse_Value_CountryCode_Throws_If_Value_In_Incorrect_International_Format_For_CountryCode()
    {
        var exception = Assert.Throws<ParseException>(() => PhoneNumber.Parse("+441142726444", "FR"));
        Assert.Equal("The value must be a France phone number starting +33 or 0 and the national significant number of the phone number must be 9 or 13 digits in length.", exception.Message);
    }

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void Parse_Value_CountryCode_Throws_If_Value_Invalid(string input) =>
        Assert.Throws<ParseException>(() => PhoneNumber.Parse(input, "GB"));

    [Theory]
    [InlineData("0114 272 6444")]
    [InlineData("0114-272-6444")]
    [InlineData("0114.272.6444")]
    [InlineData("(0114) 272 6444")]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void Parse_Value_CountryInfo(string input) =>
        Assert.NotNull(PhoneNumber.Parse(input, CountryInfo.UnitedKingdom));

    [Fact]
    public void Parse_Value_CountryInfo_Throws_If_CountryInfo_Not_Supported()
    {
        var exception = Assert.Throws<ParseException>(() => PhoneNumber.Parse("0123456789", TestHelper.CreateCountryInfo()));
        Assert.Equal("The country Zulu is not enabled in ParseOptions.", exception.Message);
    }

    [Fact]
    public void Parse_Value_CountryInfo_Throws_If_CountryInfo_Null() =>
        Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", default(CountryInfo)));

    [Fact]
    public void Parse_Value_CountryInfo_Throws_If_ParseOptions_Null() =>
        Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", CountryInfo.UnitedKingdom, default));

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void Parse_Value_CountryInfo_Throws_If_Value_Invalid(string input) =>
        Assert.Throws<ParseException>(() => PhoneNumber.Parse(input, CountryInfo.UnitedKingdom));

    [Fact]
    public void Parse_Value_Throws_If_ParseOptions_Null() =>
        Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", default(ParseOptions)));

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void Parse_Value_Throws_If_Value_Invalid(string input) =>
        Assert.Throws<ParseException>(() => PhoneNumber.Parse(input));

    [Fact]
    public void ToString_Returns_Default_Formatted_PhoneNumber()
    {
        var phoneNumber = PhoneNumber.Parse("+441142726444");

        Assert.Equal(
            CountryInfo.GetFormatter(PhoneNumberFormatter.DefaultFormat).Format(phoneNumber),
            phoneNumber.ToString());
    }

    [Fact]
    public void TryParse_Invalid_Value()
    {
        Assert.False(PhoneNumber.TryParse("+441110000000", out PhoneNumber phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Theory]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void TryParse_Value(string input)
    {
        Assert.True(PhoneNumber.TryParse(input, out PhoneNumber phoneNumber));
        Assert.NotNull(phoneNumber);
    }

    [Theory]
    [InlineData("0114 272 6444")]
    [InlineData("0114-272-6444")]
    [InlineData("0114.272.6444")]
    [InlineData("(0114) 272 6444")]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void TryParse_Value_CountryCode(string input)
    {
        Assert.True(PhoneNumber.TryParse(input, "GB", out PhoneNumber phoneNumber));
        Assert.NotNull(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_CountryCode_False_If_CountryCode_Not_Supported()
    {
        Assert.False(PhoneNumber.TryParse("0123456789", "ZZ", out var phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_CountryCode_False_If_ParseOptions_Null()
    {
        Assert.False(PhoneNumber.TryParse("0123456789", "GB", default, out var phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void TryParse_Value_CountryCode_False_If_Value_Invalid(string input)
    {
        Assert.False(PhoneNumber.TryParse(input, "GB", out PhoneNumber phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_CountryCode_Ignores_Spaces()
    {
        Assert.True(PhoneNumber.TryParse("0114 272 6444", "GB", out var phoneNumber));
        Assert.NotNull(phoneNumber);
    }

    [Theory]
    [InlineData("0114 272 6444")]
    [InlineData("0114-272-6444")]
    [InlineData("0114.272.6444")]
    [InlineData("(0114) 272 6444")]
    [InlineData("+441142726444")]
    [InlineData("+44 114 272 6444")]
    [InlineData("+44 (114) 272 6444")]
    [InlineData("tel:+44-114-272-6444")]
    [InlineData("tel:+44-114-272-6444,1234")]
    [InlineData("tel:+44-114-272-6444;1234")]
    [InlineData("tel:+44-114-272-6444;ext=1234")]
    public void TryParse_Value_CountryInfo(string input)
    {
        Assert.True(PhoneNumber.TryParse(input, CountryInfo.UnitedKingdom, out PhoneNumber phoneNumber));
        Assert.NotNull(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_CountryInfo_False_If_CountryInfo_Not_Supported()
    {
        Assert.False(PhoneNumber.TryParse("0123456789", TestHelper.CreateCountryInfo(), out var phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void TryParse_Value_CountryInfo_False_If_Value_Invalid(string input)
    {
        Assert.False(PhoneNumber.TryParse(input, CountryInfo.UnitedKingdom, out PhoneNumber phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Theory]
    [InlineData(default(string))]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("441142726444")]
    public void TryParse_Value_False_If_Value_Invalid(string input)
    {
        Assert.False(PhoneNumber.TryParse(input, out PhoneNumber phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_PhoneNumbers_False_If_ParseOptions_Null()
    {
        Assert.False(PhoneNumber.TryParse("0123456789", default, out IEnumerable<PhoneNumber> phoneNumbers));
        Assert.Empty(phoneNumbers);
    }

    [Fact]
    public void TryParse_Value_To_PhoneNumber_False_If_ParseOptions_Null()
    {
        Assert.False(PhoneNumber.TryParse("0123456789", default(ParseOptions), out PhoneNumber phoneNumber));
        Assert.Null(phoneNumber);
    }

    [Fact]
    public void TryParse_Value_PhoneNumbers_Value_With_CallingCode_UK()
    {
        Assert.True(PhoneNumber.TryParse("+442079813000", out IEnumerable<PhoneNumber> phoneNumbers));
        Assert.NotNull(phoneNumbers);
        Assert.Single(phoneNumbers);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumbers.Single().Country);
    }

    [Fact]
    public void TryParse_Value_PhoneNumbers_Value_With_CallingCode_US()
    {
        Assert.True(PhoneNumber.TryParse("+16054567890", out IEnumerable<PhoneNumber> phoneNumbers));
        Assert.NotNull(phoneNumbers);
        Assert.Single(phoneNumbers);
        Assert.Equal(CountryInfo.UnitedStates, phoneNumbers.Single().Country);
    }

    [Fact]
    public void TryParse_Value_PhoneNumbers_Value_Without_CallingCode()
    {
        Assert.True(PhoneNumber.TryParse("02079813000", out IEnumerable<PhoneNumber> phoneNumbers));
        Assert.NotNull(phoneNumbers);
        Assert.Equal(3, phoneNumbers.Count());

        var phoneNumberResults = phoneNumbers.ToList();

        Assert.Equal(CountryInfo.Finland, phoneNumberResults[0].Country);
        Assert.Equal(CountryInfo.Serbia, phoneNumberResults[1].Country);
        Assert.Equal(CountryInfo.UnitedKingdom, phoneNumberResults[2].Country);
    }
}
