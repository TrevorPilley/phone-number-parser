namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for Sweden numbers.
/// </summary>
internal sealed class SEPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private SEPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new SEPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        var ndcOptional = phoneNumber.NdcIsOptional();

#pragma warning disable S3358 // Extract this nested ternary operation into an independent statement.
        return phoneNumber.NationalDestinationCode!.Length switch
        {
            // 1 digit NDCs are Geo only
            1 => phoneNumber.SubscriberNumber!.Length switch
            {
                6 => international ? "# ## ## ##" : "(0#) ## ## ##",
                7 => international ? "# ### ## ##" : "(0#) ### ## ##",
                8 => international ? "# ### ### ##" : "(0#) ### ### ##",
                _ => base.ProvideFormat(phoneNumber, international),
            },
            2 => phoneNumber.SubscriberNumber!.Length switch
            {
                5 => international ? "## ### ##" : ndcOptional ? "(0##) ### ##" : "0## ### ##",
                6 => international ? "## ## ## ##" : ndcOptional ? "(0##) ## ## ##" : "0## ## ## ##",
                7 => international ? "## ### ## ##" : ndcOptional ? "(0##) ### ## ##" : "0## ### ## ##",
                _ => base.ProvideFormat(phoneNumber, international),
            },
            3 => phoneNumber.SubscriberNumber!.Length switch
            {
                5 => international ? "### ### ##" : ndcOptional ? "(0###) ### ##" : "0### ### ##",
                6 => international ? "### ## ## ##" : ndcOptional ? "(0###) ## ## ##" : "0### ## ## ##",
                _ => base.ProvideFormat(phoneNumber, international),
            },
            _ => base.ProvideFormat(phoneNumber, international),
        };
#pragma warning restore S3358 // Extract this nested ternary operation into an independent statement.
    }
}
