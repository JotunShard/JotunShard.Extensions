using JetBrains.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Dictionaries
    {
        public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(
            [NotNull] this IEnumerable<KeyValuePair<TKey, TValue>> values,
            IEqualityComparer<TKey> comparer = null)
        {
            values.CheckArgumentNull(nameof(values));
            if (values is Dictionary<TKey, TValue> dict)
            {
                return dict.Comparer.Equals(comparer)
                   ? dict
                   : new Dictionary<TKey, TValue>(dict, comparer);
            }

            return values.ToDictionary(kv => kv.Key, kv => kv.Value, comparer);
        }

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
    }
}