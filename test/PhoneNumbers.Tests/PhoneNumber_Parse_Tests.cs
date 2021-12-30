using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumber_Parse_Tests
    {
        [Fact]
        public void Parse_Value_With_Austria_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+43171100");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Austria, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Belgium_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+3250444646");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Belgium, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Bulgaria_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+35929492760");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Bulgaria, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_France_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+33140477283");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.France, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Gibraltar_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+35020074636");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Gibraltar, phoneNumber.Country);
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
            var phoneNumber = PhoneNumber.Parse("+85229616333");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.HongKong, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Ireland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+35318049600");
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
        public void Parse_Value_With_Netherlands_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+31702140214");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Netherlands, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Portugal_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+351217211000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Portugal, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_SanMarino_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+3780549882555");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.SanMarino, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Singapore_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+6563773800");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Singapore, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Spain_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+34912582852");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Spain, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_Switzerland_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+41584605511");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.Switzerland, phoneNumber.Country);
        }

        [Fact]
        public void Parse_Value_With_UnitedKingdom_CallingCode()
        {
            var phoneNumber = PhoneNumber.Parse("+442079813000");
            Assert.NotNull(phoneNumber);
            Assert.Equal(CountryInfo.UnitedKingdom, phoneNumber.Country);
        }
    }
}
