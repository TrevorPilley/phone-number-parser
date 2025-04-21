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
    /// Gets the <see cref="CountryInfo"/> for Jordan.
    /// </summary>
    public static CountryInfo Jordan { get; } = new()
    {
        CallingCode = "962",
        Continent = Asia,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        #pragma warning restore format
        FullName = "Hashemite Kingdom of Jordan",
        IsArabLeagueMember = true,
        Iso3166Code = "JO",
        Name = "Jordan",
        NdcLengths = new ReadOnlyCollection<int>([1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9]),
        TrunkPrefix = "0",
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
    /// Gets the <see cref="CountryInfo"/> for Oman.
    /// </summary>
    public static CountryInfo Oman { get; } = new()
    {
        CallingCode = "968",
        Continent = Asia,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Sultanate of Oman",
        IsArabLeagueMember = true,
        Iso3166Code = "OM",
        Name = "Oman",
        NsnLengths = s_nsn_8_12,
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
        IsArabLeagueMember = true,
        Iso3166Code = "QA",
        Name = "Qatar",
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 10]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Saudi Arabia.
    /// </summary>
    public static CountryInfo SaudiArabia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "966",
        Continent = Asia,
        FullName = "Kingdom of Saudi Arabia",
        IsArabLeagueMember = true,
        Iso3166Code = "SA",
        Name = "Saudi Arabia",
        NdcLengths = s_ndc_4_3_2,
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 10, 11, 12]),
        TrunkPrefix = "0",
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
        IsArabLeagueMember = true,
        Iso3166Code = "AE",
        Name = "United Arab Emirates",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = new ReadOnlyCollection<int>([5, 6, 7, 8, 9, 10, 11, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Yemen.
    /// </summary>
    public static CountryInfo Yemen { get; } = new()
    {
        CallingCode = "967",
        Continent = Asia,
        FormatProvider = YEPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Yemen",
        IsArabLeagueMember = true,
        Iso3166Code = "YE",
        Name = "Yemen",
        NdcLengths = s_ndc_2_1,
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 9]),
        TrunkPrefix = "0",
    };
}
