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
        public void Parse_Value_With_France_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+33730334455");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.France, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Guernsey_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441481717000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_HongKong_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+85251015522");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Ireland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+35340226969");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_IsleOfMan_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441624696300");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Italy_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+393492525255");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Jersey_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441534716800");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Macau_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+85328000000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Monaco_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+37798988800");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_SanMarino_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+37866661212");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Singapore_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+6530000000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Spain_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+34810030000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Switzerland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+41327654321");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_UnitedKingdom_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+441142726444");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
        }

        [Fact]
        public void ToString_Returns_Default_Formatted_PhoneNumber()
        {
            var phoneNumber = PhoneNumber.Parse("+441142726444");

            Assert.Equal(
                phoneNumber.Country.Formatter.Format(phoneNumber, PhoneNumberFormatter.DefaultFormat),
                phoneNumber.ToString());
        }

        [Fact]
        public void TryParse_France_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+33730334455", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.France, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Guernsey_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+441481717000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Guernsey, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_HongKong_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+85251015522", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Ireland_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+35340226969", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Ireland, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_IsleOfMan_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+441624696300", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.IsleOfMan, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Italy_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+393492525255", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Italy, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Jersey_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+441534716800", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Jersey, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Macau_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+85328000000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Macau, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Monaco_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+37798988800", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Monaco, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_SanMarino_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+37866661212", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Singapore_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+6530000000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Spain_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+34810030000", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_Switzerland_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+41327654321", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
        }

        [Fact]
        public void TryParse_UnitedKingdom_CallingCode_Invalid_Value()
        {
            Assert.False(PhoneNumber.TryParse("+441110000000", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_UnitedKingdom_CallingCode_Valid_Value()
        {
            Assert.True(PhoneNumber.TryParse("+441142726444", out var phoneNumber));
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
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
