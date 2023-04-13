namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// The base class for a class which can provide a format for a <see cref="PhoneNumber"/>.
/// </summary>
/// <remarks>
/// It caters for trunk prefixes, the numbering plan type and whether the National Destination Code (where used) is optional
/// for geographic numbers in an open numbering plan where the geographic area is not specifically closed.
/// Subscriber numbers of 5 digits or less are not split
/// Subscriber numbers of 6 digits are split 3-3
/// Subscriber numbers of 7 digits are split 3-4
/// Subscriber numbers of 8 digits are split 4-4
/// Subscriber numbers of 9 digits are split 3-3-3
/// Subscriber numbers of 10 digits or more are not split
/// </remarks>
internal class ComplexPhoneNumberFormatProvider : SimplePhoneNumberFormatProvider
{
    protected ComplexPhoneNumberFormatProvider()
        : base(new Dictionary<KeyValuePair<int, int>, string>
                {
                    { new KeyValuePair<int, int>(0, 6), "### ###" },
                    { new KeyValuePair<int, int>(0, 7), "### ####" },
                    { new KeyValuePair<int, int>(0, 8), "#### ####" },
                    { new KeyValuePair<int, int>(0, 9), "### ### ###" },
                    { new KeyValuePair<int, int>(1, 6), "# ### ###" },
                    { new KeyValuePair<int, int>(1, 7), "# ### ####" },
                    { new KeyValuePair<int, int>(1, 8), "# #### ####" },
                    { new KeyValuePair<int, int>(1, 9), "# ### ### ###" },
                    { new KeyValuePair<int, int>(2, 6), "## ### ###" },
                    { new KeyValuePair<int, int>(2, 7), "## ### ####" },
                    { new KeyValuePair<int, int>(2, 8), "## #### ####" },
                    { new KeyValuePair<int, int>(2, 9), "## ### ### ###" },
                    { new KeyValuePair<int, int>(3, 6), "### ### ###" },
                    { new KeyValuePair<int, int>(3, 7), "### ### ####" },
                    { new KeyValuePair<int, int>(3, 8), "### #### ####" },
                    { new KeyValuePair<int, int>(3, 9), "### ### ### ###" },
                    { new KeyValuePair<int, int>(4, 6), "#### ### ###" },
                    { new KeyValuePair<int, int>(4, 7), "#### ### ####" },
                    { new KeyValuePair<int, int>(4, 8), "#### #### ####" },
                    { new KeyValuePair<int, int>(4, 9), "#### ### ### ###" },
                    { new KeyValuePair<int, int>(5, 6), "##### ### ###" },
                    { new KeyValuePair<int, int>(5, 7), "##### ### ####" },
                    { new KeyValuePair<int, int>(5, 8), "##### #### ####" },
                    { new KeyValuePair<int, int>(5, 9), "##### ### ### ###" },
                })
    {
    }

    internal static new PhoneNumberFormatProvider Default { get; } = new ComplexPhoneNumberFormatProvider();
}
