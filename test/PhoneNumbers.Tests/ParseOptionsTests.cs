using PhoneNumbers.Parsers;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class ParseOptionsTests
    {
        [Fact]
        public void Default()
        {
            Assert.NotNull(ParseOptions.Default);

            Assert.Single(ParseOptions.Default.Parsers);
            Assert.Contains(ParseOptions.Default.Parsers, x => x.GetType() == typeof(UKPhoneNumberParser));
        }
    }
}
