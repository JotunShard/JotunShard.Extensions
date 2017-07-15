using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Enumerables
    {
        private const uint
            FNV_OFFSET_BASIS = 2166136261u,
            FNV_PRIME = 16777619u;

        // TryFind

        public static bool HasCount<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int count)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreaterOrEqual(nameof(count), 0);
            if (source is ICollection<TElem> coll)
                return coll.Count == count;
            var index = 0;
            foreach (var item in source)
                if (index++ >= count)
                    break;
            return index == count;
        }

        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionIf<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<int, TElem, bool> partitioner,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            IReadOnlyCollection<TElem> Iterator(
                IEnumerator<TElem> enmrtr)
            {
                var partition = new List<TElem>();
                var index = 0;
                TElem item;
                do
                {
                    partition.Add(item = enmrtr.Current);
                } while (partitioner(++index, item) && enmrtr.MoveNext());
                return partitionProvider(partition);
            }

            source.CheckArgumentNull(nameof(source));
            partitioner.CheckArgumentNull(nameof(partitioner));
            partitionProvider = partitionProvider
                ?? (list => new ReadOnlyCollection<TElem>(list));
            using (var enmrtr = source.GetEnumerator())
                while (enmrtr.MoveNext())
                    yield return Iterator(enmrtr);
        }

        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionBy<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int count,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreater(nameof(count), 0);
            return source.PartitionIf(
                (index, item) => index < count,
                partitionProvider);
        }

        public static IEnumerable<TElem> Flatten<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, IEnumerable<TElem>> provider,
            TreeTraversalMode mode = TreeTraversalMode.Depth)
        {
            source.CheckArgumentNull(nameof(source));
            provider.CheckArgumentNull(nameof(provider));
            switch (mode)
            {
                case TreeTraversalMode.Depth:
                    foreach (var item in source)
                    {
                        yield return item;
                        foreach (var subItem in provider(item)
                            .Flatten(provider, mode))
                            yield return subItem;
                    }
                    break;

                case TreeTraversalMode.Breadth:
                    foreach (var item in source)
                        yield return item;
                    foreach (var item in source)
                        foreach (var subItem in provider(item)
                            .Flatten(provider, mode))
                            yield return subItem;
                    break;
            }
        }

        public static IEnumerable<TElem> Flatten<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            TreeTraversalMode mode = TreeTraversalMode.Depth)
            where TElem : IEnumerable<TElem>
        => source.Flatten(c => c, mode);

        public static IEnumerable<TElem> Cycle<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int? repeat = null)
        {
            source.CheckArgumentNull(nameof(source));
            repeat?.CheckArgumentIsGreaterOrEqual(nameof(repeat), 0);
            if (!source.Any() || repeat == 0)
                yield break;
            var index = 0;
            while (!repeat.HasValue || index++ < repeat)
                foreach (var item in source)
                    yield return item;
        }

        public static IEnumerable<TElem> ToShuffled<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            Func<int, int, int> randomSource = null,
            Func<IList<TElem>, IEnumerable<TElem>> resultProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            randomSource = randomSource ?? new Random().Next;
            resultProvider = resultProvider
                ?? (list => new ReadOnlyCollection<TElem>(list));
            var result = new List<TElem>();
            foreach (var item in source)
            {
                var index = randomSource(0, result.Count + 1);
                if (index == result.Count)
                    result.Add(item);
                else
                {
                    result.Add(result[index]);
                    result[index] = item;
                }
            }
            return resultProvider(result);
        }

        public static TElem GetRandom<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            Func<int, int> randomSource = null)
        {
            source.CheckArgumentNull(nameof(source));
            randomSource = randomSource ?? new Random().Next;
            return source.ElementAt(randomSource(source.Count()));
        }

        public static bool TryGetFirst<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, bool> predicate,
            out TElem firstItem)
        {
            source.CheckArgumentNull(nameof(source));
            predicate.CheckArgumentNull(nameof(predicate));
            firstItem = default(TElem);
            foreach (var item in source)
                if (predicate(item))
                {
                    firstItem = item;
                    return true;
                }
            return false;
        }

        public static bool TryGetLast<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, bool> predicate,
            out TElem lastItem)
        {
            source.CheckArgumentNull(nameof(source));
            predicate.CheckArgumentNull(nameof(predicate));
            lastItem = default(TElem);
            var found = false;
            foreach (var item in source)
                if (predicate(item))
                {
                    found = true;
                    lastItem = item;
                }
            return found;
        }

        public static bool TryGetSingle<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, bool> predicate,
            out TElem singleItem)
        {
            source.CheckArgumentNull(nameof(source));
            predicate.CheckArgumentNull(nameof(predicate));
            singleItem = default(TElem);
            var found = false;
            foreach (var item in source)
                if (predicate(item))
                {
                    if (found) return false;
                    found = true;
                    singleItem = item;
                }
            return found;
        }

        public static Dictionary<TKey, IEnumerable<TValue>> GroupToDictionary<TElem, TKey, TValue>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TKey> keySelector,
            [NotNull] Func<TElem, TValue> valueSelector,
            IEqualityComparer<TKey> comparer = null)
        {
            source.CheckArgumentNull(nameof(source));
            keySelector.CheckArgumentNull(nameof(keySelector));
            valueSelector.CheckArgumentNull(nameof(valueSelector));
            var result = new Dictionary<TKey, IEnumerable<TValue>>(comparer);
            foreach (var item in source)
            {
                var key = keySelector(item);
                var values = Enumerable.Repeat(valueSelector(item), 1);
                if (result.TryGetValue(key, out IEnumerable<TValue> oldValues))
                    values = oldValues.Union(values);
                result[key] = values;
            }
            return result;
        }

        public static Dictionary<TKey, IEnumerable<TElem>> GroupToDictionary<TElem, TKey>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TKey> keySelector,
            IEqualityComparer<TKey> comparer = null)
        => source.GroupToDictionary(
            keySelector,
            DefaultDelegates<TElem>.IdentityFunction,
            comparer);

        public static uint GetFNVHashCode<TElem>(
            [NotNull] this IEnumerable<TElem> source)
        {
            source.CheckArgumentNull(nameof(source));
            return source.Aggregate(
                FNV_OFFSET_BASIS,
                (hashCode, item) => (uint)(hashCode ^ item.GetHashCode()) * FNV_PRIME);
        }
    }
}