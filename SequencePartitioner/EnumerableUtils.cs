using System.Collections.Generic;

namespace CodeTests
{
    public static class EnumerableUtils
    {
        public static ISet<T> ToHashSet<T>(this IEnumerable<T> items) => new HashSet<T>(items);
    }
}