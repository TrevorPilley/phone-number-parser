#if NETSTANDARD2_0
namespace System.Linq
{
    internal static class EnumerableEx
    {
        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source) {
            return new HashSet<TSource>(source);
        }
    }
}
#endif
