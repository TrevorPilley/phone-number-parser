using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    private const string nanpCallingCode = "+1";
    private const string nanpInternationalCallPrefix = "011";
    private static readonly ReadOnlyCollection<int> s_nanpNdcLengths = new ReadOnlyCollection<int>(new[] { 3 });
    private static readonly ReadOnlyCollection<int> s_nanpNsnLengths = new ReadOnlyCollection<int>(new[] { 10 });

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for American Samoa.
    /// </summary>
    public static CountryInfo AmericanSamoa { get; } = new()
    {
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
        Iso3166Code = "AS",
        Name = "American Samoa",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guam.
    /// </summary>
    public static CountryInfo Guam { get; } = new()
    {
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
        Iso3166Code = "GU",
        Name = "Guam",
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
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
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
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
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
        CallingCode = "+1",
        Continent = NorthAmerica,
        InternationalCallPrefix = "011",
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
    };
}
