namespace PhoneNumbers;

/// <summary>
/// An implementation of <see cref="PhoneNumber"/> which represents a phone number which is not assigned to a geographic area.
/// </summary>
public sealed class NonGeographicPhoneNumber : PhoneNumber, IEquatable<NonGeographicPhoneNumber>
{
    /// <summary>
    /// Initialises a new instance of the <see cref="NonGeographicPhoneNumber"/> class.
    /// </summary>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    internal NonGeographicPhoneNumber(PhoneNumberHint phoneNumberHint)
        : base(phoneNumberHint)
    {
    }

    /// <summary>
    /// The number is a freephone (toll-free) number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsFreephone =>
        Hint == PhoneNumberHint.Freephone;

    /// <summary>
    /// The number is a machine-to-machine (M2M) number.
    /// </summary>
    /// <remarks>This is an indication only based upon the data available for each country.</remarks>
    public bool IsMachineToMachine =>
        Hint == PhoneNumberHint.MachineToMachine;

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
    public override PhoneNumberKind Kind =>
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

        return Country.Equals(other.Country) &&
            NationalSignificantNumber.Equals(other.NationalSignificantNumber, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Hint, Country, Kind, NationalSignificantNumber, NationalDestinationCode, SubscriberNumber);
}
