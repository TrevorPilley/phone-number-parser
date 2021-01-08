using System.Collections.ObjectModel;

namespace PhoneNumbers.Tests
{
    internal static class TestHelper
    {
        internal static CountryInfo CreateCountryInfo(int[] areaCodeLengths, int[] nsnLengths) =>
            new()
            {
                AreaCodeLengths = new ReadOnlyCollection<int>(areaCodeLengths),
                CallingCode = "+422", // +422 isn't a used calling code.
                Iso3166Code = "ZZ", // ZZ isn't a used ISO 3116 code.
                NsnLengths = new ReadOnlyCollection<int>(nsnLengths),
            };
    }
}
