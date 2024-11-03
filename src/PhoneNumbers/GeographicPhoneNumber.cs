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
    /// </summary>
    /// <remarks>
    /// This is an indication based upon the data available for each country and could be an individual city or larger region such as a county.
    /// </remarks>
    public required string GeographicArea { get; init; }

    /// <inheritdoc/>
    public override PhoneNumberKind Kind =>
        PhoneNumberKind.GeographicPhoneNumber;

    /// <summary>
    /// Gets a value indicating whether the full national significant number must always be dialled even when the country
    /// allows local dialling (subscriber number only), often due to number shortages within the national destination code.
    /// </summary>
    /// <remarks>This property should never be used directly except from the NdcIsOptional extension method.</remarks>
    internal bool NationalDiallingOnly =>
        Hint == PhoneNumberHint.NationalDiallingOnly;

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
