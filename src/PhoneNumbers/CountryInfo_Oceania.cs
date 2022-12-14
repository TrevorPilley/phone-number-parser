using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
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
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// Gets the <see cref="CountryInfo"/> for Papua New Guinea.
    /// </summary>
    public static CountryInfo PapuaNewGuinea { get; } = new()
    {
        CallingCode = "+675",
        Continent = Oceania,
        Iso3166Code = "PG",
        Name = "Papua New Guinea",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8 }),
    };
}
