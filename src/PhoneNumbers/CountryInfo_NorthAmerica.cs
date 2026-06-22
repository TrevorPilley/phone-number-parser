using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    internal const string NanpCallingCode = "1";
    internal const string NanpInternationalCallPrefix = "011";

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
        Iso3166Alpha2Code = "AI",
        Iso3166Alpha3Code = "AIA",
        Name = "Anguilla",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "AG",
        Iso3166Alpha3Code = "ATG",
        Name = "Antigua and Barbuda",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "BS",
        Iso3166Alpha3Code = "BHS",
        Name = "Bahamas",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "BB",
        Iso3166Alpha3Code = "BRB",
        Name = "Barbados",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "BM",
        Iso3166Alpha3Code = "BMU",
        Name = "Bermuda",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "VG",
        Iso3166Alpha3Code = "VGB",
        Name = "British Virgin Islands",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "CA",
        Iso3166Alpha3Code = "CAN",
        IsOecdMember = true,
        Name = "Canada",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "KY",
        Iso3166Alpha3Code = "CYM",
        Name = "Cayman Islands",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "DM",
        Iso3166Alpha3Code = "DMA",
        Name = "Dominica",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "DO",
        Iso3166Alpha3Code = "DOM",
        Name = "Dominican Republic",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Greenland.
    /// </summary>
    public static CountryInfo Greenland { get; } = new()
    {
        CallingCode = "299",
        Continent = NorthAmerica,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Greenland",
        Iso3166Alpha2Code = "GL",
        Iso3166Alpha3Code = "GRL",
        Name = "Greenland",
        NsnLengths = s_nsn_6,
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
        Iso3166Alpha2Code = "GD",
        Iso3166Alpha3Code = "GRD",
        Name = "Grenada",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guadeloupe.
    /// </summary>
    public static CountryInfo Guadeloupe { get; } = new()
    {
        CallingCode = "590",
        Continent = NorthAmerica,
        FormatProvider = FodPhoneNumberFormatProvider.Instance,
        FullName = "Guadeloupe",
        IsEuropeanUnionMember = true, // as a result of being part of France
        Iso3166Alpha2Code = "GP",
        Iso3166Alpha3Code = "GLP",
        Name = "Guadeloupe",
        NsnLengths = s_nsn_9_12,
        TrunkPrefix = "0",
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
        Iso3166Alpha2Code = "JM",
        Iso3166Alpha3Code = "JAM",
        Name = "Jamaica",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Martinique.
    /// </summary>
    public static CountryInfo Martinique { get; } = new()
    {
        CallingCode = "596",
        Continent = NorthAmerica,
        FormatProvider = FodPhoneNumberFormatProvider.Instance,
        FullName = "Martinique",
        IsEuropeanUnionMember = true, // as a result of being part of France
        Iso3166Alpha2Code = "MQ",
        Iso3166Alpha3Code = "MTQ",
        Name = "Martinique",
        NsnLengths = s_nsn_9_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Mexico.
    /// </summary>
    public static CountryInfo Mexico { get; } = new()
    {
        CallingCode = "52",
        Continent = NorthAmerica,
        FormatProvider = MXPhoneNumberFormatProvider.Instance,
        FullName = "United Mexican States",
        Iso3166Alpha2Code = "MX",
        Iso3166Alpha3Code = "MEX",
        IsOecdMember = true,
        Name = "Mexico",
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "MS",
        Iso3166Alpha3Code = "MSR",
        Name = "Montserrat",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Northern Mariana Islands.
    /// </summary>
    public static CountryInfo NorthernMarianaIsland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = NanpCallingCode,
        Continent = NorthAmerica,
        FormatProvider = NanpPhoneNumberFormatProvider.Instance,
        FullName = "Commonwealth of the Northern Mariana Islands",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Alpha2Code = "MP",
        Iso3166Alpha3Code = "MNP",
        Name = "Northern Mariana Islands",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "PR",
        Iso3166Alpha3Code = "PRI",
        Name = "Puerto Rico",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        FullName = "Federation of Saint Kitts and Nevis",
        InternationalCallPrefix = NanpInternationalCallPrefix,
        Iso3166Alpha2Code = "KN",
        Iso3166Alpha3Code = "KNA",
        Name = "Saint Kitts and Nevis",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "LC",
        Iso3166Alpha3Code = "LCA",
        Name = "Saint Lucia",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "VC",
        Iso3166Alpha3Code = "VCT",
        Name = "Saint Vincent and the Grenadines",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "SX",
        Iso3166Alpha3Code = "SXM",
        Name = "Sint Maarten",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "TT",
        Iso3166Alpha3Code = "TTO",
        Name = "Trinidad and Tobago",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "TC",
        Iso3166Alpha3Code = "TCA",
        Name = "Turks and Caicos Islands",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "US",
        Iso3166Alpha3Code = "USA",
        IsOecdMember = true,
        Name = "United States",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
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
        Iso3166Alpha2Code = "VI",
        Iso3166Alpha3Code = "VIR",
        Name = "United States Virgin Islands",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
    };
}
