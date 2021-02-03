using System.Text;

namespace PhoneNumbers.Formatters
{
    /// <summary>
    /// A <see cref="PhoneNumberFormatter"/> for phone numbers where the display format is grouped digits
    /// considering trunk prefix, area code and local number.
    /// </summary>
    internal sealed class GroupedDigitPhoneNumberFormatter : PhoneNumberFormatter
    {
        private readonly int _charsPerGroup;
        private readonly char _groupSeparator;

        internal static PhoneNumberFormatter Spaced2Digits { get; } = new GroupedDigitPhoneNumberFormatter(2, ' ');

        internal static PhoneNumberFormatter Spaced3Digits { get; } = new GroupedDigitPhoneNumberFormatter(3, ' ');

        internal static PhoneNumberFormatter Spaced4Digits { get; } = new GroupedDigitPhoneNumberFormatter(4, ' ');

        private GroupedDigitPhoneNumberFormatter(int charsPerGroup, char groupSeparator) =>
            (_charsPerGroup, _groupSeparator) = (charsPerGroup, groupSeparator);

        /// <inheritdoc/>
        protected override string FormatDisplay(PhoneNumber phoneNumber)
        {
            var stringBuilder = new StringBuilder();

            var charsAdded = 0;

            void Append(StringBuilder sb, ref int charsAdded, string? input)
            {
                for (var i = 0; i < input?.Length; i++)
                {
                    sb.Append(input[i]);

                    charsAdded++;

                    if (charsAdded % _charsPerGroup == 0)
                    {
                        sb.Append(_groupSeparator);
                    }
                }
            }

            Append(stringBuilder, ref charsAdded, phoneNumber.Country.TrunkPrefix);
            Append(stringBuilder, ref charsAdded, phoneNumber.NationalDestinationCode);
            Append(stringBuilder, ref charsAdded, phoneNumber.SubscriberNumber);

            if (stringBuilder[stringBuilder.Length - 1] == _groupSeparator)
            {
                stringBuilder.Remove(stringBuilder.Length - 1, 1);
            }

            return stringBuilder.ToString();
        }
    }
}
