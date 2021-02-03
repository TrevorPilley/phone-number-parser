using System;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// The default formatter for a <see cref="PhoneNumber"/>.
    /// </summary>
    internal class PhoneNumberFormatter
    {
        internal const string DefaultFormat = "E";

        /// <summary>
        /// Initialises a new instance of the <see cref="PhoneNumberFormatter"/> class.
        /// </summary>
        protected PhoneNumberFormatter()
        {
        }

        /// <summary>
        /// Gets the default <see cref="PhoneNumberFormatter"/>.
        /// </summary>
        internal static PhoneNumberFormatter Default { get; } = new();

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
                DefaultFormat or "I" => FormatE164(phoneNumber),
                "N" => FormatNational(phoneNumber),
                _ => throw new FormatException($"{format} is not a supported format"),
            };
        }

        /// <summary>
        /// Gets the string representation of the phone number for display.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        protected virtual string FormatDisplay(PhoneNumber phoneNumber)
        {
            if (phoneNumber.Country.TrunkPrefix is not null)
            {
                if (phoneNumber.NationalDestinationCode is not null)
                {
                    return $"{phoneNumber.Country.CallingCode} ({phoneNumber.Country.TrunkPrefix}) {phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
                }

                return $"{phoneNumber.Country.CallingCode} ({phoneNumber.Country.TrunkPrefix}) {phoneNumber.SubscriberNumber}";
            }

            if (phoneNumber.NationalDestinationCode is not null)
            {
                return $"{phoneNumber.Country.CallingCode} {phoneNumber.NationalDestinationCode} {phoneNumber.SubscriberNumber}";
            }

            return $"{phoneNumber.Country.CallingCode} {phoneNumber.SubscriberNumber}";
        }

        /// <summary>
        /// Gets the string representation of the phone number in E.164 format.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        private static string FormatE164(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.CallingCode}{phoneNumber.NationalSignificantNumber}";

        /// <summary>
        /// Gets the string representation of the phone number for national caller to use.
        /// </summary>
        /// <param name="phoneNumber">The phone number to format.</param>
        /// <returns>The string representation of the phone number.</returns>
        private static string FormatNational(PhoneNumber phoneNumber) =>
            $"{phoneNumber.Country.TrunkPrefix}{phoneNumber.NationalSignificantNumber}";
    }
}
