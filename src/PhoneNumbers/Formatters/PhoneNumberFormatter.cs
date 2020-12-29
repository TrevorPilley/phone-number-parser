using System;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// The default formatter for a <see cref="PhoneNumber"/>.
    /// </summary>
    internal class PhoneNumberFormatter
    {
        internal const string DefaultFormat = "I";

        /// <summary>
        /// Formats the <see cref="PhoneNumber"/> using the specified format.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <param name="format">The format string to use.</param>
        /// <exception cref="FormatException">Thrown if the format string is not valid.</exception>
        /// <returns>The string representation of the phone number as specified by the format.</returns>
        internal string Format(PhoneNumber phoneNumber, string format)
        {
            if (phoneNumber is null)
            {
                throw new ArgumentNullException(nameof(phoneNumber));
            }

            return format switch
            {
                "D" => FormatDisplay(phoneNumber),
                "I" => FormatInternational(phoneNumber),
                "N" => FormatNational(phoneNumber),
                _ => throw new FormatException($"{format} is not a supported format"),
            };
        }

        /// <summary>
        /// Gets the string representation of the phone number for display.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        protected virtual string FormatDisplay(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.CallingCode} {phoneNumber.AreaCode} {phoneNumber.LocalNumber}";

        /// <summary>
        /// Gets the string representation of the phone number for an international caller to use.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        protected virtual string FormatInternational(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.CallingCode}{phoneNumber.AreaCode}{phoneNumber.LocalNumber}";

        /// <summary>
        /// Gets the string representation of the phone number for national caller to use.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        protected virtual string FormatNational(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.AreaCode}{phoneNumber.LocalNumber}";
    }
}
