using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Andorra.
    /// </summary>
    public static CountryInfo Andorra { get; } = new()
    {
        CallingCode = "376",
        Continent = Europe,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Principality of Andorra",
        Iso3166Code = "AD",
        Name = "Andorra",
        NsnLengths = new ReadOnlyCollection<int>([6, 8, 9]),
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
        Iso3166Code = "AT",
        IsOecdMember = true,
        Name = "Austria",
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
        FullName = "Republic of Belarus",
        InternationalCallPrefix = "8~10",
        Iso3166Code = "BY",
        Name = "Belarus",
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
        FullName = "Kingdom of Belgium",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "BE",
        IsOecdMember = true,
        Name = "Belgium",
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
        FullName = "Bosnia and Herzegovina",
        Iso3166Code = "BA",
        Name = "Bosnia and Herzegovina",
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
        FullName = "Republic of Bulgaria",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "BG",
        Name = "Bulgaria",
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
        FullName = "Republic of Croatia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "HR",
        Name = "Croatia",
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
        FullName = "Republic of Cyprus",
        IsEuropeanUnionMember = true,
        Iso3166Code = "CY",
        Name = "Cyprus",
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
        FullName = "Czech Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "CZ",
        IsOecdMember = true,
        Name = "Czech Republic",
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
        FullName = "Denmark",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "DK",
        IsOecdMember = true,
        Name = "Denmark",
        NsnLengths = new ReadOnlyCollection<int>([8, 12]),
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
        Iso3166Code = "EE",
        IsOecdMember = true,
        Name = "Estonia",
        NdcLengths = new ReadOnlyCollection<int>([4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 10, 12]),
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
        Iso3166Code = "FO",
        Name = "Faroe Islands",
        NsnLengths = new ReadOnlyCollection<int>([6]),
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
        Iso3166Code = "FI",
        IsOecdMember = true,
        Name = "Finland",
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
        FullName = "French Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "FR",
        IsOecdMember = true,
        Name = "France",
        NsnLengths = new ReadOnlyCollection<int>([9, 13]),
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
        Iso3166Code = "DE",
        IsOecdMember = true,
        Name = "Germany",
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
        FullName = "Gibraltar",
        Iso3166Code = "GI",
        Name = "Gibraltar",
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
        FullName = "Hellenic Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "GR",
        IsOecdMember = true,
        Name = "Greece",
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
        FullName = "Guernsey",
        Iso3166Code = "GG",
        Name = "Guernsey",
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
        FullName = "Hungary",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "HU",
        IsOecdMember = true,
        Name = "Hungary",
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
        FullName = "Iceland",
        IsNatoMember = true,
        Iso3166Code = "IS",
        IsOecdMember = true,
        Name = "Iceland",
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
        FullName = "Ireland",
        IsEuropeanUnionMember = true,
        Iso3166Code = "IE",
        IsOecdMember = true,
        Name = "Ireland",
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
        FullName = "Isle of Man",
        Iso3166Code = "IM",
        Name = "Isle of Man",
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
        FullName = "Italian Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "IT",
        IsOecdMember = true,
        Name = "Italy",
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
        FullName = "Bailiwick of Jersey",
        Iso3166Code = "JE",
        Name = "Jersey",
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
        FullName = "Republic of Kosovo",
        Iso3166Code = "XK",
        Name = "Kosovo",
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
        FullName = "Republic of Latvia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "LV",
        IsOecdMember = true,
        Name = "Latvia",
        NsnLengths = new ReadOnlyCollection<int>([8]),
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
        Iso3166Code = "LI",
        Name = "Liechtenstein",
        NsnLengths = new ReadOnlyCollection<int>([7, 9]),
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
        Iso3166Code = "LT",
        IsOecdMember = true,
        Name = "Lithuania",
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
        FullName = "Grand Duchy of Luxembourg",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "LU",
        IsOecdMember = true,
        Name = "Luxembourg",
        NsnLengths = new ReadOnlyCollection<int>([4, 5, 6, 7, 8, 9, 10, 11, 12]),
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
        Iso3166Code = "MT",
        Name = "Malta",
        NsnLengths = new ReadOnlyCollection<int>([8, 10]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Moldova.
    /// </summary>
    public static CountryInfo Moldova { get; } = new()
    {
        CallingCode = "373",
        Continent = Europe,
        FullName = "Republic of Moldova",
        Iso3166Code = "MD",
        Name = "Moldova",
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
        FullName = "Principality of Monaco",
        FormatProvider = MCPhoneNumberFormatProvider.Instance,
        Iso3166Code = "MC",
        Name = "Monaco",
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 12]),
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
        Iso3166Code = "ME",
        Name = "Montenegro",
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
        FullName = "Netherlands",
        FormatProvider = NLPhoneNumberFormatProvider.Instance,
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "NL",
        IsOecdMember = true,
        Name = "Netherlands",
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
        FullName = "Republic of North Macedonia",
        IsNatoMember = true,
        Iso3166Code = "MK",
        Name = "North Macedonia",
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
        FullName = "Kingdom of Norway",
        IsNatoMember = true,
        Iso3166Code = "NO",
        IsOecdMember = true,
        Name = "Norway",
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
        FullName = "Republic of Poland",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "PL",
        IsOecdMember = true,
        Name = "Poland",
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
        FullName = "Portuguese Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "PT",
        IsOecdMember = true,
        Name = "Portugal",
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
        FullName = "Romania",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "RO",
        Name = "Romania",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([6, 7, 8, 9]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Russia.
    /// </summary>
    public static CountryInfo Russia { get; } = new()
    {
        CallingCode = "7",
        Continent = Europe,
        FullName = "Russian Federation",
        InternationalCallPrefix = "8~xx",
        Iso3166Code = "RU",
        Name = "Russia",
        NdcLengths = new ReadOnlyCollection<int>([3]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
        TrunkPrefix = "8",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for San Marino.
    /// </summary>
    public static CountryInfo SanMarino { get; } = new()
    {
        CallingCode = "378",
        Continent = Europe,
        FormatProvider = SMPhoneNumberFormatProvider.Instance,
        FullName = "Most Serene Republic of San Marino",
        Iso3166Code = "SM",
        Name = "San Marino",
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
        FullName = "Republic of Serbia",
        Iso3166Code = "RS",
        Name = "Serbia",
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
        FullName = "Slovak Republic",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "SK",
        IsOecdMember = true,
        Name = "Slovakia",
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
        FullName = "Republic of Slovenia",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "SL",
        IsOecdMember = true,
        Name = "Slovenia",
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
        FullName = "Kingdom of Spain",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "ES",
        IsOecdMember = true,
        Name = "Spain",
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
        FullName = "Kingdom of Sweden",
        IsEuropeanUnionMember = true,
        IsNatoMember = true,
        Iso3166Code = "SE",
        IsOecdMember = true,
        Name = "Sweden",
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
        FullName = "Swiss Confederation",
        Iso3166Code = "CH",
        IsOecdMember = true,
        Name = "Switzerland",
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
        FullName = "Ukraine",
        Iso3166Code = "UA",
        Name = "Ukraine",
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
        FullName = "United Kingdom of Great Britain and Northern Ireland",
        IsNatoMember = true,
        Iso3166Code = "GB",
        IsOecdMember = true,
        Name = "United Kingdom",
        NdcLengths = new ReadOnlyCollection<int>([5, 4, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 9, 10]),
        TrunkPrefix = "0",
    };
}
