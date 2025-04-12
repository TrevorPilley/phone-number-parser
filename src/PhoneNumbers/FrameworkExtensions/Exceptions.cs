#pragma warning disable

#if !NET6_0_OR_GREATER
namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    internal static class ArgumentNullExceptionEx
    {
        public static void ThrowIfNull([NotNull] object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument is null)
            {
                Throw(paramName);
            }
        }

        [DoesNotReturn]
        private static void Throw(string? paramName) =>
            throw new ArgumentNullException(paramName);
    }
}
#endif

#if !NET8_0_OR_GREATER
namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    internal static class ArgumentExceptionEx
    {
        public static void ThrowIfNullOrWhiteSpace([NotNull] string? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                ThrowNullOrWhiteSpaceException(argument, paramName);
            }
        }

        [DoesNotReturn]
        private static void ThrowNullOrWhiteSpaceException(string? argument, string? paramName)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(argument, paramName);
#else
            ArgumentNullExceptionEx.ThrowIfNull(argument, paramName);
#endif
            throw new ArgumentException($"The value cannot be an empty string or composed entirely of whitespace. (Parameter '{paramName}')", paramName);
        }
    }
}
#endif

#pragma warning restore
