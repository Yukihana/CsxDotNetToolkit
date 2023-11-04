using System.Collections.Generic;

namespace CSX.Toolkits.DotNet.Filtering;

public static class NullabilityExtensions
{
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> e)
    {
        foreach (var item in e)
        {
            if (item is T t)
                yield return t;
        }
    }
}