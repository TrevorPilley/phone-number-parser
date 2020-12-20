using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumberTests
    {
        [Fact]
        public void Parse_Ignores_Spaces() =>
            Assert.NotNull(PhoneNumber.Parse("0114 123 4567", "GB"));
    }
}
