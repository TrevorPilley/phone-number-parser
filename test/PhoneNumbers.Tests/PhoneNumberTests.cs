using System;
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
        public void Parse_Throws_If_Value_Does_Not_Start_With_Plus() =>
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse("441141234567"));

        [Fact]
        public void Parse_Throws_If_Value_Empty() =>
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(" "));

        [Fact]
        public void Parse_Throws_If_Value_Null() =>
            Assert.Throws<ArgumentException>(() => PhoneNumber.Parse(null));

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
    }
}
