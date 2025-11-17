using System.Collections.ObjectModel;
using PhoneNumbers.Formatters.FormatProviders;

namespace PhoneNumbers;

public partial class CountryInfo
{
    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Brazil.
    /// </summary>
    public static CountryInfo Brazil { get; } = new()
    {
        AllowsLocalGeographicDialling = true,
        CallingCode = "55",
        Continent = SouthAmerica,
        FormatProvider = BRPhoneNumberFormatProvider.Instance,
        FullName = "Federative Republic of Brazil",
        InternationalCallPrefix = "0xx",
        Iso3166Code = "BR",
        Name = "Brazil",
        NdcLengths = s_ndc_3_2,
        NsnLengths = new ReadOnlyCollection<int>([10, 11]),
        TrunkPrefix = "0",
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Colombia.
    /// </summary>
    public static CountryInfo Colombia { get; } = new()
    {
        CallingCode = "57",
        Continent = SouthAmerica,
        FormatProvider = COPhoneNumberFormatProvider.Instance,
        FullName = "Republic of Colombia",
        Iso3166Code = "CO",
        IsOecdMember = true,
        Name = "Colombia",
        NdcLengths = s_ndc_3,
        NsnLengths = s_nsn_10,
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Falkland Islands.
    /// </summary>
    public static CountryInfo FalklandIslands { get; } = new()
    {
        CallingCode = "500",
        Continent = SouthAmerica,
        FormatProvider = BasicPhoneNumberFormatProvider.Instance,
        FullName = "Falkland Islands",
        Iso3166Code = "FK",
        Name = "Falkland Islands",
        NsnLengths = new ReadOnlyCollection<int>([5]),
    };

    /// <summary>
    /// Gets the <see cref="CountryInfo"/> for Peru.
    /// </summary>
    public static CountryInfo Peru { get; } = new()
    {
        CallingCode = "51",
        Continent = SouthAmerica,
        FullName = "Republic of Peru",
        Iso3166Code = "PE",
        Name = "Peru",
        NdcLengths = s_ndc_2_1,
        NsnLengths = new ReadOnlyCollection<int>([8, 9]),
        TrunkPrefix = "0",
    };
}
