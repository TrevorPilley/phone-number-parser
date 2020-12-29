namespace PhoneNumbers.Parsers
{
    internal sealed class ParseResult
    {
        internal string? ParseError { get; private set; }
        internal PhoneNumber? PhoneNumber { get; private set; }

        internal static ParseResult Failure(string parseError) =>
            new ParseResult { ParseError = parseError };

        internal static ParseResult Success(PhoneNumber phoneNumber) =>
            new ParseResult { PhoneNumber = phoneNumber };

        internal void ThrowIfFailure()
        {
            if (ParseError != null)
            {
                throw new ParseException(ParseError);
            }
        }
    }
}
