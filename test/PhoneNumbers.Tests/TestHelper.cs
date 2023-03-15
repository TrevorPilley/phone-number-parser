using System.Collections.ObjectModel;

namespace PhoneNumbers.Tests;

internal static class TestHelper
{
    /// <summary>
    /// Creates a <see cref="CountryInfo"/> with the specified values,
    /// the calling code will always be +422 and the ISO 3116 code will always be ZZ (which are unused).
    /// </summary>
    internal static CountryInfo CreateCountryInfo(
        string trunkPrefix = default,
        int[] ndcLengths = default,
        int[] nsnLengths = default,
        bool requireNdcForLocalGeographicDialling = true) =>
        new()
        {
            CallingCode = "+422", // +422 isn't a used calling code.
            Iso3166Code = "ZZ", // ZZ isn't a used ISO 3166 code.
            Name = "Zulu",
            NdcLengths = new ReadOnlyCollection<int>(ndcLengths ?? Array.Empty<int>()),
            NsnLengths = new ReadOnlyCollection<int>(nsnLengths ?? Array.Empty<int>()),
            RequireNdcForLocalGeographicDialling = requireNdcForLocalGeographicDialling,
            TrunkPrefix = trunkPrefix,
        };

    internal static PhoneNumber CreateGeographicPhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool requireNdcForLocalGeographicDialling = true) =>
        new GeographicPhoneNumber(
            CreateCountryInfo(trunkPrefix: trunkPrefix, requireNdcForLocalGeographicDialling: requireNdcForLocalGeographicDialling),
            PhoneNumberHint.None,
            $"{ndc}{sn}",
            ndc,
            sn,
            "AreaName");

    internal static PhoneNumber CreateMobilePhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool requireNdcForLocalGeographicDialling = true) =>
        new MobilePhoneNumber(
            CreateCountryInfo(trunkPrefix: trunkPrefix, requireNdcForLocalGeographicDialling: requireNdcForLocalGeographicDialling),
            PhoneNumberHint.None,
            $"{ndc}{sn}",
            ndc,
            sn);

    internal static PhoneNumber CreateNonGeographicPhoneNumber(
        string trunkPrefix,
        string ndc,
        string sn,
        bool requireNdcForLocalGeographicDialling = true) =>
        new NonGeographicPhoneNumber(
            CreateCountryInfo(trunkPrefix: trunkPrefix, requireNdcForLocalGeographicDialling: requireNdcForLocalGeographicDialling),
            PhoneNumberHint.None,
            $"{ndc}{sn}",
            ndc,
            sn);
}
