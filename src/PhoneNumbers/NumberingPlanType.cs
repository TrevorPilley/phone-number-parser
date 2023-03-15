namespace PhoneNumbers;

/// <summary>
/// The types of numbering plan.
/// </summary>
public enum NumberingPlanType
{
    /// <summary>
    /// A closed numbering plan features fixed-length national destination codes and subscriber numbers
    ///  and where the national significant numbers NSN are used when dialling geographic numbers.
    /// </summary>
    Closed = 0,

    /// <summary>
    /// An open numbering plan has a variance in the length of the national destination codes, subscriber number, or both
    /// and where the national significant numbers NSN are not always used when dialling geographic numbers.
    /// </summary>
    Open,
}
