using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Brazil.
    /// </summary>
    public static CountryInfo Brazil { get; } = new()
    {
        CallingCode = "+55",
        Continent = SouthAmerica,
        Iso3166Code = "BR",
        Name = "Brazil",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10, 11 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };
}
