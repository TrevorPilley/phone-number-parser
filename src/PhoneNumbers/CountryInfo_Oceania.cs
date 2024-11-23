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
        Iso3166Code = "AS",
        Name = "American Samoa",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
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
        Iso3166Code = "AU",
        IsOecdMember = true,
        Name = "Australia",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([5, 6, 7, 8, 9, 10]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guam.
    /// </summary>
    public static CountryInfo Guam { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = Oceania,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "GU",
        Name = "Guam",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Papua New Guinea.
    /// </summary>
    public static CountryInfo PapuaNewGuinea { get; } = new()
    {
        CallingCode = "675",
        Continent = Oceania,
        Iso3166Code = "PG",
        Name = "Papua New Guinea",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8]),
    };
}
