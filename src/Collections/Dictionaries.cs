using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Dictionaries
    {
        public static IDictionary<TKey, TValue> DefaultIfEmpty<TKey, TValue>(
            [NotNull] this IDictionary<TKey, TValue> source,
            TKey key = default(TKey),
            TValue value = default(TValue))
        {
            source.CheckArgumentNull(nameof(source));
            return source.Count != 0
                ? source
                : new Dictionary<TKey, TValue>(1)
                {
                    [key] = value,
                };
        }

        public static IDictionary<TKey, TValue> DefaultIfEmpty<TKey, TValue>(
            [NotNull] this IDictionary<TKey, TValue> source,
            KeyValuePair<TKey, TValue> pair = default(KeyValuePair<TKey, TValue>))
            => source.DefaultIfEmpty(pair.Key, pair.Value);

        public static IEnumerable<KeyValuePair<TKey, TResult>> Join<TKey, TValue, TResult>(
            [NotNull] this IEnumerable<KeyValuePair<TKey, TValue>> outer,
            [NotNull] IEnumerable<KeyValuePair<TKey, TValue>> inner,
            [NotNull] Func<TKey, TValue, TValue, KeyValuePair<TKey, TResult>> resultSelector,
            EqualityComparer<TKey> keyComparer = null)
            => outer.Join(inner, o => o.Key, i => i.Key,
                (o, i) => resultSelector(o.Key, o.Value, i.Value), keyComparer);

        public static IEnumerable<KeyValuePair<TKey, TResult>> GroupJoin<TKey, TValue, TResult>(
            [NotNull] this IEnumerable<KeyValuePair<TKey, TValue>> outer,
            [NotNull] IEnumerable<KeyValuePair<TKey, TValue>> inner,
            [NotNull] Func<TKey, TValue, IEnumerable<TValue>, KeyValuePair<TKey, TResult>> resultSelector,
            EqualityComparer<TKey> keyComparer = null)
            => outer.GroupJoin(inner, o => o.Key, i => i.Key,
                (o, i) => resultSelector(o.Key, o.Value, i.Select(ii => ii.Value)), keyComparer);

        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(
            [NotNull] this IEnumerable<KeyValuePair<TKey, TValue>> source,
            IEqualityComparer<TKey> comparer = null)
        {
            if (!(source is Dictionary<TKey, TValue> dict))
            {
                return source.ToDictionary(kv => kv.Key, kv => kv.Value, comparer);
            }
            if (comparer != null && !dict.Comparer.Equals(comparer))
            {
                dict = new Dictionary<TKey, TValue>(dict, comparer);
            }
            return dict;
        }
    }
}