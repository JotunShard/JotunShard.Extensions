using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public class FilteredDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    {
        public IEnumerable<TKey> Keys => OriginalValues.Keys.Where(key => IsKeyFiltered(key));

        public IEnumerable<TValue> Values
            => OriginalValues.Where(item => IsKeyFiltered(item.Key)).Select(item => item.Value);

        public int Count => OriginalValues.Count(x => !IsKeyFiltered(x.Key));

        public TValue this[TKey key] => key != null && IsKeyFiltered(key)
            ? throw new KeyNotFoundException()
            : OriginalValues[key];

        public IDictionary<TKey, TValue> OriginalValues { get; private set; }

        public List<Func<TKey, bool>> Filters { get; private set; }

        public FilteredDictionary(IDictionary<TKey, TValue> originalValues, params Func<TKey, bool>[] filters)
        {
            OriginalValues = originalValues;
            Filters = filters.ToList();
        }

        public bool IsKeyFiltered(TKey key) => Filters.All(x => x(key));

        public Dictionary<TKey, TValue> ToDictionary()
        {
            var dict = new Dictionary<TKey, TValue>(OriginalValues.Count);
            foreach (var item in OriginalValues)
            {
                if (!IsKeyFiltered(item.Key))
                {
                    dict.Add(item.Key, item.Value);
                }
            }
            return dict;
        }

        public bool ContainsKey(TKey key)
            => IsKeyFiltered(key) && OriginalValues.ContainsKey(key);

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (!IsKeyFiltered(key))
            {
                value = default;
                return false;
            }
            return OriginalValues.TryGetValue(key, out value);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
            => OriginalValues.Where(item => IsKeyFiltered(item.Key)).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}