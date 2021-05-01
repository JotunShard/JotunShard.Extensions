using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Collections
    {
        /// <summary>
        /// Adds the elements of the specified enumerable to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to add the items.</param>
        /// <param name="items">The enumerable whose elements should be added to the collection.</param>
        public static void AddAll<TElem>(
            this ICollection<TElem> coll,
            IEnumerable<TElem> items)
        {
            coll.CheckArgumentNull(nameof(coll));
            if (coll is List<TElem> trueList)
            {
                trueList.AddRange(items);
                return;
            }
            items.CheckArgumentNull(nameof(items));
            if (ReferenceEquals(coll, items))
            {
                items = items.ToList();
            }
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
            this ICollection<TElem> coll,
            params TElem[] items)
            => coll.AddAll(items.AsEnumerable());

        /// <summary>
        /// Removes all the elements of the specified enumerable to the collection.
        /// </summary>
        /// <typeparam name="TElem">The type of the elements of <c>coll</c>.</typeparam>
        /// <param name="coll">The collection on which to remove the items.</param>
        /// <param name="items">The enumerable whose elements should be removed to the collection.</param>
        public static void RemoveAll<TElem>(
            this ICollection<TElem> coll,
            IEnumerable<TElem> items)
        {
            coll.CheckArgumentNull(nameof(coll));
            items.CheckArgumentNull(nameof(items));
            if (ReferenceEquals(coll, items))
            {
                items = items.ToList();
            }
            foreach (var item in items)
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
            this ICollection<TElem> coll,
            params TElem[] items)
            => coll.RemoveAll(items.AsEnumerable());
    }
}