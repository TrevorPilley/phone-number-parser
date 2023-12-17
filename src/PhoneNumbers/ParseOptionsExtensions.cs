namespace PhoneNumbers;

/// <summary>
/// A class containing extension methods for the <see cref="ParseOptions"/> class.
/// </summary>
public static class ParseOptionsExtensions
{
    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Africa.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowAfricanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.Africa);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Asia.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowAsianCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.Asia);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Europe.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowEuropeanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.Europe);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries who are members of the European Union.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowEuropeanUnionCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.IsEuropeanUnionMember);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in North America.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowNorthAmericanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.NorthAmerica);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries using North American Numbering Plan.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowNorthAmericanNumberingPlanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.CallingCode == CountryInfo.NanpCallingCode);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Oceania.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowOceanianCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.Oceania);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in South America.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowSouthAmericanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent == CountryInfo.SouthAmerica);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries using United Kingdom Numbering Plan.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    /// <remarks>Adds Guernsey, Jersey and Isle of Man in addition to the United Kingdom.</remarks>
    public static ParseOptions AllowUnitedKingdomNumberingPlanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.CallingCode == CountryInfo.UnitedKingdom.CallingCode);

    private static ParseOptions Allow(ParseOptions parseOptions, Func<CountryInfo, bool> predicate)
    {
        if (parseOptions is null)
        {
            throw new ArgumentNullException(nameof(parseOptions));
        }

        foreach (var countryInfo in CountryInfo.GetCountries(predicate))
        {
            parseOptions.Countries.Add(countryInfo);
        }

        return parseOptions;
    }
}
