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
        FullName = "Hong Kong",
        InternationalCallPrefix = "001",
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
        FullName = "Macau",
        Iso3166Code = "MO",
        Name = "Macau",
        NsnLengths = s_nsn_8,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Qatar.
    /// </summary>
    public static CountryInfo Qatar { get; } = new()
    {
        CallingCode = "974",
        Continent = Asia,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "State of Qatar",
        Iso3166Code = "QA",
        Name = "Qatar",
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 10]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Singapore.
    /// </summary>
    public static CountryInfo Singapore { get; } = new()
    {
        CallingCode = "65",
        Continent = Asia,
        FullName = "Republic of Singapore",
        InternationalCallPrefix = "000",
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
        FullName = "Republic of Türkiye",
        IsNatoMember = true,
        Iso3166Code = "TR",
        IsOecdMember = true,
        Name = "Turkey",
        NdcLengths = new ReadOnlyCollection<int>([3, 0]),
        NsnLengths = new ReadOnlyCollection<int>([7, 10]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for United Arab Emirates.
    /// </summary>
    public static CountryInfo UnitedArabEmirates { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "971",
        Continent = Asia,
        FullName = "United Arab Emirates",
        Iso3166Code = "AE",
        Name = "United Arab Emirates",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_5_6_7_8_9_10_11_12,
        TrunkPrefix = "0",
    };
}
