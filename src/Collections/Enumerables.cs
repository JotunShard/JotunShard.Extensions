using JetBrains.Annotations;
using System;
using System.Collections.Generic;

using System.Linq;

namespace JotunShard.Extensions
{
    public static class Enumerables
    {
        // TryFind

        /// <summary>
        /// Determines whether the specified count has count.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <returns>
        ///   <c>true</c> if the specified count has count; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasCount<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int count)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreaterOrEqual(nameof(count), 0);
            if (source is ICollection<TElem> coll)
            {
                return coll.Count == count;
            }

            var index = 0;
            foreach (var item in source)
            {
                if (index++ >= count)
                {
                    break;
                }
            }

            return index == count;
        }

        /// <summary>
        /// Partitions if.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="partitioner">The partitioner.</param>
        /// <param name="partitionProvider">The partition provider.</param>
        /// <returns></returns>
        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionIf<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<int, TElem, bool> partitioner,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            IReadOnlyCollection<TElem> PartitionBuilder(
                IEnumerator<TElem> enmrtr)
            {
                var partition = new List<TElem>();
                var index = 0;
                TElem item;
                do
                {
                    item = enmrtr.Current;
                    partition.Add(item);
                } while (partitioner(++index, item) && enmrtr.MoveNext());
                return partitionProvider(partition);
            }

            source.CheckArgumentNull(nameof(source));
            partitioner.CheckArgumentNull(nameof(partitioner));
            partitionProvider = partitionProvider
                ?? (list => new System.Collections.ObjectModel.ReadOnlyCollection<TElem>(list));
            using (var enmrtr = source.GetEnumerator())
            {
                while (enmrtr.MoveNext())
                {
                    yield return PartitionBuilder(enmrtr);
                }
            }
        }

        /// <summary>
        /// Partitions the by.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <param name="partitionProvider">The partition provider.</param>
        /// <returns></returns>
        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionBy<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int count,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreater(nameof(count), 0);
            return source.PartitionIf(
                (index, _) => index < count,
                partitionProvider);
        }

        /// <summary>
        /// Flattens the specified provider.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="mode">The mode.</param>
        /// <returns></returns>
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
                        {
                            yield return subItem;
                        }
                    }
                    break;

                case TreeTraversalMode.Breadth:
                    foreach (var item in source)
                    {
                        yield return item;
                    }

                    foreach (var item in source)
                    {
                        foreach (var subItem in provider(item)
                            .Flatten(provider, mode))
                        {
                            yield return subItem;
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// Flattens the specified mode.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="mode">The mode.</param>
        /// <returns></returns>
        public static IEnumerable<TElem> Flatten<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            TreeTraversalMode mode = TreeTraversalMode.Depth)
            where TElem : IEnumerable<TElem>
        => source.Flatten(c => c, mode);

        /// <summary>
        /// Cycles the specified repeat.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="repeat">The repeat.</param>
        /// <returns></returns>
        public static IEnumerable<TElem> Cycle<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int? repeat = null)
        {
            source.CheckArgumentNull(nameof(source));
            repeat?.CheckArgumentIsGreaterOrEqual(nameof(repeat), 0);
            if (!source.Any() || repeat == 0)
            {
                yield break;
            }

            var index = 0;
            while (!repeat.HasValue || index++ < repeat)
            {
                foreach (var item in source)
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// To the shuffled.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="randomSource">The random source.</param>
        /// <param name="resultProvider">The result provider.</param>
        /// <returns></returns>
        public static IEnumerable<TElem> ToShuffled<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            Func<int, int, int> randomSource = null,
            Func<IList<TElem>, IEnumerable<TElem>> resultProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            randomSource = randomSource ?? new Random().Next;
            resultProvider = resultProvider
                ?? (list => new System.Collections.ObjectModel.ReadOnlyCollection<TElem>(list));
            var result = new List<TElem>();
            foreach (var item in source)
            {
                var index = randomSource(0, result.Count + 1);
                if (index == result.Count)
                {
                    result.Add(item);
                }
                else
                {
                    result.Add(result[index]);
                    result[index] = item;
                }
            }
            return resultProvider(result);
        }

        /// <summary>
        /// Gets the random.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="randomSource">The random source.</param>
        /// <returns></returns>
        public static TElem GetRandom<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            Func<int, int> randomSource = null)
        {
            source.CheckArgumentNull(nameof(source));
            randomSource = randomSource ?? new Random().Next;
            return source.ElementAt(randomSource(source.Count()));
        }

        /// <summary>
        /// Tries the get first.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="firstItem">The first item.</param>
        /// <returns></returns>
        public static bool TryGetFirst<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, bool> predicate,
            out TElem firstItem)
        {
            source.CheckArgumentNull(nameof(source));
            predicate.CheckArgumentNull(nameof(predicate));
            firstItem = default(TElem);
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    firstItem = item;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Tries the get last.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="lastItem">The last item.</param>
        /// <returns></returns>
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
            {
                if (predicate(item))
                {
                    found = true;
                    lastItem = item;
                }
            }

            return found;
        }

        /// <summary>
        /// Tries the get single.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="singleItem">The single item.</param>
        /// <returns></returns>
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
            {
                if (predicate(item))
                {
                    if (found)
                    {
                        return false;
                    }

                    found = true;
                    singleItem = item;
                }
            }

            return found;
        }

        /// <summary>
        /// Groups to dictionary.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="valueSelector">The value selector.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns></returns>
        public static Dictionary<TKey, IEnumerable<TValue>> GroupToDictionary<TElem, TKey, TValue>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TKey> keySelector,
            [NotNull] Func<TElem, TValue> valueSelector,
            IEqualityComparer<TKey> comparer = null)
        {
            var result = new Dictionary<TKey, IEnumerable<TValue>>(comparer);
            result.AddAll(source.GroupBy(
                keySelector,
                valueSelector,
                (key, coll) => new KeyValuePair<TKey, IEnumerable<TValue>>(key, coll),
                comparer));
            return result;
        }

        /// <summary>
        /// Groups to dictionary.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="keySelector">The key selector.</param>
        /// <param name="comparer">The comparer.</param>
        /// <returns></returns>
        public static Dictionary<TKey, IEnumerable<TElem>> GroupToDictionary<TElem, TKey>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TKey> keySelector,
            IEqualityComparer<TKey> comparer = null)
        => source.GroupToDictionary(
            keySelector,
            DefaultDelegates<TElem>.IdentityFunction,
            comparer);

        /// <summary>
        /// Gets the FNV hash code.
        /// </summary>
        /// <typeparam name="TElem">The type of the elem.</typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static uint GetFNVHashCode<TElem>(
            [NotNull] this IEnumerable<TElem> source)
        {
            source.CheckArgumentNull(nameof(source));
            return source.Aggregate(
                Constants.FNV_OFFSET_BASIS,
                (hashCode, item) => (uint)(hashCode ^ item.GetHashCode()) * Constants.FNV_PRIME);
        }
    }
}