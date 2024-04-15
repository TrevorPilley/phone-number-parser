using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Egypt.
    /// </summary>
    public static CountryInfo Egypt { get; } = new()
    {
        CallingCode = "20",
        Continent = Africa,
        Iso3166Code = "EG",
        Name = "Egypt",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 10, 11]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Kenya.
    /// </summary>
    public static CountryInfo Kenya { get; } = new()
    {
        CallingCode = "254",
        Continent = Africa,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        Iso3166Code = "KE",
        Name = "Kenya",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 9, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Nigeria.
    /// </summary>
    public static CountryInfo Nigeria { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "234",
        Continent = Africa,
        Iso3166Code = "NG",
        Name = "Nigeria",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 10]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for South Africa.
    /// </summary>
    public static CountryInfo SouthAfrica { get; } = new()
    {
        CallingCode = "27",
        Continent = Africa,
        Iso3166Code = "ZA",
        Name = "South Africa",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 13]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Tanzania.
    /// </summary>
    public static CountryInfo Tanzania { get; } = new()
    {
        CallingCode = "255",
        Continent = Africa,
        Iso3166Code = "TZ",
        Name = "Tanzania",
        NdcLengths = new ReadOnlyCollection<int>([5, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 12]),
        TrunkPrefix = "0",
    };
}
