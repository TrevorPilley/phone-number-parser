using System.Collections.ObjectModel;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Austria.
    /// </summary>
    public static CountryInfo Austria { get; } = new()
    {
        CallingCode = "+43",
        Continent = Europe,
        Iso3166Code = "AT",
        Name = "Austria",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Belarus.
    /// </summary>
    public static CountryInfo Belarus { get; } = new()
    {
        CallingCode = "+375",
        Continent = Europe,
        InternationalCallPrefix = "810",
        Iso3166Code = "BY",
        Name = "Belarus",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 9, 10, 11 }),
        TrunkPrefix = "8",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Belgium.
    /// </summary>
    public static CountryInfo Belgium { get; } = new()
    {
        CallingCode = "+32",
        Continent = Europe,
        Iso3166Code = "BE",
        Name = "Belgium",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Bulgaria.
    /// </summary>
    public static CountryInfo Bulgaria { get; } = new()
    {
        CallingCode = "+359",
        Continent = Europe,
        Iso3166Code = "BG",
        Name = "Bulgaria",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9, 12 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Croatia.
    /// </summary>
    public static CountryInfo Croatia { get; } = new()
    {
        CallingCode = "+385",
        Continent = Europe,
        Iso3166Code = "HR",
        Name = "Croatia",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Czech Republic.
    /// </summary>
    public static CountryInfo CzechRepublic { get; } = new()
    {
        CallingCode = "+420",
        Continent = Europe,
        Iso3166Code = "CZ",
        Name = "Czech Republic",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 9, 10, 11, 12 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Denmark.
    /// </summary>
    public static CountryInfo Denmark { get; } = new()
    {
        CallingCode = "+45",
        Continent = Europe,
        Iso3166Code = "DK",
        Name = "Denmark",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8 }),
        RequireNdcForLocalGeographicDialling = false,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Estonia.
    /// </summary>
    public static CountryInfo Estonia { get; } = new()
    {
        CallingCode = "+372",
        Continent = Europe,
        Iso3166Code = "EE",
        Name = "Estonia",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8, 10, 12 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Finland.
    /// </summary>
    public static CountryInfo Finland { get; } = new()
    {
        CallingCode = "+358",
        Continent = Europe,
        Iso3166Code = "FI",
        Name = "Finland",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 5, 6, 7, 8, 9, 10, 11, 12 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for France.
    /// </summary>
    public static CountryInfo France { get; } = new()
    {
        CallingCode = "+33",
        Continent = Europe,
        Iso3166Code = "FR",
        Name = "France",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9, 13 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Germany.
    /// </summary>
    public static CountryInfo Germany { get; } = new()
    {
        CallingCode = "+49",
        Continent = Europe,
        Iso3166Code = "DE",
        Name = "Germany",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Gibraltar.
    /// </summary>
    public static CountryInfo Gibraltar { get; } = new()
    {
        CallingCode = "+350",
        Continent = Europe,
        Iso3166Code = "GI",
        Name = "Gibraltar",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 4, 8 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Greece.
    /// </summary>
    public static CountryInfo Greece { get; } = new()
    {
        CallingCode = "+30",
        Continent = Europe,
        Iso3166Code = "GR",
        Name = "Greece",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Guernsey.
    /// </summary>
    public static CountryInfo Guernsey { get; } = new()
    {
        CallingCode = "+44",
        Continent = Europe,
        Iso3166Code = "GG",
        Name = "Guernsey",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Hong Kong.
    /// </summary>
    public static CountryInfo HongKong { get; } = new()
    {
        CallingCode = "+852",
        Continent = Asia,
        InternationalCallPrefix = "001",
        Iso3166Code = "HK",
        Name = "Hong Kong",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9, 12 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Hungary.
    /// </summary>
    public static CountryInfo Hungary { get; } = new()
    {
        CallingCode = "+36",
        Continent = Europe,
        Iso3166Code = "HU",
        Name = "Hungary",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9, 12 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "06",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Ireland.
    /// </summary>
    /// <remarks>Covers the Republic of Ireland, Northern Ireland is part of the United Kingdom.</remarks>
    public static CountryInfo Ireland { get; } = new()
    {
        CallingCode = "+353",
        Continent = Europe,
        Iso3166Code = "IE",
        Name = "Ireland",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 8, 9, 12 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the Isle of Man.
    /// </summary>
    public static CountryInfo IsleOfMan { get; } = new()
    {
        CallingCode = "+44",
        Continent = Europe,
        Iso3166Code = "IM",
        Name = "Isle of Man",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Italy.
    /// </summary>
    /// <remarks>Covers Italy (includes the islands of Sardinia and Sicily), and Vatican City.</remarks>
    public static CountryInfo Italy { get; } = new()
    {
        CallingCode = "+39",
        Continent = Europe,
        Iso3166Code = "IT",
        Name = "Italy",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 5, 6, 7, 8, 9, 10, 11 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Jersey.
    /// </summary>
    public static CountryInfo Jersey { get; } = new()
    {
        CallingCode = "+44",
        Continent = Europe,
        Iso3166Code = "JE",
        Name = "Jersey",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 10 }),
        RequireNdcForLocalGeographicDialling = false,
        SharesCallingCode = true,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Kosovo.
    /// </summary>
    public static CountryInfo Kosovo { get; } = new()
    {
        CallingCode = "+383",
        Continent = Europe,
        Iso3166Code = "XK",
        Name = "Kosovo",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Macau.
    /// </summary>
    public static CountryInfo Macau { get; } = new()
    {
        CallingCode = "+853",
        Continent = Asia,
        Iso3166Code = "MO",
        Name = "Macau",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Moldova.
    /// </summary>
    public static CountryInfo Moldova { get; } = new()
    {
        CallingCode = "+373",
        Continent = Europe,
        Iso3166Code = "MD",
        Name = "Moldova",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 5, 6, 7, 8 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Monaco.
    /// </summary>
    public static CountryInfo Monaco { get; } = new()
    {
        CallingCode = "+377",
        Continent = Europe,
        Iso3166Code = "MC",
        Name = "Monaco",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Netherlands.
    /// </summary>
    public static CountryInfo Netherlands { get; } = new()
    {
        CallingCode = "+31",
        Continent = Europe,
        Iso3166Code = "NL",
        Name = "Netherlands",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Norway.
    /// </summary>
    public static CountryInfo Norway { get; } = new()
    {
        CallingCode = "+47",
        Continent = Europe,
        Iso3166Code = "NO",
        Name = "Norway",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 12 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Poland.
    /// </summary>
    public static CountryInfo Poland { get; } = new()
    {
        CallingCode = "+48",
        Continent = Europe,
        Iso3166Code = "PL",
        Name = "Poland",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Portugal.
    /// </summary>
    public static CountryInfo Portugal { get; } = new()
    {
        CallingCode = "+351",
        Continent = Europe,
        Iso3166Code = "PT",
        Name = "Portugal",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Romania.
    /// </summary>
    public static CountryInfo Romania { get; } = new()
    {
        CallingCode = "+40",
        Continent = Europe,
        Iso3166Code = "RO",
        Name = "Romania",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for San Marino.
    /// </summary>
    public static CountryInfo SanMarino { get; } = new()
    {
        CallingCode = "+378",
        Continent = Europe,
        Iso3166Code = "SM",
        Name = "San Marino",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Serbia.
    /// </summary>
    public static CountryInfo Serbia { get; } = new()
    {
        CallingCode = "+381",
        Continent = Europe,
        Iso3166Code = "RS",
        Name = "Serbia",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 9, 10, 11, 12 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Singapore.
    /// </summary>
    public static CountryInfo Singapore { get; } = new()
    {
        CallingCode = "+65",
        Continent = Asia,
        InternationalCallPrefix = "001",
        Iso3166Code = "SG",
        Name = "Singapore",
        NsnLengths = new ReadOnlyCollection<int>(new[] { 8, 10, 11 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Slovakia.
    /// </summary>
    public static CountryInfo Slovakia { get; } = new()
    {
        CallingCode = "+421",
        Continent = Europe,
        Iso3166Code = "SK",
        Name = "Slovakia",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 4, 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 9 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Spain.
    /// </summary>
    public static CountryInfo Spain { get; } = new()
    {
        CallingCode = "+34",
        Continent = Europe,
        Iso3166Code = "ES",
        Name = "Spain",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Sweden.
    /// </summary>
    public static CountryInfo Sweden { get; } = new()
    {
        CallingCode = "+46",
        Continent = Europe,
        Iso3166Code = "SE",
        Name = "Sweden",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2, 1 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 6, 7, 8, 9, 10, 13 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Switzerland.
    /// </summary>
    public static CountryInfo Switzerland { get; } = new()
    {
        CallingCode = "+41",
        Continent = Europe,
        Iso3166Code = "CH",
        Name = "Switzerland",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9 }),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Ukraine.
    /// </summary>
    public static CountryInfo Ukraine { get; } = new()
    {
        CallingCode = "+380",
        Continent = Europe,
        Iso3166Code = "UA",
        Name = "Ukraine",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 9, 10 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for the United Kingdom.
    /// </summary>
    /// <remarks>Covers England, Scotland, Wales and Northern Ireland.</remarks>
    public static CountryInfo UnitedKingdom { get; } = new()
    {
        CallingCode = "+44",
        Continent = Europe,
        Iso3166Code = "GB",
        Name = "United Kingdom",
        NdcLengths = new ReadOnlyCollection<int>(new[] { 5, 4, 3, 2 }),
        NsnLengths = new ReadOnlyCollection<int>(new[] { 7, 9, 10 }),
        RequireNdcForLocalGeographicDialling = false,
        TrunkPrefix = "0",
    };
}
