namespace PhoneNumbers.Formatters.FormatProviders;

/// <summary>
/// A <see cref="PhoneNumberFormatProvider"/> for United Kingdom numbers.
/// </summary>
internal sealed class GBPhoneNumberFormatProvider : ComplexPhoneNumberFormatProvider
{
    private GBPhoneNumberFormatProvider()
    {
    }

    internal static PhoneNumberFormatProvider Instance { get; } = new GBPhoneNumberFormatProvider();

    protected override string ProvideFormat(PhoneNumber phoneNumber, bool international)
    {
        var ndcOptional = phoneNumber.NdcIsOptional();

        // The base formats cover all UK formats except for 6 digit subscriber numbers as in the UK they aren't separated.
        if (phoneNumber.SubscriberNumber.Length == 6 &&
            phoneNumber.NationalDestinationCode!.Length == 4)
        {
#pragma warning disable S3358 // Extract this nested ternary operation into an independent statement.
            return international ? "#### ######" : ndcOptional ? "(0####) ######" : "0#### ######";
#pragma warning restore S3358 // Extract this nested ternary operation into an independent statement.
        }

        return base.ProvideFormat(phoneNumber, international);
    }
}
