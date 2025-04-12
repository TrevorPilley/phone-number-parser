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
