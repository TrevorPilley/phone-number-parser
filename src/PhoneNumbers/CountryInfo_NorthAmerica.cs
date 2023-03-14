using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "1",
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
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "1",
    };
}
