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
        public void Create_Throws_If_To_Blank() =>
            Assert.Throws<ArgumentException>(() => NumberRange.Create("0-"));

        [Theory]
        [InlineData("000-11")]
        [InlineData("100-11")]
        public void Create_Throws_If_To_Less_Than_From(string value) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberRange.Create(value));

        [Fact]
        public void Create_With_Range_Fixed_Size()
        {
            var numberRange = NumberRange.Create("000500-100500");
            Assert.Equal("000500", numberRange.From);
            Assert.Equal("100500", numberRange.To);
        }

        [Fact]
        public void Create_With_Range_Span()
        {
            var numberRange = NumberRange.Create("000500-10050080");
            Assert.Equal("000500", numberRange.From);
            Assert.Equal("10050080", numberRange.To);
        }

        [Fact]
        public void Create_With_Range_Span_Large_Numbers()
        {
            var numberRange = NumberRange.Create("7000000000000-7004999999999");
            Assert.Equal("7000000000000", numberRange.From);
            Assert.Equal("7004999999999", numberRange.To);
        }

        [Fact]
        public void Create_With_Single_Value()
        {
            var numberRange = NumberRange.Create("000500");
            Assert.Equal("000500", numberRange.From);
            Assert.Equal("000500", numberRange.To);
        }

        [Theory]
        [InlineData("500")]
        [InlineData("00000")]
        [InlineData("000000")]
        [InlineData("000499")]
        [InlineData("100501")]
        [InlineData("999999")]
        [InlineData("1000000")]
        public void Range_Fixed_Size_Contains_False(string value) =>
            Assert.False(NumberRange.Create("000500-100500").Contains(value));

        [Theory]
        [InlineData("000500")]
        [InlineData("000501")]
        [InlineData("100499")]
        [InlineData("100500")]
        public void Range_Fixed_Size_Contains_True(string value) =>
            Assert.True(NumberRange.Create("000500-100500").Contains(value));

        [Theory]
        [InlineData("000499")]
        [InlineData("000501")]
        public void Range_Single_Value_Contains_False(string value) =>
            Assert.False(NumberRange.Create("000500").Contains(value));

        [Fact]
        public void Range_Single_Value_Contains_True() =>
            Assert.True(NumberRange.Create("000500").Contains("000500"));

        [Theory]
        [InlineData("500")]
        [InlineData("00000")]
        [InlineData("000000")]
        [InlineData("000499")]
        [InlineData("10050081")]
        [InlineData("99999999")]
        [InlineData("100000000")]
        public void Range_Span_Contains_False(string value) =>
            Assert.False(NumberRange.Create("000500-10050080").Contains(value));

        [Theory]
        [InlineData("000500")]
        [InlineData("000501")]
        [InlineData("10050079")]
        [InlineData("10050080")]
        public void Range_Span_Contains_True(string value) =>
            Assert.True(NumberRange.Create("000500-10050080").Contains(value));
    }
}
