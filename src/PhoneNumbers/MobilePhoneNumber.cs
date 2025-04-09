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
    public static bool operator ==(MobilePhoneNumber? phoneNumber1, MobilePhoneNumber? phoneNumber2) =>
        phoneNumber1 is null ? phoneNumber2 is null : phoneNumber1.Equals(phoneNumber2);

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

        // The National Significant Number (NSN) must be unique within a numbering plan so only
        // where the countries match and the NSNs match they are the the same phone number.
        return Country.Equals(other.Country) &&
            NationalSignificantNumber.Equals(other.NationalSignificantNumber, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Country, NationalSignificantNumber);
}
