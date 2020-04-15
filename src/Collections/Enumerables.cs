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
        /// Determines efficiently whether the enumerable has the provided count.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to test.</param>
        /// <param name="count">The count to find.</param>
        /// <returns>
        ///   <c>true</c> if the number of elements is <c>count</c>; otherwise, <c>false</c>.
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
            using (var enmrtr = source.GetEnumerator())
            {
                while (enmrtr.MoveNext() && checked(index++ < count)) { }
            }

            return index == count;
        }

        /// <summary>
        /// Partitions the enumerable on a specified predicate.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to partition.</param>
        /// <param name="partitioner">The predicate.</param>
        /// <param name="partitionProvider">The partition container provider.</param>
        /// <returns>A lazy enumerable</returns>
        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionIf<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<int, TElem, bool> partitioner,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            partitioner.CheckArgumentNull(nameof(partitioner));
            partitionProvider = partitionProvider
                ?? (list => new System.Collections.ObjectModel.ReadOnlyCollection<TElem>(list));
            using (var enmrtr = source.GetEnumerator())
            {
                var foundNextItem = enmrtr.MoveNext();
                while (foundNextItem)
                {
                    IReadOnlyCollection<TElem> partition;
                    do
                    {
                        foundNextItem = false;
                        var buffer = new List<TElem>();
                        var item = enmrtr.Current;
                        for (var index = 0; partitioner(index, item); ++index)
                        {
                            buffer.Add(item);
                            foundNextItem = enmrtr.MoveNext();
                            if (!foundNextItem) break;
                            item = enmrtr.Current;
                        }
                        partition = partitionProvider(buffer);
                        yield return partition;
                    } while (partition.Count == 0);
                }
            }
        }

        /// <summary>
        /// Partitions the enumerable by the specified size.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to partition.</param>
        /// <param name="count">The size of the partition.</param>
        /// <param name="partitionProvider">The partition container provider.</param>
        /// <returns>A lazy enumerable</returns>
        public static IEnumerable<IReadOnlyCollection<TElem>> PartitionBy<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            int count,
            Func<IList<TElem>, IReadOnlyCollection<TElem>> partitionProvider = null)
        {
            source.CheckArgumentNull(nameof(source));
            count.CheckArgumentIsGreater(nameof(count), 0);
            if (source is List<TElem> trueList)
                return trueList.PartitionBy(count, partitionProvider);
            return source.PartitionIf(
                (index, _) => index < count,
                partitionProvider);
        }

        /// <summary>
        /// Flattens the specified enumerable to every item available.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to flatten.</param>
        /// <param name="provider">The enumerable provider from the item.</param>
        /// <param name="mode">The flattening mode.</param>
        /// <returns>A lazy enumerable</returns>
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
        /// Flattens the specified enumerable which every item in itself is an enumerable.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to flatten.</param>
        /// <param name="mode">The flattening mode.</param>
        /// <returns>A lazy enumerable</returns>
        public static IEnumerable<TElem> Flatten<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            TreeTraversalMode mode = TreeTraversalMode.Depth)
            where TElem : IEnumerable<TElem>
        => source.Flatten(c => c, mode);

        /// <summary>
        /// Cycles the specified enumerable indefinitely or up to the specified limit if provided.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to cycle.</param>
        /// <param name="repeat">The repeating limit.</param>
        /// <returns>A lazy enumerable</returns>
        public static IEnumerable<TElem> Cycle<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            uint? repeat = null)
        {
            source.CheckArgumentNull(nameof(source));
            if (!source.Any() || repeat == 0u)
            {
                yield break;
            }

            var index = 0u;
            while (!repeat.HasValue || checked(index++ < repeat))
            {
                foreach (var item in source)
                {
                    yield return item;
                }
            }
        }

        /// <summary>
        /// Generates a shuffled enumerable.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to shuffle.</param>
        /// <param name="randomSource">The random source.</param>
        /// <param name="resultProvider">The shuffled container provider.</param>
        /// <returns>A new shuffled enumerable</returns>
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
        /// Gets a random item from the enumerable.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to take from.</param>
        /// <param name="randomSource">The random source.</param>
        /// <returns>A random item</returns>
        public static TElem GetRandom<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            Func<int, int> randomSource = null)
        {
            source.CheckArgumentNull(nameof(source));
            randomSource = randomSource ?? new Random().Next;
            return source.ElementAt(randomSource(source.Count()));
        }

        /// <summary>
        /// Tries to get the first element corresponding to the specified predicate.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to iterate through.</param>
        /// <param name="predicate">The predicat to test.</param>
        /// <param name="firstItem">The first item to be found.</param>
        /// <returns>
        ///   <c>true</c> if the specified predicate finds an item; otherwise, <c>false</c>.
        /// </returns>
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
        /// Tries to get the last element corresponding to the specified predicate.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to iterate through.</param>
        /// <param name="predicate">The predicate to test.</param>
        /// <param name="lastItem">The last item to be found.</param>
        /// <returns>
        ///   <c>true</c> if the specified predicate finds an item; otherwise, <c>false</c>.
        /// </returns>
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
        /// Tries to get a last single corresponding to the specified predicate.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to iterate through.</param>
        /// <param name="predicate">The predicate to test.</param>
        /// <param name="singleItem">The single item to be found.</param>
        /// <returns>
        ///   <c>true</c> if the specified predicate finds an item; otherwise, <c>false</c>.
        /// </returns>
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
        /// Groups en enumerable to a dictionary of partitions of new items.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <typeparam name="TKey">The type of the discriminator.</typeparam>
        /// <typeparam name="TValue">The type of the partition's item.</typeparam>
        /// <param name="source">The enumerable to partition.</param>
        /// <param name="keySelector">The discriminator selector.</param>
        /// <param name="valueSelector">The partition's item selector.</param>
        /// <param name="comparer">The discriminator's comparer.</param>
        /// <returns>A dictionary of partitions</returns>
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
        /// Groups en enumerable to a dictionary of partitions.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <typeparam name="TKey">The type of the discriminator.</typeparam>
        /// <param name="source">The enumerable to partition.</param>
        /// <param name="keySelector">The discriminator selector.</param>
        /// <param name="comparer">The discriminator's comparer.</param>
        /// <returns>A dictionary of partitions</returns>
        public static Dictionary<TKey, IEnumerable<TElem>> GroupToDictionary<TElem, TKey>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TKey> keySelector,
            IEqualityComparer<TKey> comparer = null)
        => source.GroupToDictionary(
            keySelector,
            DefaultDelegates.IdentityFunction<TElem>(),
            comparer);

        /// <summary>
        /// Gets the Fowler–Noll–Vo hash code.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to calculate.</param>
        /// <returns>The resulting hash code</returns>
        public static uint GetFNVHashCode<TElem>(
            [NotNull] this IEnumerable<TElem> source)
        {
            source.CheckArgumentNull(nameof(source));
            return source.Aggregate(
                Constants.FNV_OFFSET_BASIS,
                (hashCode, item) => (uint)(hashCode ^ item.GetHashCode()) * Constants.FNV_PRIME);
        }

        public static IEnumerable<TElem> SelectMany<TElem>(
            [NotNull] this IEnumerable<TElem> source)
            where TElem : IEnumerable<TElem>
            => source.SelectMany(elem => elem);

        public static IEnumerable<TResult> SelectMany<TElem, TResult>(
            [NotNull] this IEnumerable<TElem> source,
            [NotNull] Func<TElem, TElem, TResult> resultSelector)
            where TElem : IEnumerable<TElem>
            => source.SelectMany(elem => elem, resultSelector);

        /// <summary>
        /// Tries to get the aggregated element.
        /// </summary>
        /// <typeparam name="TElem">The type of the item in the enumerable.</typeparam>
        /// <param name="source">The enumerable to iterate through.</param>
        /// <param name="aggregatedItem">The aggregated item to be found.</param>
        /// <returns>
        ///   <c>true</c> if the specified source isn't empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool TryAggregate<TElem>(
            [NotNull] this IEnumerable<TElem> source,
            out TElem aggregatedItem)
            where TElem : IComparable<TElem>
        {
            source.CheckArgumentNull(nameof(source));
            using (var enmrtr = source.GetEnumerator())
            {
                aggregatedItem = default(TElem);
                if (!enmrtr.MoveNext()) return false;
                do
                {
                    var currentItem = enmrtr.Current;
                    if (aggregatedItem.CompareTo(currentItem) > 0)
                    {
                        aggregatedItem = enmrtr.Current;
                    }
                } while (enmrtr.MoveNext());
                return true;
            }
        }

        public static IEnumerable<TResult> Join<TElem, TKey, TResult>(
            [NotNull] this IEnumerable<TElem> outer,
            [NotNull] IEnumerable<TElem> inner,
            [NotNull] Func<TElem, TKey> keySelector,
            [NotNull] Func<TElem, TElem, TResult> resultSelector,
            EqualityComparer<TKey> keyComparer = null)
            => outer.Join(inner, keySelector, keySelector, resultSelector, keyComparer);

        public static IEnumerable<TResult> Join<TInner, TOuter, TResult>(
            [NotNull] this IEnumerable<TOuter> outer,
            [NotNull] IEnumerable<TInner> inner,
            [NotNull] Func<TOuter, TInner, bool> matcher,
            [NotNull] Func<TOuter, TInner, TResult> resultSelector)
        {
            outer.CheckArgumentNull(nameof(outer));
            inner.CheckArgumentNull(nameof(inner));
            matcher.CheckArgumentNull(nameof(matcher));
            resultSelector.CheckArgumentNull(nameof(resultSelector));
            foreach (var outerItem in outer)
            {
                foreach (var innerItem in inner)
                {
                    if (!matcher(outerItem, innerItem)) continue;
                    yield return resultSelector(outerItem, innerItem);
                }
            }
        }

        public static IEnumerable<TResult> Join<TElem, TResult>(
            [NotNull] this IEnumerable<TElem> outer,
            [NotNull] IEnumerable<TElem> inner,
            [NotNull] Func<TElem, TElem, TResult> resultSelector)
            where TElem : IEquatable<TElem>
            => outer.Join(inner, (o, i) => o.Equals(i), resultSelector);

        public static IEnumerable<TResult> GroupJoin<TElem, TKey, TResult>(
            [NotNull] this IEnumerable<TElem> outer,
            [NotNull] IEnumerable<TElem> inner,
            [NotNull] Func<TElem, TKey> keySelector,
            [NotNull] Func<TElem, IEnumerable<TElem>, TResult> resultSelector,
            EqualityComparer<TKey> keyComparer = null)
            => outer.GroupJoin(inner, keySelector, keySelector, resultSelector, keyComparer);

        public static IEnumerable<TResult> GroupJoin<TInner, TOuter, TResult>(
            [NotNull] this IEnumerable<TOuter> outer,
            [NotNull] IEnumerable<TInner> inner,
            [NotNull] Func<TOuter, TInner, bool> matcher,
            [NotNull] Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
        {
            outer.CheckArgumentNull(nameof(outer));
            inner.CheckArgumentNull(nameof(inner));
            matcher.CheckArgumentNull(nameof(matcher));
            resultSelector.CheckArgumentNull(nameof(resultSelector));
            foreach (var outerItem in outer)
            {
                yield return resultSelector(
                    outerItem,
                    inner.Where(innerItem => matcher(outerItem, innerItem)));
            }
        }

        public static IEnumerable<TResult> GroupJoin<TElem, TResult>(
            [NotNull] this IEnumerable<TElem> outer,
            [NotNull] IEnumerable<TElem> inner,
            [NotNull] Func<TElem, IEnumerable<TElem>, TResult> resultSelector)
            where TElem : IEquatable<TElem>
            => outer.GroupJoin(inner, (o, i) => o.Equals(i), resultSelector);
    }
}