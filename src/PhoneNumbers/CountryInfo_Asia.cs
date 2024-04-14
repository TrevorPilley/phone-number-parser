using System.Collections.ObjectModel;

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
        Name = "香港",
        NameEnglish = "Hong Kong",
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Macau.
    /// </summary>
    public static CountryInfo Macau { get; } = new()
    {
        CallingCode = "853",
        Continent = Asia,
        Iso3166Code = "MO",
        Name = "澳門",
        NameEnglish = "Macau",
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
        NameEnglish = "Singapore",
        NsnLengths = new ReadOnlyCollection<int>([8, 10, 11]),
    };
}
