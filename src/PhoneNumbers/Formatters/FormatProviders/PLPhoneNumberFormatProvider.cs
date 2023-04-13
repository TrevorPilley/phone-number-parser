namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Poland numbers.
/// </summary>
internal sealed class PLPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private PLPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new PLPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international) =>
        phoneNumber.NationalSignificantNumber.Length switch
        {
            9 => phoneNumber.Kind switch
            {
                PhoneNumberKind.MobilePhoneNumber => international ? "### ### ###" : "###-###-###",
                _ => international ? "## ### ## ##" : "##-###-##-##",
            },
            _ => base.ProvideFormat(phoneNumber, international),
        };
}
