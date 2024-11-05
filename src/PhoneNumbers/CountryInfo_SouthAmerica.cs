using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Brazil.
    /// </summary>
    public static CountryInfo Brazil { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "55",
        Continent = SouthAmerica,
        FormatProvider = BRPhoneNumberFormatProvider.Instance,
        InternationalCallPrefix = "0xx",
        Iso3166Code = "BR",
        Name = "Brazil",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([10, 11]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Colombia.
    /// </summary>
    public static CountryInfo Colombia { get; } = new()
    {
        CallingCode = "57",
        Continent = SouthAmerica,
        FormatProvider = COPhoneNumberFormatProvider.Instance,
        Iso3166Code = "CO",
        IsOecdMember = true,
        Name = "Colombia",
        NdcLengths = new ReadOnlyCollection<int>([3]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
    };
}
