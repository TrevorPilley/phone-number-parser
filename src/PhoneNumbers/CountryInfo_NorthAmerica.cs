using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string nanpCallingCode = "+1";
    internal const string nanpInternationalCallPrefix = "011";
    internal static readonly ReadOnlyCollection<int> s_nanpNdcLengths = new ReadOnlyCollection<int>(new[] { 3 });
    internal static readonly ReadOnlyCollection<int> s_nanpNsnLengths = new ReadOnlyCollection<int>(new[] { 10 });

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        CallingCode = nanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = nanpInternationalCallPrefix,
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Puerto Rico.
    /// </summary>
    public static CountryInfo PuertoRico { get; } = new()
    {
        CallingCode = nanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = nanpInternationalCallPrefix,
        Iso3166Code = "PR",
        Name = "Puerto Rico",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States.
    /// </summary>
    public static CountryInfo UnitedStates { get; } = new()
    {
        CallingCode = nanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = nanpInternationalCallPrefix,
        Iso3166Code = "US",
        Name = "United States",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States Virgin Islands.
    /// </summary>
    public static CountryInfo UnitedStatesVirginIslands { get; } = new()
    {
        CallingCode = nanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = nanpInternationalCallPrefix,
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };
}
