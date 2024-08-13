namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// The base class for a class which can provide a format for a <see cref="PhoneNumber"/>.
/// </summary>
/// <remarks>
/// It caters for trunk prefixes and whether the National Destination Code (where used) is optional
/// for geographic numbers or where the geographic area is specifically closed.
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
        : base(new Dictionary<Tuple<int, int>, string>
                {
                    { Tuple.Create(0, 6), "### ###" },
                    { Tuple.Create(0, 7), "### ####" },
                    { Tuple.Create(0, 8), "#### ####" },
                    { Tuple.Create(0, 9), "### ### ###" },
                    { Tuple.Create(1, 6), "# ### ###" },
                    { Tuple.Create(1, 7), "# ### ####" },
                    { Tuple.Create(1, 8), "# #### ####" },
                    { Tuple.Create(1, 9), "# ### ### ###" },
                    { Tuple.Create(2, 6), "## ### ###" },
                    { Tuple.Create(2, 7), "## ### ####" },
                    { Tuple.Create(2, 8), "## #### ####" },
                    { Tuple.Create(2, 9), "## ### ### ###" },
                    { Tuple.Create(3, 6), "### ### ###" },
                    { Tuple.Create(3, 7), "### ### ####" },
                    { Tuple.Create(3, 8), "### #### ####" },
                    { Tuple.Create(3, 9), "### ### ### ###" },
                    { Tuple.Create(4, 6), "#### ### ###" },
                    { Tuple.Create(4, 7), "#### ### ####" },
                    { Tuple.Create(4, 8), "#### #### ####" },
                    { Tuple.Create(4, 9), "#### ### ### ###" },
                    { Tuple.Create(5, 6), "##### ### ###" },
                    { Tuple.Create(5, 7), "##### ### ####" },
                    { Tuple.Create(5, 8), "##### #### ####" },
                    { Tuple.Create(5, 9), "##### ### ### ###" },
                })
    {
    }

    internal static new PhoneNumberFormatProvider Default { get; } = new ComplexPhoneNumberFormatProvider();
}
