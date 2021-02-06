using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Parse_Value_CountryCode_Ignores_Parenthesis() =>
            Assert.NotNull(PhoneNumber.Parse("(0114) 272 6444", "GB"));

        [Fact]
        public void Parse_Value_CountryCode_Ignores_Spaces() =>
            Assert.NotNull(PhoneNumber.Parse("0114 272 6444", "GB"));

        [Fact]
        public void Parse_Value_CountryCode_Throws_If_CountryCode_Not_Supported()
        {
            var exception = Assert.Throws<ParseException>(() => PhoneNumber.Parse("0123456789", "ZZ"));
            Assert.Equal("The country code ZZ is not currently supported.", exception.Message);
        }

        [Fact]
        public void Parse_Value_CountryCode_Throws_If_ParseOptions_Null() =>
            Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", "GB", default));

        [Fact]
        public void Parse_Value_Throws_If_ParseOptions_Null() =>
            Assert.Throws<ArgumentNullException>(() => PhoneNumber.Parse("0123456789", default(ParseOptions)));

        [Fact]
        public void Parse_Value_Throws_If_Value_Does_Not_Start_With_Plus() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse("441142726444"));

        [Fact]
        public void Parse_Value_Throws_If_Value_Empty() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse(" "));

        [Fact]
        public void Parse_Value_Throws_If_Value_Null() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse(null));

        [Fact]
        public void ToString_Returns_Default_Formatted_PhoneNumber()
        {
            var phoneNumber = PhoneNumber.Parse("+441142726444");

            Assert.Equal(
                phoneNumber.Country.Formatter.Format(phoneNumber, PhoneNumberFormatter.DefaultFormat),
                phoneNumber.ToString());
        }

        [Fact]
        public void TryParse_Invalid_Value()
        {
            Assert.False(PhoneNumber.TryParse("+441110000000", out var phoneNumber));
            Assert.Null(phoneNumber);
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

        [Fact]
        public void TryParse_Value_CountryCode_False_If_Value_Empty()
        {
            Assert.False(PhoneNumber.TryParse(" ", "GB", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_CountryCode_False_If_Value_Null()
        {
            Assert.False(PhoneNumber.TryParse(null, "GB", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_CountryCode_Ignores_Parenthesis()
        {
            Assert.True(PhoneNumber.TryParse("(0114) 272 6444", "GB", out var phoneNumber));
            Assert.NotNull(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_CountryCode_Ignores_Spaces()
        {
            Assert.True(PhoneNumber.TryParse("0114 272 6444", "GB", out var phoneNumber));
            Assert.NotNull(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_False_If_ParseOptions_Null()
        {
            Assert.False(PhoneNumber.TryParse("0123456789", default(ParseOptions), out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_False_If_Value_Does_Not_Start_With_Plus()
        {
            Assert.False(PhoneNumber.TryParse("441142726444", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_False_If_Value_Empty()
        {
            Assert.False(PhoneNumber.TryParse(" ", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Value_False_If_Value_Null()
        {
            Assert.False(PhoneNumber.TryParse(null, out var phoneNumber));
            Assert.Null(phoneNumber);
        }
    }
}
