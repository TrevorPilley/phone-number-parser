#pragma warning disable S3261 // Remove this empty namespace.
#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace System.Diagnostics.CodeAnalysis
{
    #if NETSTANDARD2_0

    /// <summary>Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.</summary>
    /// <remarks>https://github.com/dotnet/runtime/blob/main/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/NullableAttributes.cs</remarks>
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
    internal sealed class NotNullWhenAttribute : Attribute
    {
        /// <summary>Initializes the attribute with the specified return value condition.</summary>
        /// <param name="returnValue">
        /// The return value condition. If the method returns this value, the associated parameter will not be null.
        /// </param>
        public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

        /// <summary>Gets the return value condition.</summary>
        public bool ReturnValue { get; }
    }

    /// <summary>Specifies that an output will not be null even if the corresponding type allows it. Specifies that an input argument was not null when the call returns.</summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
    internal sealed class NotNullAttribute : Attribute { }

    #endif //NETSTANDARD2_0
}

namespace System.Runtime.CompilerServices
{
    #if NETSTANDARD2_0 || NETSTANDARD2_1

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    internal sealed class CallerArgumentExpressionAttribute : Attribute
    {
        public CallerArgumentExpressionAttribute(string parameterName)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; }
    }

    # endif //NETSTANDARD2_0 || NETSTANDARD2_1

    #if !NET5_0_OR_GREATER

    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata.
    /// This class should not be used by developers in source code.
    /// </summary>
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    internal static class IsExternalInit
    {
    }

    #endif //!NET5_0_OR_GREATER

    #if !NET7_0_OR_GREATER

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class RequiredMemberAttribute : Attribute {}

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    internal sealed class CompilerFeatureRequiredAttribute : Attribute
    {
        public CompilerFeatureRequiredAttribute(string featureName)
        {
            FeatureName = featureName;
        }

        public string FeatureName { get; }
        public bool   IsOptional  { get; init; }

        public const string RefStructs      = nameof(RefStructs);
        public const string RequiredMembers = nameof(RequiredMembers);
    }

    #endif //!NET7_0_OR_GREATER
}

namespace PhoneNumbers
{
    internal static partial class PolyfillMembers
    {
        #if !NET8_0_OR_GREATER

        internal static System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) where TKey : notnull =>
            new System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>(dictionary);

        extension<T>(System.Collections.ObjectModel.ReadOnlyCollection<T> target)
        {
            internal static System.Collections.ObjectModel.ReadOnlyCollection<T> Empty
            {
                get => EmptyReadOnlyCollection<T>.Instance;
            }
        }

        extension<TKey, TValue>(System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> target) where TKey : notnull
        {
            internal static System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> Empty
            {
                get => EmptyReadOnlyDictionary<TKey, TValue>.Instance;
            }
        }

        #endif //!NET8_0_OR_GREATER

        #if NETSTANDARD2_0

        internal static int IndexOf(this string target, char value, System.StringComparison comparisonType)
        {
            return target.IndexOf(value.ToString(), comparisonType);
        }

        internal static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source) =>
            new HashSet<TSource>(source);

        #endif //NETSTANDARD2_0

        #if !NET7_0_OR_GREATER

        extension(ArgumentException)
        {
            internal static void ThrowIfNullOrWhiteSpace([System.Diagnostics.CodeAnalysis.NotNull] string? argument, [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(argument))] string? paramName = null)
            {
                if (argument is null)
                {
                    throw new ArgumentNullException(paramName);
                }

                if (string.IsNullOrWhiteSpace(argument))
                {
                    throw new ArgumentException("String cannot be empty or whitespace.", paramName);
                }
            }
        }

        extension(ArgumentNullException)
        {
            internal static void ThrowIfNull([System.Diagnostics.CodeAnalysis.NotNull] object? argument, [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(argument))] string? paramName = null)
            {
                if (argument is null)
                {
                    throw new ArgumentNullException(paramName);
                }
            }
        }

        extension(ArgumentOutOfRangeException)
        {
            internal static void ThrowIfLessThan<T>(T value, T other, [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(value))] string? paramName = null)
                where T : IComparable<T>
            {
                if (value.CompareTo(other) < 0)
                    throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be less than '{other}'.");
            }
        }

        #endif //!NET7_0_OR_GREATER
    }

    #if !NET8_OR_GREATER

    file static class EmptyReadOnlyCollection<T>
    {
        public static readonly System.Collections.ObjectModel.ReadOnlyCollection<T> Instance = new(System.Array.Empty<T>());
    }

    file static class EmptyReadOnlyDictionary<TKey, TValue> where TKey : notnull
    {
        public static readonly System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> Instance = new(new Dictionary<TKey, TValue>());
    }

    #endif //!NET8_OR_GREATER

}
#pragma warning restore IDE0130 // Namespace does not match folder structure
#pragma warning restore S3261 // Remove this empty namespace.
