namespace PhoneNumbers;

/// <summary>
/// The usage hint for a phone number.
/// </summary>
public enum PhoneNumberHint
{
    /// <summary>
    /// The phone number has no additional attribute.
    /// </summary>
    None = 0,

    /// <summary>
    /// Although the country allows local dialling (subscriber number only), the national
    /// destination code is closed and requires the full national number to be dialled
    /// due to number shortages.
    /// </summary>
    NationalDiallingOnly,

    /// <summary>
    /// The number is likely a virtual number.
    /// </summary>
    Virtual,

    /// <summary>
    /// The number is likely for a pager.
    /// </summary>
    Pager,

    /// <summary>
    /// The number is a freephone (toll-free) number.
    /// </summary>
    Freephone,

    /// <summary>
    /// The number is a premium rate number.
    /// </summary>
    PremiumRate,

    /// <summary>
    /// The number is a shared cost number.
    /// </summary>
    SharedCost,

    /// <summary>
    /// The number is a machine-to-machine (M2M) number.
    /// </summary>
    MachineToMachine,
}
