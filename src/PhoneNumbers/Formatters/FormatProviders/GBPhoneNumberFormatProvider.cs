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
        var ndcOptional = phoneNumber.Kind == PhoneNumberKind.GeographicPhoneNumber &&
            phoneNumber.Country.NumberingPlanType == NumberingPlanType.Open &&
            !((GeographicPhoneNumber)phoneNumber).ClosedDiallingInOpenPlan;

        // The base formats cover all UK formats except for 6 digit subscriber numbers as in the UK they aren't separated.
        return phoneNumber.SubscriberNumber.Length switch
        {
            6 => phoneNumber.NationalDestinationCode!.Length switch
            {
                #pragma warning disable S3358 // Extract this nested ternary operation into an independent statement.
                3 => international ? "### ######" : ndcOptional ? "(0###) ######" : "0### ######",
                4 => international ? "#### ######" : ndcOptional ? "(0####) ######" : "0#### ######",
                5 => international ? "##### ######" : ndcOptional ? "(0#####) ######" : "0##### ######",
                #pragma warning restore S3358 // Extract this nested ternary operation into an independent statement.
                _ => base.ProvideFormat(phoneNumber, international),
            },
            _ => base.ProvideFormat(phoneNumber, international),
        };
    }
}
