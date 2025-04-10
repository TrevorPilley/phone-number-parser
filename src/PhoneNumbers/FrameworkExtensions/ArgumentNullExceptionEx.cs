#if !NET6_0_OR_GREATER
namespace System
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    internal static class ArgumentNullExceptionEx
    {
        /// <summary>Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.</summary>
        /// <param name="argument">The reference type argument to validate as non-null.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="argument"/> corresponds.</param>
        public static void ThrowIfNull([NotNull] object? argument, [CallerArgumentExpression("argument")] string? paramName = null)
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
