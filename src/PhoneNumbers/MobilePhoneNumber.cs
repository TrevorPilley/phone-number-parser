namespace PhoneNumbers;

/// <summary>
/// An implementation of <see cref="PhoneNumber"/> which represents a mobile phone number.
/// </summary>
public sealed class MobilePhoneNumber : PhoneNumber, IEquatable<MobilePhoneNumber>
{
    /// <summary>
    /// Initialises a new instance of the <see cref="MobilePhoneNumber"/> class.
    /// </summary>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    internal MobilePhoneNumber(PhoneNumberHint phoneNumberHint)
        : base(phoneNumberHint)
    {
    }

    /// <summary>
    /// The mobile number is likely for a pager.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsPager =>
        Hint == PhoneNumberHint.Pager;

    /// <summary>
    /// The mobile number is likely a virtual number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country (see https://en.wikipedia.org/wiki/Virtual_number for further details).</remarks>
    public bool IsVirtual =>
        Hint == PhoneNumberHint.Virtual;

    /// <inheritdoc/>
    public override PhoneNumberKind Kind =>
        PhoneNumberKind.MobilePhoneNumber;

    /// <inheritdoc/>
    public static bool operator !=(MobilePhoneNumber? phoneNumber1, MobilePhoneNumber? phoneNumber2) =>
        !(phoneNumber1 == phoneNumber2);

    /// <inheritdoc/>
    public static bool operator ==(MobilePhoneNumber? phoneNumber1, MobilePhoneNumber? phoneNumber2)
    {
        if (phoneNumber1 is null)
        {
            return phoneNumber2 is null;
        }

        return phoneNumber1.Equals(phoneNumber2);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        Equals(obj as MobilePhoneNumber);

    /// <inheritdoc/>
    public bool Equals(MobilePhoneNumber? other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Hint.Equals(other.Hint) &&
            Country.Equals(other.Country) &&
            Kind.Equals(other.Kind) &&
            (!HasNationalDestinationCode && !other.HasNationalDestinationCode || NationalDestinationCode!.Equals(other.NationalDestinationCode, StringComparison.Ordinal)) &&
            NationalSignificantNumber.Equals(other.NationalSignificantNumber, StringComparison.Ordinal) &&
            SubscriberNumber.Equals(other.SubscriberNumber, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Hint, Country, Kind, NationalSignificantNumber, NationalDestinationCode, SubscriberNumber);
}
