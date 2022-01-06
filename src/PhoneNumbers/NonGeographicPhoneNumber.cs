namespace PhoneNumbers;

/// <summary>
/// An implementation of <see cref="PhoneNumber"/> which represents a phone number which is not assigned to a geographic area.
/// </summary>
public sealed class NonGeographicPhoneNumber : PhoneNumber, IEquatable<NonGeographicPhoneNumber>
{
    /// <summary>
    /// Initialises a new instance of the <see cref="NonGeographicPhoneNumber"/> class.
    /// </summary>
    /// <param name="countryInfo">The <see cref="CountryInfo"/> for the phone number.</param>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    /// <param name="nationalSignificantNumber">The national significant number of the phone number.</param>
    /// <param name="nationalDestinationCode">The national destination code of the phone number.</param>
    /// <param name="subscriberNumber">The subscriber number of the phone number.</param>
    internal NonGeographicPhoneNumber(
        CountryInfo countryInfo,
        PhoneNumberHint phoneNumberHint,
        string nationalSignificantNumber,
        string? nationalDestinationCode,
        string subscriberNumber)
        : base(countryInfo, phoneNumberHint, nationalSignificantNumber, nationalDestinationCode, subscriberNumber)
    {
    }

    /// <summary>
    /// The number is a freephone (toll-free) number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsFreephone =>
        Hint == PhoneNumberHint.Freephone;

    /// <summary>
    /// The number is a premium rate number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsPremiumRate =>
        Hint == PhoneNumberHint.PremiumRate;

    /// <summary>
    /// The number is a shared cost number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsSharedCost =>
        Hint == PhoneNumberHint.SharedCost;

    /// <inheritdoc/>
    public override PhoneNumberKind PhoneNumberKind =>
        PhoneNumberKind.NonGeographicPhoneNumber;

    /// <inheritdoc/>
    public static bool operator !=(NonGeographicPhoneNumber? phoneNumber1, NonGeographicPhoneNumber? phoneNumber2) =>
        !(phoneNumber1 == phoneNumber2);

    /// <inheritdoc/>
    public static bool operator ==(NonGeographicPhoneNumber? phoneNumber1, NonGeographicPhoneNumber? phoneNumber2)
    {
        if (phoneNumber1 is null)
        {
            return phoneNumber2 is null;
        }

        return phoneNumber1.Equals(phoneNumber2);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        Equals(obj as NonGeographicPhoneNumber);

    /// <inheritdoc/>
    public bool Equals(NonGeographicPhoneNumber? other)
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
