using System;
using Regex = System.Text.RegularExpressions.Regex;

namespace JotunShard.Extensions
{
    public static class Strings
    {
        public static bool IsNullOrEmpty(
            this string value)
            => string.IsNullOrEmpty(value);

        public static bool IsNullOrWhiteSpace(
            this string value)
            => string.IsNullOrWhiteSpace(value);

        public static string FormatWith(
            this string format,
            params object[] args)
            => string.Format(format, args);

        private static string Side(
            string value,
            int length,
            Func<string, int, string> slicer)
        {
            value.CheckArgumentNull(nameof(value));
            if (value.Length * length == 0)
            {
                return string.Empty;
            }

            if (value.Length <= Math.Abs(length))
            {
                return value;
            }

            if (length < 0)
            {
                length += value.Length;
            }

            return slicer(value, length);
        }

        public static string Left(
            this string value,
            int length)
            => Side(value, length, (v, n) => v.Substring(0, n));

        public static string Right(
            this string value,
            int length)
            => Side(value, length, (v, n) => v.Substring(v.Length - n));

        public static bool Match(
            this string value,
            string pattern)
            => Regex.IsMatch(value, pattern);

        public static string EnsureEndsWith(
            this string target,
            string value,
            StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            target.CheckArgumentNull(nameof(target));
            return target.EndsWith(value, comparisonType) ? target : target + value;
        }

        public static string EnsureStartsWith(
            this string target,
            string value,
            StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            target.CheckArgumentNull(nameof(target));
            return target.StartsWith(value, comparisonType) ? target : value + target;
        }

        public static string Reverse(
            this string value)
        {
            value.CheckArgumentNull(nameof(value));
            var arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string SubstringFollowing(
            this string value,
            string term,
            int? length = null)
        {
            value.CheckArgumentNull(nameof(value));
            term.CheckArgumentNull(nameof(term));
            var startIndex = value.IndexOf(term);
            return length.HasValue
                ? value.Substring(startIndex, length.Value)
                : value.Substring(startIndex);
        }

        public static string SubstringPreceding(
            this string value,
            string term,
            int? length = null)
        {
            value.CheckArgumentNull(nameof(value));
            term.CheckArgumentNull(nameof(term));
            var termIndex = value.LastIndexOf(term);
            if (termIndex < 0) throw new ArgumentOutOfRangeException(nameof(term));
            var endIndex = termIndex + Math.Max(term.Length - 1, 0);
            return length.HasValue
                ? value.Substring(endIndex - length.Value, length.Value)
                : value.Substring(0, endIndex + 1);
        }

        public static string DefaultIfEmpty(
            this string value,
            string defaultValue,
            bool ignoreWhiteSpace = false)
            => (ignoreWhiteSpace
                ? string.IsNullOrWhiteSpace(value)
                : string.IsNullOrEmpty(value))
                ? defaultValue
                : value;
    }
}