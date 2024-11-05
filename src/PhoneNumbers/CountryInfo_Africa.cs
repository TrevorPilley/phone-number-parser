using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Egypt.
    /// </summary>
    public static CountryInfo Egypt { get; } = new()
    {
        CallingCode = "20",
        Continent = Africa,
        Iso3166Code = "EG",
        Name = "Egypt",
        NdcLengths = new ReadOnlyCollection<int>([3, 2, 1]),
        NsnLengths = new ReadOnlyCollection<int>([8, 9, 10, 11]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Kenya.
    /// </summary>
    public static CountryInfo Kenya { get; } = new()
    {
        CallingCode = "254",
        Continent = Africa,
        FormatProvider = SimplePhoneNumberFormatProvider.Default,
        InternationalCallPrefix = "000",
        InternationalCallPrefixes = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "255", "007" }, // To call Tanzania from Kenya, subscribers dial 007 instead of +255
            { "256", "006" }, // To call Uganda from Kenya, subscribers dial 006 instead of +256
        }.AsReadOnly(),
        Iso3166Code = "KE",
        Name = "Kenya",
        NdcLengths = new ReadOnlyCollection<int>([3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([7, 8, 9, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Nigeria.
    /// </summary>
    public static CountryInfo Nigeria { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "234",
        Continent = Africa,
        InternationalCallPrefix = "009",
        Iso3166Code = "NG",
        Name = "Nigeria",
        NdcLengths = new ReadOnlyCollection<int>([4, 3]),
        NsnLengths = new ReadOnlyCollection<int>([10]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for South Africa.
    /// </summary>
    public static CountryInfo SouthAfrica { get; } = new()
    {
        CallingCode = "27",
        Continent = Africa,
        Iso3166Code = "ZA",
        Name = "South Africa",
        NdcLengths = new ReadOnlyCollection<int>([2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 13]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Tanzania.
    /// </summary>
    public static CountryInfo Tanzania { get; } = new()
    {
        CallingCode = "255",
        Continent = Africa,
        InternationalCallPrefix = "000",
        InternationalCallPrefixes = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "254", "005" }, // To call Kenya from Tanzania, subscribers dial 005 instead of +254
            { "256", "006" }, // To call Uganda from Tanzania, subscribers dial 006 instead of +256
        }.AsReadOnly(),
        Iso3166Code = "TZ",
        Name = "Tanzania",
        NdcLengths = new ReadOnlyCollection<int>([5, 3, 2]),
        NsnLengths = new ReadOnlyCollection<int>([9, 12]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Uganda.
    /// </summary>
    public static CountryInfo Uganda { get; } = new()
    {
        CallingCode = "256",
        Continent = Africa,
        FormatProvider = UGPhoneNumberFormatProvider.Instance,
        InternationalCallPrefix = "000",
        InternationalCallPrefixes = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "254", "005" }, // To call Kenya from Uganda, subscribers dial 005 instead of +254
            { "255", "007" }, // To call Tanzania from Uganda, subscribers dial 007 instead of +255
        }.AsReadOnly(),
        Iso3166Code = "UG",
        Name = "Uganda",
        NdcLengths = new ReadOnlyCollection<int>([6, 5, 4, 3, 1]),
        NsnLengths = new ReadOnlyCollection<int>([9]),
        TrunkPrefix = "0",
    };
}
