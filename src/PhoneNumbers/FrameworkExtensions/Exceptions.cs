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

    internal static class ArgumentOutOfRangeExceptionEx
    {
        public static void ThrowIfLessThan<T>(T value, T other, [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : IComparable<T>
        {
            if (value.CompareTo(other) < 0)
                ThrowLess(value, other, paramName);
        }

        [DoesNotReturn]
        private static void ThrowLess<T>(T value, T other, string? paramName) =>
            throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
    }
}
#endif

#pragma warning restore
