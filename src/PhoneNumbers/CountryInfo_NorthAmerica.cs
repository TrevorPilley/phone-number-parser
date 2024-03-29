using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string NanpCallingCode = "1";
    private static readonly ReadOnlyCollection<int> s_nanpNdcLengths = new([3]);
    private static readonly ReadOnlyCollection<int> s_nanpNsnLengths = new([10]);

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Anguilla.
    /// </summary>
    public static CountryInfo Anguilla { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "AI",
        Name = "Anguilla",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Antigua and Barbuda.
    /// </summary>
    public static CountryInfo AntiguaAndBarbuda { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "AG",
        Name = "Antigua and Barbuda",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bahamas.
    /// </summary>
    public static CountryInfo Bahamas { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "BS",
        Name = "Bahamas",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Barbados.
    /// </summary>
    public static CountryInfo Barbados { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "BB",
        Name = "Barbados",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bermuda.
    /// </summary>
    public static CountryInfo Bermuda { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "BM",
        Name = "Bermuda",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for British Virgin Islands.
    /// </summary>
    public static CountryInfo BritishVirginIslands { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "VG",
        Name = "British Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Canada.
    /// </summary>
    public static CountryInfo Canada { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "CA",
        Name = "Canada",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Cayman Islands.
    /// </summary>
    public static CountryInfo CaymanIslands { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "KY",
        Name = "Cayman Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Dominica.
    /// </summary>
    public static CountryInfo Dominica { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "DM",
        Name = "Dominica",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Grenada.
    /// </summary>
    public static CountryInfo Grenada { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "GD",
        Name = "Grenada",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Jamaica.
    /// </summary>
    public static CountryInfo Jamaica { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "JM",
        Name = "Jamaica",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Montserrat.
    /// </summary>
    public static CountryInfo Montserrat { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "MS",
        Name = "Montserrat",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Northern Mariana Island.
    /// </summary>
    public static CountryInfo NorthernMarianaIsland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "MP",
        Name = "Northern Mariana Island",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Puerto Rico.
    /// </summary>
    public static CountryInfo PuertoRico { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "PR",
        Name = "Puerto Rico",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Saint Kitts and Nevis.
    /// </summary>
    public static CountryInfo SaintKittsAndNevis { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "KN",
        Name = "Saint Kitts and Nevis",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Saint Lucia.
    /// </summary>
    public static CountryInfo SaintLucia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "LC",
        Name = "Saint Lucia",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Saint Vincent and the Grenadines.
    /// </summary>
    public static CountryInfo SaintVincentAndTheGrenadines { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "VC",
        Name = "Saint Vincent and the Grenadines",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Sint Maarten.
    /// </summary>
    public static CountryInfo SintMaarten { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "SX",
        Name = "Sint Maarten",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Trinidad and Tobago.
    /// </summary>
    public static CountryInfo TrinidadAndTobago { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "TT",
        Name = "Trinidad and Tobago",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Turks and Caicos Islands.
    /// </summary>
    public static CountryInfo TurksAndCaicosIslands { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "TC",
        Name = "Turks and Caicos Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States.
    /// </summary>
    public static CountryInfo UnitedStates { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "US",
        Name = "United States",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United States Virgin Islands.
    /// </summary>
    public static CountryInfo UnitedStatesVirginIslands { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };
}
