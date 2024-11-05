#if !NET8_0_OR_GREATER
namespace System.Collections.Generic
{
    using System.Collections.ObjectModel;

    internal static class CollectionExtensions
    {
        internal static ReadOnlyDictionary<TKey, TValue> AsReadOnly<TKey, TValue>(this IDictionary<TKey, TValue> dictionary) where TKey : notnull =>
            new ReadOnlyDictionary<TKey, TValue>(dictionary);
    }
}
#endif
