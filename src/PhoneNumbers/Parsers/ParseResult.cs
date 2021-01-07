namespace PhoneNumbers.Parsers
{
    /// <summary>
    /// A class which represents the result of a phone number parse attempt.
    /// </summary>
    internal sealed class ParseResult
    {
        /// <summary>
        /// Gets the error which resulted caused the parse attempt to fail.
        /// </summary>
        public string? ParseError { get; private set; }

        /// <summary>
        /// Gets the <see cref="PhoneNumber"/> which was successfully parsed.
        /// </summary>
        public PhoneNumber? PhoneNumber { get; private set; }

        /// <summary>
        /// Creates a <see cref="ParseResult"/> which failed.
        /// </summary>
        /// <param name="parseError">The error which resulted caused the parse attempt to fail.</param>
        /// <returns>A <see cref="ParseResult"/> for the parse error.</returns>
        internal static ParseResult Failure(string parseError) =>
            new() { ParseError = parseError };

        /// <summary>
        /// Creates a <see cref="ParseResult"/> which succeded.
        /// </summary>
        /// <param name="phoneNumber">The <see cref="PhoneNumber"/> which was successfully parsed.</param>
        /// <returns>A <see cref="ParseResult"/> for the parse success.</returns>
        internal static ParseResult Success(PhoneNumber phoneNumber) =>
            new() { PhoneNumber = phoneNumber };

        /// <summary>
        /// Throws a <see cref="ParseException"/> with the parse error if the parse operation failed.
        /// </summary>
        internal void ThrowIfFailure()
        {
            if (ParseError != null)
            {
                throw new ParseException(ParseError);
            }
        }
    }
}
