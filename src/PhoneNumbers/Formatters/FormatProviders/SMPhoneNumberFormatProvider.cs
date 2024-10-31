namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for San Marino numbers.
/// </summary>
internal sealed class SMPhoneNumberFormatProvider : SimplePhoneNumberFormatProvider
{
    private SMPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new SMPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        if (phoneNumber.SubscriberNumber.StartsWith("0549", StringComparison.Ordinal))
        {
            return phoneNumber.NationalSignificantNumber.Length switch
            {
                6 => international ? "#### ##" : "(####) ##",
                7 => international ? "#### ###" : "(####) ###",
                8 => international ? "#### ####" : "(####) ####",
                9 => international ? "#### #####" : "(####) #####",
                10 => international ? "#### ######" : "(####) ######",
                _ => base.ProvideFormat(phoneNumber, international),
            };
        }

        return phoneNumber.NationalSignificantNumber.Length switch
        {
            8 => "## ######",
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
