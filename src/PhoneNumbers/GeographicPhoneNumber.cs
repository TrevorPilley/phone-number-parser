namespace PhoneNumbers;

/// <summary>
/// An implementation of <see cref="PhoneNumber"/> which represents a geographically assigned phone number.
/// </summary>
public sealed class GeographicPhoneNumber : PhoneNumber, IEquatable<GeographicPhoneNumber>
{
    /// <summary>
    /// Initialises a new instance of the <see cref="GeographicPhoneNumber"/> class.
    /// </summary>
    /// <param name="phoneNumberHint">The <see cref="PhoneNumberHint"/> for the phone number.</param>
    internal GeographicPhoneNumber(PhoneNumberHint phoneNumberHint)
        : base(phoneNumberHint)
    {
    }

    /// <summary>
    /// Gets the name of the geographic area the phone number the area code is allocated to.
    /// Depending on the country, this could be an individual city or larger region such as a county.
    /// </summary>
    /// <remarks>This is an indication based upon the data available for each country.</remarks>
    public required string GeographicArea { get; init; }

    /// <inheritdoc/>
    public override PhoneNumberKind Kind =>
        PhoneNumberKind.GeographicPhoneNumber;

    /// <summary>
    /// The country operates an open numbering plan, however due to number shortages within
    /// the national destination code the full national significant number must always be dialled.
    /// </summary>
    internal bool ClosedDiallingInOpenPlan =>
        Hint == PhoneNumberHint.ClosedDialling && Country.NumberingPlanType == NumberingPlanType.Open;

    /// <inheritdoc/>
    public static bool operator !=(GeographicPhoneNumber? phoneNumber1, GeographicPhoneNumber? phoneNumber2) =>
        !(phoneNumber1 == phoneNumber2);

    /// <inheritdoc/>
    public static bool operator ==(GeographicPhoneNumber? phoneNumber1, GeographicPhoneNumber? phoneNumber2)
    {
        if (phoneNumber1 is null)
        {
            return phoneNumber2 is null;
        }

        return phoneNumber1.Equals(phoneNumber2);
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) =>
        Equals(obj as GeographicPhoneNumber);

    /// <inheritdoc/>
    public bool Equals(GeographicPhoneNumber? other)
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
            GeographicArea.Equals(other.GeographicArea, StringComparison.Ordinal) &&
            Kind.Equals(other.Kind) &&
            (NationalDestinationCode is null && other.NationalDestinationCode is null || NationalDestinationCode!.Equals(other.NationalDestinationCode, StringComparison.Ordinal)) &&
            NationalSignificantNumber.Equals(other.NationalSignificantNumber, StringComparison.Ordinal) &&
            SubscriberNumber.Equals(other.SubscriberNumber, StringComparison.Ordinal);
    }

    /// <inheritdoc/>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public override int GetHashCode() =>
        HashCode.Combine(Hint, Country, GeographicArea, Kind, NationalSignificantNumber, NationalDestinationCode, SubscriberNumber);
}
