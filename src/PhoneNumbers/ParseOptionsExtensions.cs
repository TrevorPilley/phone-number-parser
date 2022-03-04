namespace PhoneNumbers;

/// <summary>
/// A class containing extension methods for the <see cref="ParseOptions"/> class.
/// </summary>
public static class ParseOptionsExtensions
{
    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Asia.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowAsianCountries(this ParseOptions parseOptions)
    {
        if (parseOptions is null)
        {
            throw new ArgumentNullException(nameof(parseOptions));
        }

        foreach (var countryInfo in CountryInfo.GetCountries(x => x.Continent == CountryInfo.Asia))
        {
            parseOptions.Countries.Add(countryInfo);
        }
    }

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include countries in Europe.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    public static void AllowEuropeanCountries(this ParseOptions parseOptions)
    {
        if (parseOptions is null)
        {
            throw new ArgumentNullException(nameof(parseOptions));
        }

        foreach (var countryInfo in CountryInfo.GetCountries(x => x.Continent == CountryInfo.Europe))
        {
            parseOptions.Countries.Add(countryInfo);
        }
    }
}
