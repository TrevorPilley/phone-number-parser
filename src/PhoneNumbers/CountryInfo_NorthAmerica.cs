using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string NanpCallingCode = "1";
    private static readonly ReadOnlyCollection<int> s_nanpNdcLengths = new ReadOnlyCollection<int>(new[] { 3 });
    private static readonly ReadOnlyCollection<int> s_nanpNsnLengths = new ReadOnlyCollection<int>(new[] { 10 });

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        AllowLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Puerto Rico.
    /// </summary>
    public static CountryInfo PuertoRico { get; } = new()
    {
        AllowLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "PR",
        Name = "Puerto Rico",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States.
    /// </summary>
    public static CountryInfo UnitedStates { get; } = new()
    {
        AllowLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "US",
        Name = "United States",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States Virgin Islands.
    /// </summary>
    public static CountryInfo UnitedStatesVirginIslands { get; } = new()
    {
        AllowLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };
}
