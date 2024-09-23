using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Hong Kong.
    /// </summary>
    public static CountryInfo HongKong { get; } = new()
    {
        CallingCode = "852",
        Continent = Asia,
        Iso3166Code = "HK",
        Name = "Hong Kong",
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 11, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Macau.
    /// </summary>
    public static CountryInfo Macau { get; } = new()
    {
        CallingCode = "853",
        Continent = Asia,
        Iso3166Code = "MO",
        Name = "Macau",
        NsnLengths = new ReadOnlyCollection<int>([8]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Singapore.
    /// </summary>
    public static CountryInfo Singapore { get; } = new()
    {
        CallingCode = "65",
        Continent = Asia,
        Iso3166Code = "SG",
        Name = "Singapore",
        NsnLengths = new ReadOnlyCollection<int>([8, 10, 11]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Turkey.
    /// </summary>
    public static CountryInfo Turkey { get; } = new()
    {
        CallingCode = "90",
        Continent = Asia,
        FormatProvider = TRPhoneNumberFormatProvider.Instance,
        Iso3166Code = "TR",
        Name = "Turkey",
        NdcLengths = new ReadOnlyCollection<int>([3, 0]),
        NsnLengths = new ReadOnlyCollection<int>([7, 10]),
        TrunkPrefix = "0",
    };
}
