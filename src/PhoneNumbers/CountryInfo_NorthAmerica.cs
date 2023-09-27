using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string NanpCallingCode = "1";
    internal const string NanpInternationalCallPrefix = "011";
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
        FullName = "Anguilla",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Antigua and Barbuda",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Commonwealth of The Bahamas",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Barbados",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Bermuda",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Virgin Islands",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Canada",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        IsNatoMember = true,
        Iso3166Code = "CA",
        IsOecdMember = true,
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
        FullName = "Cayman Islands",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Commonwealth of Dominica",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "DM",
        Name = "Dominica",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Dominican Republic.
    /// </summary>
    public static CountryInfo DominicanRepublic { get; } = new()
    {
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        FullName = "Dominican Republic",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "DO",
        Name = "Dominican Republic",
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
        FullName = "Grenada",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        FullName = "Jamaica",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "JM",
        Name = "Jamaica",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Mexico.
    /// </summary>
    public static CountryInfo Mexico { get; } = new()
    {
        CallingCode = "52",
        Continent = NorthAmerica,
        FormatProvider = MXPhoneNumberFormatProvider.Instance,
        Iso3166Code = "MX",
        Name = "Mexico",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
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
        FullName = "Montserrat",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Commonwealth of the Northern Mariana Islands",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Commonwealth of Puerto Rico",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Federation of Saint Christopher and Nevis",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Saint Lucia",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Saint Vincent and the Grenadines",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Sint Maarten",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Republic of Trinidad and Tobago",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "Turks and Caicos Islands",
        InternationalCallPrefix = NanpInternationalCallPrefix,
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
        FullName = "United States of America",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        IsNatoMember = true,
        Iso3166Code = "US",
        IsOecdMember = true,
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
        FullName = "Virgin Islands of the United States",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Code = "VI",
        Name = "United States Virgin Islands",
        NdcLengths = s_nanpNdcLengths,
        NsnLengths = s_nanpNsnLengths,
        SharesCallingCode = true,
    };
}
