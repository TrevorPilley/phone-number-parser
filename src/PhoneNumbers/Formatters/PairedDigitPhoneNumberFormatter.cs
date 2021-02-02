using System.Text;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for phone numbers where the display format is 'xx xx xx xx',
    /// considering trunk prefix, area code and local number.
    /// </summary>
    internal sealed class PairedDigitPhoneNumberFormatter : PhoneNumberFormatter
    {
        private PairedDigitPhoneNumberFormatter()
        {
        }

        internal static PhoneNumberFormatter Instance { get; } = new PairedDigitPhoneNumberFormatter();

        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            var stringBuilder = new StringBuilder();

            var charsAdded = 0;

            static void Append(StringBuilder sb, ref int charsAdded, string? input)
            {
                for (var i = 0; i < input?.Length; i++)
                {
                    sb.Append(input[i]);

                    charsAdded++;

                    if (charsAdded % 2 == 0)
                    {
                        sb.Append(' ');
                    }
                }
            }

            Append(stringBuilder, ref charsAdded, phoneNumber.Country.TrunkPrefix);
            Append(stringBuilder, ref charsAdded, phoneNumber.NationalDestinationCode);
            Append(stringBuilder, ref charsAdded, phoneNumber.SubscriberNumber);

            if (stringBuilder[stringBuilder.Length - 1] == ' ')
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }

            return stringBuilder.ToString();
        }
    }
}
