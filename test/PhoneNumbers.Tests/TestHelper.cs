using System;
using System.Collections.ObjectModel;

namespace PhoneNumbers.Tests
{
    internal static class TestHelper
    {
        /// <summary>
        /// Creates a <see cref="CountryInfo"/> with the specified values,
        /// the calling code will always be +422 and the ISO 3116 code will always be ZZ (which are unused).
        /// </summary>
        internal static CountryInfo CreateCountryInfo(
            string trunkPrefix = default,
            int[] areaCodeLengths = default,
            int[] nsnLengths = default,
            bool requireNdcForLocalDialling = false) =>
            new()
            {
                CallingCode = "+422", // +422 isn't a used calling code.
                Iso3166Code = "ZZ", // ZZ isn't a used ISO 3166 code.
                Name = "Zulu",
                NdcLengths = new ReadOnlyCollection<int>(areaCodeLengths ?? Array.Empty<int>()),
                NsnLengths = new ReadOnlyCollection<int>(nsnLengths ?? Array.Empty<int>()),
                RequireNdcForLocalDialling = requireNdcForLocalDialling,
                TrunkPrefix = trunkPrefix,
            };

        internal static PhoneNumber CreateNonGeographicPhoneNumber(
            string trunkPrefix,
            string ndc,
            string sn,
            bool requireNdcForLocalDialling = false) =>
            new NonGeographicPhoneNumber(
                CreateCountryInfo(trunkPrefix: trunkPrefix, requireNdcForLocalDialling: requireNdcForLocalDialling),
                PhoneNumberHint.None,
                $"{ndc}{sn}",
                ndc,
                sn);
    }
}
