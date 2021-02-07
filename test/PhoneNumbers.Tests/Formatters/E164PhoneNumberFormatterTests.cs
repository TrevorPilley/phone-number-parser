using System;
using PhoneNumbers.Formatters;
using Xunit;

namespace PhoneNumbers.Tests.Formatters
{
    /// <summary>
    /// Contains unit tests for the <see cref="E164PhoneNumberFormatter"/> class.
    /// </summary>
    public class E164PhoneNumberFormatterTests
    {
        [Fact]
        public void Instance()
        {
            Assert.NotNull(E164PhoneNumberFormatter.Instance);
            Assert.Same(E164PhoneNumberFormatter.Instance, E164PhoneNumberFormatter.Instance);
        }

        [Fact]
        public void CanFormat_Returns_False_For_Not_E164() =>
            Assert.False(E164PhoneNumberFormatter.Instance.CanFormat("E.123"));

        [Fact]
        public void CanFormat_Returns_False_For_Null() =>
            Assert.False(E164PhoneNumberFormatter.Instance.CanFormat(null));

        [Fact]
        public void CanFormat_Returns_True_For_E164() =>
            Assert.True(E164PhoneNumberFormatter.Instance.CanFormat("E.164"));

        [Fact]
        public void Format() =>
            Assert.Equal(
                "+42212345667788",
                E164PhoneNumberFormatter.Instance.Format(TestHelper.CreateNonGeographicPhoneNumber("0", "12345", "667788")));
    }
}
