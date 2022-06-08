namespace PhoneNumbers;

/// <summary>
/// An implementation of <see cref="PhoneNumber"/> which represents a mobile phone number.
/// </summary>
public sealed class MobilePhoneNumber : PhoneNumber, IEquatable<MobilePhoneNumber>
{
    /// <summary>
    /// Initialises a new instance of the <see cref="MobilePhoneNumber"/> class.
    /// </summary>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    /// <param name="nationalSignificantNumber">The national significant number of the phone number.</param>
    /// <param name="nationalDestinationCode">The national destination code of the phone number.</param>
    /// <param name="subscriberNumber">The subscriber number of the phone number.</param>
    internal MobilePhoneNumber(
        CountryInfo countryInfo,
        PhoneNumberHint phoneNumberHint,
        string nationalSignificantNumber,
        string? nationalDestinationCode,
        string subscriberNumber)
        : base(countryInfo, phoneNumberHint, nationalSignificantNumber, nationalDestinationCode, subscriberNumber)
    {
    }

    /// <summary>
    /// The mobile number is likely for a data only plan (e.g. a 3G/LTE laptop or tablet, or mobile broadband).
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsDataOnly =>
        Hint == PhoneNumberHint.Data;

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
    public override PhoneNumberKind PhoneNumberKind =>
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
            PhoneNumberKind.Equals(other.PhoneNumberKind) &&
            (NationalDestinationCode is null && other.NationalDestinationCode is null || NationalDestinationCode!.Equals(other.NationalDestinationCode, StringComparison.Ordinal)) &&
            NationalSignificantNumber.Equals(other.NationalSignificantNumber, StringComparison.Ordinal) &&
            SubscriberNumber.Equals(other.SubscriberNumber, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Hint, Country, PhoneNumberKind, NationalSignificantNumber, NationalDestinationCode, SubscriberNumber);
}
