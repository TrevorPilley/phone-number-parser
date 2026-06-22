using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Åland Islands.
    /// </summary>
    public static CountryInfo AlandIslands { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "358",
        Continent = Europe,
        FullName = "Åland Islands",
        IsEuropeanUnionMember = true, // as a result of being part of Finland
        IsNatoMember = false,
        Iso3166Alpha2Code = "AX",
        Iso3166Alpha3Code = "ALA",
        IsOecdMember = false,
        Name = "Åland Islands",
        NdcLengths = s_ndc_2,
        NsnLengths = s_nsn_7_8_9,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Andorra.
    /// </summary>
    public static CountryInfo Andorra { get; } = new()
    {
        CallingCode = "376",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Principality of Andorra",
        Iso3166Alpha2Code = "AD",
        Iso3166Alpha3Code = "AND",
        Name = "Andorra",
        NsnLengths = s_nsn_6_8_9,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Austria.
    /// </summary>
    public static CountryInfo Austria { get; } = new()
    {
        CallingCode = "43",
        Continent = Europe,
        FullName = "Republic of Austria",
        IsEuropeanUnionMember = true,
        Iso3166Alpha2Code = "AT",
        Iso3166Alpha3Code = "AUT",
        IsOecdMember = true,
        Name = "Austria",
        NdcLengths = s_ndc_4_3_2_1,
        NsnLengths = s_nsn_4_5_6_7_8_9_10_11_12_13,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Belarus.
    /// </summary>
    public static CountryInfo Belarus { get; } = new()
    {
        CallingCode = "375",
        Continent = Europe,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        FullName = "Republic of Belarus",
        InternationalCallPrefix = "8~10",
        Iso3166Alpha2Code = "BY",
        Iso3166Alpha3Code = "BLR",
        Name = "Belarus",
        NdcLengths = s_ndc_4_3_2,
        NsnLengths = s_nsn_6_9_10_11,
        TrunkPrefix = "8",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Belgium.
    /// </summary>
    public static CountryInfo Belgium { get; } = new()
    {
        CallingCode = "32",
        Continent = Europe,
        FormatProvider = BEPhoneNumberFormatProvider.Instance,
        FullName = "Kingdom of Belgium",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "BE",
        Iso3166Alpha3Code = "BEL",
        IsOecdMember = true,
        Name = "Belgium",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_8_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bosnia and Herzegovina.
    /// </summary>
    public static CountryInfo BosniaAndHerzegovina { get; } = new()
    {
        CallingCode = "387",
        Continent = Europe,
        FullName = "Bosnia and Herzegovina",
        Iso3166Alpha2Code = "BA",
        Iso3166Alpha3Code = "BIH",
        Name = "Bosnia and Herzegovina",
        NdcLengths = s_ndc_4_3_2,
        NsnLengths = s_nsn_6_8_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bulgaria.
    /// </summary>
    public static CountryInfo Bulgaria { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "359",
        Continent = Europe,
        FullName = "Republic of Bulgaria",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "BG",
        Iso3166Alpha3Code = "BGR",
        Name = "Bulgaria",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_8_9_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Croatia.
    /// </summary>
    public static CountryInfo Croatia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "385",
        Continent = Europe,
        FullName = "Republic of Croatia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "HR",
        Iso3166Alpha3Code = "HRV",
        Name = "Croatia",
        NdcLengths = s_ndc_5_4_3_2_1,
        NsnLengths = s_nsn_6_7_8_9_10,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Cyprus.
    /// </summary>
    public static CountryInfo Cyprus { get; } = new()
    {
        CallingCode = "357",
        Continent = Europe,
        FormatProvider = CYPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Cyprus",
        IsEuropeanUnionMember = true,
        Iso3166Alpha2Code = "CY",
        Iso3166Alpha3Code = "CYP",
        Name = "Cyprus",
        NdcLengths = s_ndc_2,
        NsnLengths = s_nsn_8,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Czechia (Czech Republic).
    /// </summary>
    public static CountryInfo CzechRepublic { get; } = new()
    {
        CallingCode = "420",
        Continent = Europe,
        FormatProvider = CZPhoneNumberFormatProvider.Instance,
        FullName = "Czech Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "CZ",
        Iso3166Alpha3Code = "CZE",
        IsOecdMember = true,
        Name = "Czechia",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_7_9_10_11_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Denmark.
    /// </summary>
    public static CountryInfo Denmark { get; } = new()
    {
        CallingCode = "45",
        Continent = Europe,
        FullName = "Kingdom of Denmark",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "DK",
        Iso3166Alpha3Code = "DNK",
        IsOecdMember = true,
        Name = "Denmark",
        NsnLengths = s_nsn_8_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Estonia.
    /// </summary>
    public static CountryInfo Estonia { get; } = new()
    {
        CallingCode = "372",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Estonia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "EE",
        Iso3166Alpha3Code = "EST",
        IsOecdMember = true,
        Name = "Estonia",
        NdcLengths = s_ndc_4_3_2,
        NsnLengths = s_nsn_7_8_10_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Faroe Islands.
    /// </summary>
    public static CountryInfo FaroeIslands { get; } = new()
    {
        CallingCode = "298",
        Continent = Europe,
        FormatProvider = FOPhoneNumberFormatProvider.Instance,
        FullName = "Faroe Islands",
        Iso3166Alpha2Code = "FO",
        Iso3166Alpha3Code = "FRO",
        Name = "Faroe Islands",
        NsnLengths = s_ndc_6,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Finland.
    /// </summary>
    public static CountryInfo Finland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "358",
        Continent = Europe,
        FullName = "Republic of Finland",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "FI",
        Iso3166Alpha3Code = "FIN",
        IsOecdMember = true,
        Name = "Finland",
        NdcLengths = s_ndc_4_3_2_1,
        NsnLengths = s_nsn_5_6_7_8_9_10_11_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for France.
    /// </summary>
    public static CountryInfo France { get; } = new()
    {
        CallingCode = "33",
        Continent = Europe,
        FormatProvider = FRPhoneNumberFormatProvider.Instance,
        FullName = "French Republic",
        InternationalCallPrefixes = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "262", "0" }, // To call Réunion and Mayotte from France, subscribers dial 0 instead of +262
            { "590", "0" }, // To call Guadeloupe from France, subscribers dial 0 instead of +590
            { "594", "0" }, // To call French Guiana from France, subscribers dial 0 instead of +594
            { "596", "0" }, // To call Martinique from France, subscribers dial 0 instead of +596
        }.AsReadOnly(),
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "FR",
        Iso3166Alpha3Code = "FRA",
        IsOecdMember = true,
        Name = "France",
        NsnLengths = s_nsn_9_13,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Germany.
    /// </summary>
    public static CountryInfo Germany { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "49",
        Continent = Europe,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        FullName = "Federal Republic of Germany",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "DE",
        Iso3166Alpha3Code = "DEU",
        IsOecdMember = true,
        Name = "Germany",
        NdcLengths = s_ndc_5_4_3_2,
        NsnLengths = s_nsn_4_5_6_7_8_9_10_11_12_13_14,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Gibraltar.
    /// </summary>
    public static CountryInfo Gibraltar { get; } = new()
    {
        CallingCode = "350",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Gibraltar",
        Iso3166Alpha2Code = "GI",
        Iso3166Alpha3Code = "GIB",
        Name = "Gibraltar",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_4_8,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Greece.
    /// </summary>
    public static CountryInfo Greece { get; } = new()
    {
        CallingCode = "30",
        Continent = Europe,
        FormatProvider = GRPhoneNumberFormatProvider.Instance,
        FullName = "Hellenic Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "GR",
        Iso3166Alpha3Code = "GRC",
        IsOecdMember = true,
        Name = "Greece",
        NdcLengths = s_ndc_4_3_2,
        NsnLengths = s_nsn_10,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guernsey.
    /// </summary>
    public static CountryInfo Guernsey { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "44",
        Continent = Europe,
        FormatProvider = GBPhoneNumberFormatProvider.Instance,
        FullName = "Bailiwick of Guernsey",
        Iso3166Alpha2Code = "GG",
        Iso3166Alpha3Code = "GGY",
        Name = "Guernsey",
        NdcLengths = s_ndc_4,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Hungary.
    /// </summary>
    public static CountryInfo Hungary { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "36",
        Continent = Europe,
        FullName = "Hungary",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "HU",
        Iso3166Alpha3Code = "HUN",
        IsOecdMember = true,
        Name = "Hungary",
        NdcLengths = s_ndc_2_1,
        NsnLengths = s_nsn_8_9_12,
        TrunkPrefix = "06",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Iceland.
    /// </summary>
    public static CountryInfo Iceland { get; } = new()
    {
        CallingCode = "354",
        Continent = Europe,
        FullName = "Iceland",
        IsNatoMember = true,
        Iso3166Alpha2Code = "IS",
        Iso3166Alpha3Code = "ISL",
        IsOecdMember = true,
        Name = "Iceland",
        NsnLengths = s_nsn_7_9,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Ireland (Republic of Ireland).
    /// </summary>
    /// <remarks>Covers the Republic of Ireland, Northern Ireland is part of the United Kingdom.</remarks>
    public static CountryInfo Ireland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "353",
        Continent = Europe,
        FullName = "Ireland",
        IsEuropeanUnionMember = true,
        Iso3166Alpha2Code = "IE",
        Iso3166Alpha3Code = "IRL",
        IsOecdMember = true,
        Name = "Ireland",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_7_8_9_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the Isle of Man.
    /// </summary>
    public static CountryInfo IsleOfMan { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "44",
        Continent = Europe,
        FormatProvider = GBPhoneNumberFormatProvider.Instance,
        FullName = "Isle of Man",
        Iso3166Alpha2Code = "IM",
        Iso3166Alpha3Code = "IMN",
        Name = "Isle of Man",
        NdcLengths = s_ndc_4,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Italy.
    /// </summary>
    /// <remarks>Covers Italy (includes the islands of Sardinia and Sicily), and Vatican City.</remarks>
    public static CountryInfo Italy { get; } = new()
    {
        CallingCode = "39",
        Continent = Europe,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        FullName = "Republic of Italy",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "IT",
        Iso3166Alpha3Code = "ITA",
        IsOecdMember = true,
        Name = "Italy",
        NdcLengths = s_ndc_5_4_3_2,
        NsnLengths = s_nsn_5_6_7_8_9_10_11,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Jersey.
    /// </summary>
    public static CountryInfo Jersey { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "44",
        Continent = Europe,
        FormatProvider = GBPhoneNumberFormatProvider.Instance,
        FullName = "Bailiwick of Jersey",
        Iso3166Alpha2Code = "JE",
        Iso3166Alpha3Code = "JEY",
        Name = "Jersey",
        NdcLengths = s_ndc_4,
        NsnLengths = s_nsn_10,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Kosovo.
    /// </summary>
    public static CountryInfo Kosovo { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "383",
        Continent = Europe,
        FullName = "Republic of Kosovo",
        Iso3166Alpha2Code = "XK",
        Iso3166Alpha3Code = "XKK",
        Name = "Kosovo",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_8_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Latvia.
    /// </summary>
    public static CountryInfo Latvia { get; } = new()
    {
        CallingCode = "371",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Latvia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "LV",
        Iso3166Alpha3Code = "LVA",
        IsOecdMember = true,
        Name = "Latvia",
        NsnLengths = s_nsn_8,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Liechtenstein.
    /// </summary>
    public static CountryInfo Liechtenstein { get; } = new()
    {
        CallingCode = "423",
        Continent = Europe,
        FormatProvider = LIPhoneNumberFormatProvider.Instance,
        FullName = "Principality of Liechtenstein",
        Iso3166Alpha2Code = "LI",
        Iso3166Alpha3Code = "LIE",
        Name = "Liechtenstein",
        NsnLengths = s_nsn_7_9,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Lithuania.
    /// </summary>
    public static CountryInfo Lithuania { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "370",
        Continent = Europe,
        FullName = "Republic of Lithuania",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "LT",
        Iso3166Alpha3Code = "LTU",
        IsOecdMember = true,
        Name = "Lithuania",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_8_12,
        TrunkPrefix = "8",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Luxembourg.
    /// </summary>
    public static CountryInfo Luxembourg { get; } = new()
    {
        CallingCode = "352",
        Continent = Europe,
        FormatProvider = LUPhoneNumberFormatProvider.Instance,
        FullName = "Grand Duchy of Luxembourg",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "LU",
        Iso3166Alpha3Code = "LUX",
        IsOecdMember = true,
        Name = "Luxembourg",
        NsnLengths = s_nsn_4_5_6_7_8_9_10_11_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Malta.
    /// </summary>
    public static CountryInfo Malta { get; } = new()
    {
        CallingCode = "356",
        Continent = Europe,
        FullName = "Republic of Malta",
        IsEuropeanUnionMember = true,
        Iso3166Alpha2Code = "MT",
        Iso3166Alpha3Code = "MLT",
        Name = "Malta",
        NsnLengths = s_nsn_8_10,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Moldova.
    /// </summary>
    public static CountryInfo Moldova { get; } = new()
    {
        CallingCode = "373",
        Continent = Europe,
        FullName = "Republic of Moldova",
        Iso3166Alpha2Code = "MD",
        Iso3166Alpha3Code = "MDA",
        Name = "Moldova",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_5_6_7_8,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Monaco.
    /// </summary>
    public static CountryInfo Monaco { get; } = new()
    {
        CallingCode = "377",
        Continent = Europe,
        FullName = "Principality of Monaco",
        FormatProvider = MCPhoneNumberFormatProvider.Instance,
        Iso3166Alpha2Code = "MC",
        Iso3166Alpha3Code = "MCO",
        Name = "Monaco",
        NsnLengths = s_nsn_8_9_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Montenegro.
    /// </summary>
    public static CountryInfo Montenegro { get; } = new()
    {
        CallingCode = "382",
        Continent = Europe,
        FullName = "Montenegro",
        IsNatoMember = true,
        Iso3166Alpha2Code = "ME",
        Iso3166Alpha3Code = "MNE",
        Name = "Montenegro",
        NdcLengths = s_ndc_2,
        NsnLengths = s_nsn_4_5_8_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Netherlands.
    /// </summary>
    public static CountryInfo Netherlands { get; } = new()
    {
        CallingCode = "31",
        Continent = Europe,
        FullName = "Kingdom of the Netherlands",
        FormatProvider = NLPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "NL",
        Iso3166Alpha3Code = "NLD",
        IsOecdMember = true,
        Name = "Netherlands",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for North Macedonia.
    /// </summary>
    public static CountryInfo NorthMacedonia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "389",
        Continent = Europe,
        FullName = "Republic of North Macedonia",
        IsNatoMember = true,
        Iso3166Alpha2Code = "MK",
        Iso3166Alpha3Code = "MKD",
        Name = "North Macedonia",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_8,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Norway.
    /// </summary>
    public static CountryInfo Norway { get; } = new()
    {
        CallingCode = "47",
        Continent = Europe,
        FormatProvider = NOPhoneNumberFormatProvider.Instance,
        FullName = "Kingdom of Norway",
        IsNatoMember = true,
        Iso3166Alpha2Code = "NO",
        Iso3166Alpha3Code = "NOR",
        IsOecdMember = true,
        Name = "Norway",
        NsnLengths = s_nsn_8_12,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Poland.
    /// </summary>
    public static CountryInfo Poland { get; } = new()
    {
        CallingCode = "48",
        Continent = Europe,
        FormatProvider = PLPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Poland",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "PL",
        Iso3166Alpha3Code = "POL",
        IsOecdMember = true,
        Name = "Poland",
        NdcLengths = s_ndc_2,
        NsnLengths = s_nsn_6_7_8_9,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Portugal.
    /// </summary>
    public static CountryInfo Portugal { get; } = new()
    {
        CallingCode = "351",
        Continent = Europe,
        FullName = "Portuguese Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "PT",
        Iso3166Alpha3Code = "PRT",
        IsOecdMember = true,
        Name = "Portugal",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_9,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Romania.
    /// </summary>
    public static CountryInfo Romania { get; } = new()
    {
        CallingCode = "40",
        Continent = Europe,
        FormatProvider = ROPhoneNumberFormatProvider.Instance,
        FullName = "Romania",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "RO",
        Iso3166Alpha3Code = "ROU",
        Name = "Romania",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_6_7_8_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for San Marino.
    /// </summary>
    public static CountryInfo SanMarino { get; } = new()
    {
        CallingCode = "378",
        Continent = Europe,
        FormatProvider = SMPhoneNumberFormatProvider.Instance,
        FullName = "Republic of San Marino",
        Iso3166Alpha2Code = "SM",
        Iso3166Alpha3Code = "SMR",
        Name = "San Marino",
        NsnLengths = s_nsn_6_7_8_9_10,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Serbia.
    /// </summary>
    public static CountryInfo Serbia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "381",
        Continent = Europe,
        FullName = "Republic of Serbia",
        Iso3166Alpha2Code = "RS",
        Iso3166Alpha3Code = "SRB",
        Name = "Serbia",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_8_9_10_11_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Slovakia.
    /// </summary>
    public static CountryInfo Slovakia { get; } = new()
    {
        CallingCode = "421",
        Continent = Europe,
        FullName = "Slovak Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "SK",
        Iso3166Alpha3Code = "SVK",
        IsOecdMember = true,
        Name = "Slovakia",
        NdcLengths = s_ndc_4_3_2_1,
        NsnLengths = s_nsn_9_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Slovenia.
    /// </summary>
    public static CountryInfo Slovenia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "386",
        Continent = Europe,
        FormatProvider = SLPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Slovenia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "SI",
        Iso3166Alpha3Code = "SVN",
        IsOecdMember = true,
        Name = "Slovenia",
        NdcLengths = s_ndc_4_3_2_1,
        NsnLengths = s_nsn_8_12,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Spain.
    /// </summary>
    public static CountryInfo Spain { get; } = new()
    {
        CallingCode = "34",
        Continent = Europe,
        FormatProvider = ESPhoneNumberFormatProvider.Instance,
        FullName = "Kingdom of Spain",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "ES",
        Iso3166Alpha3Code = "ESP",
        IsOecdMember = true,
        Name = "Spain",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_9_13,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Sweden.
    /// </summary>
    public static CountryInfo Sweden { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "46",
        Continent = Europe,
        FormatProvider = SEPhoneNumberFormatProvider.Instance,
        FullName = "Kingdom of Sweden",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Alpha2Code = "SE",
        Iso3166Alpha3Code = "SWE",
        IsOecdMember = true,
        Name = "Sweden",
        NdcLengths = s_ndc_3_2_1,
        NsnLengths = s_nsn_6_7_8_9_10_13,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Switzerland.
    /// </summary>
    public static CountryInfo Switzerland { get; } = new()
    {
        CallingCode = "41",
        Continent = Europe,
        FormatProvider = CHPhoneNumberFormatProvider.Instance,
        FullName = "Swiss Confederation",
        Iso3166Alpha2Code = "CH",
        Iso3166Alpha3Code = "CHE",
        IsOecdMember = true,
        Name = "Switzerland",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_9,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Ukraine.
    /// </summary>
    public static CountryInfo Ukraine { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "380",
        Continent = Europe,
        FormatProvider = UAPhoneNumberFormatProvider.Instance,
        FullName = "Ukraine",
        Iso3166Alpha2Code = "UA",
        Iso3166Alpha3Code = "UKR",
        Name = "Ukraine",
        NdcLengths = s_ndc_3_2,
        NsnLengths = s_nsn_9_10,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United Kingdom (UK).
    /// </summary>
    /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
    public static CountryInfo UnitedKingdom { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "44",
        Continent = Europe,
        FormatProvider = GBPhoneNumberFormatProvider.Instance,
        FullName = "United Kingdom of Great Britain and Northern Ireland",
        IsNatoMember = true,
        Iso3166Alpha2Code = "GB",
        Iso3166Alpha3Code = "GBR",
        IsOecdMember = true,
        Name = "United Kingdom",
        NdcLengths = s_ndc_5_4_3_2,
        NsnLengths = s_nsn_7_9_10,
        TrunkPrefix = "0",
    };
}
