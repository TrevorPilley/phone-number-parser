using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for American Samoa.
    /// </summary>
    public static CountryInfo AmericanSamoa { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = Oceania,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "AS",
        Name = "American Samoa",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Australia.
    /// </summary>
    public static CountryInfo Australia { get; } = new()
    {
        CallingCode = "+61",
        Continent = Oceania,
        Iso3166Code = "AU",
        Name = "Australia",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 5, 6, 7, 8, 9, 10 }),
        NumberingPlanType = NumberingPlanType.Open,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guam.
    /// </summary>
    public static CountryInfo Guam { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = Oceania,
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "GU",
        Name = "Guam",
        NdcLengths = NanpNdcLengths,
        NsnLengths = NanpNsnLengths,
        NumberingPlanType = NumberingPlanType.Open,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Papua New Guinea.
    /// </summary>
    public static CountryInfo PapuaNewGuinea { get; } = new()
    {
        CallingCode = "+675",
        Continent = Oceania,
        Iso3166Code = "PG",
        Name = "Papua New Guinea",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8 }),
    };
}
