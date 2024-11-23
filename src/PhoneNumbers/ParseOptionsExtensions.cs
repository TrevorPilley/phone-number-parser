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
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.Africa, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Asia.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowAsianCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.Asia, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Europe.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowEuropeanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.Europe, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries who are members of the European Union.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowEuropeanUnionCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.IsEuropeanUnionMember);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries who are members of the North Atlantic Treaty Organisation.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowNatoCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.IsNatoMember);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in North America.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowNorthAmericanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.NorthAmerica, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries using North American Numbering Plan.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowNorthAmericanNumberingPlanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.CallingCode.Equals(CountryInfo.NanpCallingCode, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in Oceania.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowOceanianCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.Oceania, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries who are members of the Organisation for Economic Co-operation and Development.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowOecdCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.IsOecdMember);

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries in South America.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    public static ParseOptions AllowSouthAmericanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.Continent.Equals(CountryInfo.SouthAmerica, StringComparison.Ordinal));

    /// <summary>
    /// Allows the <see cref="ParseOptions"/> instance to include all supported countries using United Kingdom Numbering Plan.
    /// </summary>
    /// <param name="parseOptions">The <see cref="ParseOptions"/> instance to update.</param>
    /// <exception cref="ArgumentNullException">Thrown if the specified <paramref name="parseOptions"/> is null.</exception>
    /// <returns>The updated <see cref="ParseOptions"/>.</returns>
    /// <remarks>Adds Guernsey, Jersey and Isle of Man in addition to the United Kingdom.</remarks>
    public static ParseOptions AllowUnitedKingdomNumberingPlanCountries(this ParseOptions parseOptions) =>
        Allow(parseOptions, x => x.CallingCode.Equals(CountryInfo.UnitedKingdom.CallingCode, StringComparison.Ordinal));

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
