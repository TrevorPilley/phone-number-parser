using System;
using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests.Parsers
{
    public class NumberRangeTests
    {
        [Fact]
        public void Create_Returns_Same_Instance() =>
            Assert.Same(NumberRange.Create("000500-100500"), NumberRange.Create("000500-100500"));

        [Fact]
        public void Create_Throws_If_From_Blank() =>
            Assert.Throws<ArgumentException>(() => NumberRange.Create("-0"));

        [Fact]
        public void Create_Throws_If_From_And_To_Different_Lengths() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberRange.Create("0-11"));

        [Fact]
        public void Create_Throws_If_To_Blank() =>
            Assert.Throws<ArgumentException>(() => NumberRange.Create("0-"));

        [Fact]
        public void Create_With_Range()
        {
            var numberRange = NumberRange.Create("000500-100500");
            Assert.Equal("000500", numberRange.From);
            Assert.Equal("100500", numberRange.To);
        }

        [Fact]
        public void Create_With_Single_Value()
        {
            var numberRange = NumberRange.Create("000500");
            Assert.Equal("000500", numberRange.From);
            Assert.Equal("000500", numberRange.To);
        }

        [Theory]
        [InlineData("00000")]
        [InlineData("000000")]
        [InlineData("000499")]
        [InlineData("100501")]
        [InlineData("999999")]
        [InlineData("1000000")]
        public void Range_Contains_False(string value) =>
            Assert.False(NumberRange.Create("000500-100500").Contains(value));

        [Theory]
        [InlineData("000500")]
        [InlineData("000501")]
        [InlineData("100499")]
        [InlineData("100500")]
        public void Range_Contains_True(string value) =>
            Assert.True(NumberRange.Create("000500-100500").Contains(value));

        [Theory]
        [InlineData("000499")]
        [InlineData("000501")]
        public void Single_Value_Contains_False(string value) =>
            Assert.False(NumberRange.Create("000500").Contains(value));

        [Fact]
        public void Single_Value_Contains_True() =>
            Assert.True(NumberRange.Create("000500").Contains("000500"));
    }
}
