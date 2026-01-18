using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for American Samoa.
    /// </summary>
    public static CountryInfo AmericanSamoa { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = Oceania,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        FullName = "American Samoa",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "AS",
        Name = "American Samoa",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Australia.
    /// </summary>
    public static CountryInfo Australia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "61",
        Continent = Oceania,
        FormatProvider = AUPhoneNumberFormatProvider.Instance,
        FullName = "Commonwealth of Australia",
        InternationalCallPrefix = "0011",
        Iso3166Code = "AU",
        IsOecdMember = true,
        Name = "Australia",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_5_6_7_8_9_10,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guam.
    /// </summary>
    public static CountryInfo Guam { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = Oceania,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        FullName = "Guam",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "GU",
        Name = "Guam",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Papua New Guinea.
    /// </summary>
    public static CountryInfo PapuaNewGuinea { get; } = new()
    {
        CallingCode = "675",
        Continent = Oceania,
        FullName = "Independent State of Papua New Guinea",
        Iso3166Code = "PG",
        Name = "Papua New Guinea",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_7_8,
    };
}
