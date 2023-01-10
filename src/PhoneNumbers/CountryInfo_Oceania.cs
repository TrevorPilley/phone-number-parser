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
}
