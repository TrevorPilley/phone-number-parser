using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Parse_Ignores_Parenthesis() =>
            Assert.NotNull(PhoneNumber.Parse("(0114) 123 4567", "GB"));

        [Fact]
        public void Parse_Ignores_Spaces() =>
            Assert.NotNull(PhoneNumber.Parse("0114 123 4567", "GB"));

        [Fact]
        public void Parse_Throws_If_CountryCode_Not_Supported() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse("0123456789", "ZZ"));

        [Fact]
        public void Parse_Throws_If_Value_Does_Not_Start_With_Plus() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse("441141234567"));

        [Fact]
        public void Parse_Throws_If_Value_Empty() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse(" "));

        [Fact]
        public void Parse_Throws_If_Value_Null() =>
            Assert.Throws<ParseException>(() => PhoneNumber.Parse(null));

        [Fact]
        public void Parse_UK_CallingCode() =>
            Assert.NotNull(PhoneNumber.Parse("+441141234567"));

        [Fact]
        public void ToString_Returns_Default_Formatted_PhoneNumber()
        {
            var phoneNumber = PhoneNumber.Parse("+441141234567");

            Assert.Equal(
                phoneNumber.Country.Formatter.Format(phoneNumber, PhoneNumberFormatter.DefaultFormat),
                phoneNumber.ToString());
        }

        [Fact]
        public void TryParse_False_If_CountryCode_Not_Supported()
        {
            Assert.False(PhoneNumber.TryParse("0123456789", "ZZ", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_False_If_Value_Does_Not_Start_With_Plus()
        {
            Assert.False(PhoneNumber.TryParse("441141234567", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_False_If_Value_Empty()
        {
            Assert.False(PhoneNumber.TryParse(" ", out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_False_If_Value_Null()
        {
            Assert.False(PhoneNumber.TryParse(null, out var phoneNumber));
            Assert.Null(phoneNumber);
        }

        [Fact]
        public void TryParse_Ignores_Parenthesis()
        {
            Assert.True(PhoneNumber.TryParse("(0114) 123 4567", "GB", out var phoneNumber));
            Assert.NotNull(phoneNumber);
        }

        [Fact]
        public void TryParse_Ignores_Spaces()
        {
            Assert.True(PhoneNumber.TryParse("0114 123 4567", "GB", out var phoneNumber));
            Assert.NotNull(phoneNumber);
        }

        [Fact]
        public void TryParse_UK_CallingCode()
        {
            Assert.True(PhoneNumber.TryParse("+441141234567", out var phoneNumber));
            Assert.NotNull(phoneNumber);
        }
    }
}
