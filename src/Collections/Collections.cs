using JetBrains.Annotations;
using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Collections
    {
        /// <summary>
        /// Determines whether a collection contains any elements.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection to check for emptiness.</param>
        /// <returns>
        ///   <c>true</c> if the collection contains any elements; otherwise, <c>false</c>.
        /// </returns>
        public static bool Any<TElem>(
            [NotNull] this ICollection<TElem> coll)
        {
            coll.CheckArgumentNull(nameof(coll));
            return coll.Count != 0;
        }

        /// <summary>
        /// Adds the elements of the specified enumerable to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to add the items.</param>
        /// <param name="items">The enumerable whose elements should be added to the collection.</param>
        public static void AddAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] IEnumerable<TElem> items)
        {
            if (coll is List<TElem> trueList)
            {
                trueList.AddRange(items);
                return;
            }
            coll.CheckArgumentNull(nameof(coll));
            items.CheckArgumentNull(nameof(items));
            foreach (var item in items)
            {
                coll.Add(item);
            }
        }

        /// <summary>
        /// Adds the elements of the specified variadic array to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to add the items.</param>
        /// <param name="items">The variadic array whose elements should be added to the collection.</param>
        public static void AddAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] params TElem[] items)
            => coll.AddAll(items.AsEnumerable());

        /// <summary>
        /// Removes all the elements of the specified enumerable to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to remove the items.</param>
        /// <param name="items">The enumerable whose elements should be removed to the collection.</param>
        public static void RemoveAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] IEnumerable<TElem> items)
        {
            coll.CheckArgumentNull(nameof(coll));
            items.CheckArgumentNull(nameof(items));
            foreach (var item in items.ToList())
            {
                coll.Remove(item);
            }
        }

        /// <summary>
        /// Removes all the elements of the specified variadic array to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to remove the items.</param>
        /// <param name="items">The variadic array whose elements should be removed to the collection.</param>
        public static void RemoveAll<TElem>(
            [NotNull] this ICollection<TElem> coll,
            [NotNull] params TElem[] items)
            => coll.RemoveAll(items.AsEnumerable());
    }
}