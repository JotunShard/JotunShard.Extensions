using JetBrains.Annotations;
using System;

namespace JotunShard.Extensions
{
    public static class Comparables
    {
        public static bool Between<TValue>(
            [NotNull] this IComparable<TValue> comparable,
            TValue lowerValue,
            TValue upperValue)
        {
            comparable.CheckArgumentNull(nameof(comparable));
            return comparable.CompareTo(lowerValue) > 0
                && comparable.CompareTo(upperValue) < 0;
        }

        public static bool BetweenOrEqual<TValue>(
            [NotNull] this IComparable<TValue> comparable,
            TValue lowerValue,
            TValue upperValue)
        {
            comparable.CheckArgumentNull(nameof(comparable));
            return comparable.CompareTo(lowerValue) >= 0
                && comparable.CompareTo(upperValue) <= 0;
        }
    }
}