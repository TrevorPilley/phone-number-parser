using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Austria.
    /// </summary>
    public static CountryInfo Austria { get; } = new()
    {
        CallingCode = "43",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "AT",
        Name = "Österreich", // German
        NameEnglish = "Austria",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([4, 5, 6, 7, 8, 9, 10, 11, 12, 13]),
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
        Iso3166Code = "BY",
        Name = "Беларусь", // Belarusian
        NameEnglish = "Belarus",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([6, 9, 10, 11]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "BE",
        Name = "België", // Dutch
        NameEnglish = "Belgium",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bosnia and Herzegovina.
    /// </summary>
    public static CountryInfo BosniaAndHerzegovina { get; } = new()
    {
        CallingCode = "387",
        Continent = Europe,
        Iso3166Code = "BA",
        Name = "Bosnia and Herzegovina",
        NameEnglish = "Bosnia and Herzegovina",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([6, 8, 9]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "BG",
        Name = "България", // Bulgarian
        NameEnglish = "Bulgaria",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 12]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "HR",
        Name = "Hrvatska", // Croatian
        NameEnglish = "Croatia",
        NdcLengths = new ReadOnlyCollection<int>([5, 4, 3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9, 10]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "CY",
        Name = "Κύπρος", // Greek
        NameEnglish = "Cyprus",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([8]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Czech Republic.
    /// </summary>
    public static CountryInfo CzechRepublic { get; } = new()
    {
        CallingCode = "420",
        Continent = Europe,
        FormatProvider = CZPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "CZ",
        Name = "Česká republika", // Czech
        NameEnglish = "Czech Republic",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([7, 9, 10, 11, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Denmark.
    /// </summary>
    public static CountryInfo Denmark { get; } = new()
    {
        CallingCode = "45",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "DK",
        Name = "Danmark", // Danish
        NameEnglish = "Denmark",
        NsnLengths = new ReadOnlyCollection<int>([8]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Estonia.
    /// </summary>
    public static CountryInfo Estonia { get; } = new()
    {
        CallingCode = "372",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "EE",
        Name = "Eesti", // Estonian
        NameEnglish = "Estonia",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 10, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Finland.
    /// </summary>
    public static CountryInfo Finland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "358",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "FI",
        Name = "Suomi", // Finnish
        NameEnglish = "Finland",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([5, 6, 7, 8, 9, 10, 11, 12]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "FR",
        Name = "France",
        NameEnglish = "France",
        NsnLengths = new ReadOnlyCollection<int>([9, 13]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Germany.
    /// </summary>
    public static CountryInfo Germany { get; } = new()
    {
        CallingCode = "49",
        Continent = Europe,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        IsEuropeanUnionMember = true,
        Iso3166Code = "DE",
        Name = "Deutschland", // German
        NameEnglish = "Germany",
        NdcLengths = new ReadOnlyCollection<int>([5, 4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14]),
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
        Iso3166Code = "GI",
        Name = "Gibraltar",
        NameEnglish = "Gibraltar",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([4, 8]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Greece.
    /// </summary>
    public static CountryInfo Greece { get; } = new()
    {
        CallingCode = "30",
        Continent = Europe,
        FormatProvider = GRPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "GR",
        Name = "Ελλάδα", // Greek
        NameEnglish = "Greece",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
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
        Iso3166Code = "GG",
        Name = "Guernsey",
        NameEnglish = "Guernsey",
        NdcLengths = new ReadOnlyCollection<int>([4]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "HU",
        Name = "Magyarország", // Hungarian
        NameEnglish = "Hungary",
        NdcLengths = new ReadOnlyCollection<int>([2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 12]),
        TrunkPrefix = "06",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Iceland.
    /// </summary>
    public static CountryInfo Iceland { get; } = new()
    {
        CallingCode = "354",
        Continent = Europe,
        Iso3166Code = "IS",
        Name = "Ísland", // Icelandic
        NameEnglish = "Iceland",
        NsnLengths = new ReadOnlyCollection<int>([7, 9]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Ireland.
    /// </summary>
    /// <remarks>Covers the Republic of Ireland, Northern Ireland is part of the United Kingdom.</remarks>
    public static CountryInfo Ireland { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "353",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "IE",
        Name = "Ireland",
        NameEnglish = "Ireland",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 9, 12]),
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
        Iso3166Code = "IM",
        Name = "Isle of Man",
        NameEnglish = "Isle of Man",
        NdcLengths = new ReadOnlyCollection<int>([4]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "IT",
        Name = "Italia", // Italian
        NameEnglish = "Italy",
        NdcLengths = new ReadOnlyCollection<int>([5, 4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([5, 6, 7, 8, 9, 10, 11]),
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
        Iso3166Code = "JE",
        Name = "Jersey",
        NameEnglish = "Jersey",
        NdcLengths = new ReadOnlyCollection<int>([4]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
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
        Iso3166Code = "XK",
        Name = "Kosova", // Albanian
        NameEnglish = "Kosovo",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "LV",
        Name = "Latvija", // Latvian
        NameEnglish = "Latvia",
        NsnLengths = new ReadOnlyCollection<int>([8]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Lithuania.
    /// </summary>
    public static CountryInfo Lithuania { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "370",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "LT",
        Name = "Lietuva", // Lithuanian
        NameEnglish = "Lithuania",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "LU",
        Name = "Lëtzebuerg", // Luxembourgish
        NameEnglish = "Luxembourg",
        NsnLengths = new ReadOnlyCollection<int>([4, 5, 6, 7, 8, 9, 10, 11, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Malta.
    /// </summary>
    public static CountryInfo Malta { get; } = new()
    {
        CallingCode = "356",
        Continent = Europe,
        FormatProvider = MTPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "MT",
        Name = "Malta",
        NameEnglish = "Malta",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([8, 10]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Moldova.
    /// </summary>
    public static CountryInfo Moldova { get; } = new()
    {
        CallingCode = "373",
        Continent = Europe,
        Iso3166Code = "MD",
        Name = "Moldova",
        NameEnglish = "Moldova",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([5, 6, 7, 8]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Monaco.
    /// </summary>
    public static CountryInfo Monaco { get; } = new()
    {
        CallingCode = "377",
        Continent = Europe,
        FormatProvider = MCPhoneNumberFormatProvider.Instance,
        Iso3166Code = "MC",
        Name = "Monaco",
        NameEnglish = "Monaco",
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Montenegro.
    /// </summary>
    public static CountryInfo Montenegro { get; } = new()
    {
        CallingCode = "382",
        Continent = Europe,
        Iso3166Code = "ME",
        Name = "Crna Gora",
        NameEnglish = "Montenegro",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([4, 5, 8, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Netherlands.
    /// </summary>
    public static CountryInfo Netherlands { get; } = new()
    {
        CallingCode = "31",
        Continent = Europe,
        FormatProvider = NLPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "NL",
        Name = "Nederland", // Dutch
        NameEnglish = "Netherlands",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9]),
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
        Iso3166Code = "MK",
        Name = "Северна Македонија", // Macedonian
        NameEnglish = "North Macedonia",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8]),
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
        Iso3166Code = "NO",
        Name = "Norge", // Norwegian
        NameEnglish = "Norway",
        NsnLengths = new ReadOnlyCollection<int>([8, 12]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Poland.
    /// </summary>
    public static CountryInfo Poland { get; } = new()
    {
        CallingCode = "48",
        Continent = Europe,
        FormatProvider = PLPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "PL",
        Name = "Polska", // Polish
        NameEnglish = "Poland",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Portugal.
    /// </summary>
    public static CountryInfo Portugal { get; } = new()
    {
        CallingCode = "351",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "PT",
        Name = "Portugal",
        NameEnglish = "Portugal",
        NdcLengths = new ReadOnlyCollection<int>([3]),
        NsnLengths = new ReadOnlyCollection<int>([9]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Romania.
    /// </summary>
    public static CountryInfo Romania { get; } = new()
    {
        CallingCode = "40",
        Continent = Europe,
        FormatProvider = ROPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        Iso3166Code = "RO",
        Name = "România", // Romanian
        NameEnglish = "Romania",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for San Marino.
    /// </summary>
    public static CountryInfo SanMarino { get; } = new()
    {
        CallingCode = "378",
        Continent = Europe,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        Iso3166Code = "SM",
        Name = "San Marino",
        NameEnglish = "San Marino",
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9, 10]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Serbia.
    /// </summary>
    public static CountryInfo Serbia { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "381",
        Continent = Europe,
        Iso3166Code = "RS",
        Name = "Србија", // Serbian
        NameEnglish = "Serbia",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 10, 11, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Slovakia.
    /// </summary>
    public static CountryInfo Slovakia { get; } = new()
    {
        CallingCode = "421",
        Continent = Europe,
        IsEuropeanUnionMember = true,
        Iso3166Code = "SK",
        Name = "Slovensko", // Slovaki
        NameEnglish = "Slovakia",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([7, 9]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "SL",
        Name = "Slovenija", // Slovene
        NameEnglish = "Slovenia",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 12]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "ES",
        Name = "España", // Spanish
        NameEnglish = "Spain",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 13]),
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
        IsEuropeanUnionMember = true,
        Iso3166Code = "SE",
        Name = "Sverige", // Swedish
        NameEnglish = "Sweden",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9, 10, 13]),
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
        Iso3166Code = "CH",
        Name = "Schweiz", // German
        NameEnglish = "Switzerland",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9]),
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
        Iso3166Code = "UA",
        Name = "Україна", // Ukrainian
        NameEnglish = "Ukraine",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 10]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
    /// </summary>
    /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
    public static CountryInfo UnitedKingdom { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "44",
        Continent = Europe,
        FormatProvider = GBPhoneNumberFormatProvider.Instance,
        Iso3166Code = "GB",
        Name = "United Kingdom",
        NameEnglish = "United Kingdom",
        NdcLengths = new ReadOnlyCollection<int>([5, 4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 9, 10]),
        TrunkPrefix = "0",
    };
}
