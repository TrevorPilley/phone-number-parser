namespace PhoneNumbers;

/// <summary>
/// A class containing extension methods for the <see cref="ParseOptions"/> class.
/// </summary>
public static class ParseOptionsExtensions
{
    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Africa.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowAfricanCountries(this ParseOptions parseOptions)
        => AllowCountries(parseOptions, CountryInfo.Africa);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Asia.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowAsianCountries(this ParseOptions parseOptions)
        => AllowCountries(parseOptions, CountryInfo.Asia);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Europe.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowEuropeanCountries(this ParseOptions parseOptions)
        => AllowCountries(parseOptions, CountryInfo.Europe);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Oceania.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowOceanianCountries(this ParseOptions parseOptions)
        => AllowCountries(parseOptions, CountryInfo.Oceania);

    private static void AllowCountries(ParseOptions parseOptions, string continent)
    {
        if (parseOptions is null)
        {
            throw new ArgumentNullException(nameof(parseOptions));
        }

        foreach (var countryInfo in CountryInfo.GetCountries(x => x.Continent == continent))
        {
            parseOptions.Countries.Add(countryInfo);
        }
    }
}
