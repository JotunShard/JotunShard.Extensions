using JetBrains.Annotations;
using System;
using System.Collections;

namespace JotunShard.Extensions
{
    public static class Arguments
    {
        public static void CheckArgumentNull<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName)
            where TParam : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void CheckArgumentOutOfRange<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName, TParam min, TParam max)
            where TParam : IComparable
        {
            if (value.CompareTo(min) < 0 || value.CompareTo(max) > 0)
            {
                throw new ArgumentOutOfRangeException(paramName);
            }
        }

        public static void CheckArgumentOutOfRangeOrEqual<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName, TParam min, TParam max)
            where TParam : IComparable
        {
            if (value.CompareTo(min) <= 0 || value.CompareTo(max) >= 0)
            {
                throw new ArgumentOutOfRangeException(paramName);
            }
        }

        public static void CheckArgumentOutOfLimit<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            TParam limit,
            [NotNull] Func<int, int, bool> test)
            where TParam : IComparable
        {
            if (test(value.CompareTo(limit), 0))
            {
                throw new ArgumentOutOfRangeException(paramName);
            }
        }

        public static void CheckArgumentIsGreater<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            TParam limit)
            where TParam : IComparable
        => value.CheckArgumentOutOfLimit(paramName, limit, (a, b) => a <= b);

        public static void CheckArgumentIsGreaterOrEqual<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            TParam limit)
            where TParam : IComparable
        => value.CheckArgumentOutOfLimit(paramName, limit, (a, b) => a < b);

        public static void CheckArgumentIsLesser<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            TParam limit)
            where TParam : IComparable
        => value.CheckArgumentOutOfLimit(paramName, limit, (a, b) => a >= b);

        public static void CheckArgumentIsLesserOrEqual<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            TParam limit)
            where TParam : IComparable
        => value.CheckArgumentOutOfLimit(paramName, limit, (a, b) => a > b);

        public static void CheckArgumentTooLarge<TParam>(
            [NoEnumeration] this TParam value,
            [InvokerParameterName] string paramName,
            int size)
            where TParam : ICollection
        {
            if (value.Count > size)
            {
                throw new ArgumentOutOfRangeException(paramName);
            }
        }
    }
}