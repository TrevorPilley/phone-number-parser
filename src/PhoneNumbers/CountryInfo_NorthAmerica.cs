using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string NanpCallingCode = "+1";
    internal const string NanpInternationalCallPrefix = "011";
    internal static ReadOnlyCollection<int> NanpNdcLengths { get; } = new ReadOnlyCollection<int>(new[] { 3 });
    internal static ReadOnlyCollection<int> NanpNsnLengths { get; } = new ReadOnlyCollection<int>(new[] { 10 });

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Puerto Rico.
    /// </summary>
    public static CountryInfo PuertoRico { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "PR",
        Name = "Puerto Rico",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States.
    /// </summary>
    public static CountryInfo UnitedStates { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "US",
        Name = "United States",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States Virgin Islands.
    /// </summary>
    public static CountryInfo UnitedStatesVirginIslands { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
        SharesCallingCode = true,
    };
}
