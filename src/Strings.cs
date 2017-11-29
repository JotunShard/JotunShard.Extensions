using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [StringFormatMethod("format")]
        public static string FormatWith(
            [NotNull] this string format,
            params object[] args)
            => string.Format(format, args);

        private static string Side(
            string value,
            int length,
            Func<string, int, string> slicer)
        {
            value.CheckArgumentNull(nameof(value));
            if (value.Length * length == 0) return string.Empty;
            if (value.Length <= Math.Abs(length)) return value;
            if (length < 0) length += value.Length;
            return slicer(value, length);
        }

        public static string Left(
            [NotNull] this string value,
            int length)
            => Side(value, length, (v, n) => v.Substring(0, n));

        public static string Right(
            [NotNull] this string value,
            int length)
            => Side(value, length, (v, n) => v.Substring(v.Length - n));

        public static bool Match(
            [NotNull] this string value,
            [RegexPattern] string pattern)
            => Regex.IsMatch(value, pattern);

        public static string EnsureEndsWith(
            [NotNull] this string value,
            [NotNull] string terminator)
        {
            value.CheckArgumentNull(nameof(value));
            return value.EndsWith(terminator) ? value : value + terminator;
        }

        public static string EnsureStartsWith(
            [NotNull] this string value,
            [NotNull] string terminator)
        {
            value.CheckArgumentNull(nameof(value));
            return value.StartsWith(terminator) ? value : terminator + value;
        }

        public static string Reverse(
            [NotNull] this string value)
        {
            value.CheckArgumentNull(nameof(value));
            var arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static void SubstringFollowing(
            [NotNull] this string value,
            [NotNull] string term,
            int? length = null)
            => throw new NotImplementedException();

        public static void SubstringPreceding(
            [NotNull] this string value,
            [NotNull] string term,
            int? length = null)
            => throw new NotImplementedException();

        public static string DefaultIfEmpty(
            this string value,
            string defaultValue,
            bool ignoreWhiteSpace = false)
            => (ignoreWhiteSpace
                ? string.IsNullOrWhiteSpace(value)
                : string.IsNullOrEmpty(value))
                ? defaultValue
                : value;

        public static string[] Split(
            [NotNull] this string value,
            IEnumerable<char> separator,
            int? count = int.MaxValue,
            StringSplitOptions? options = StringSplitOptions.None)
        {
            value.CheckArgumentNull(nameof(value));
            return value.Split(separator?.ToArray(), count, options);
        }

        public static string[] Split(
            [NotNull] this string value,
            IEnumerable<string> separator,
            int? count = int.MaxValue,
            StringSplitOptions? options = StringSplitOptions.None)
        {
            value.CheckArgumentNull(nameof(value));
            return value.Split(separator?.ToArray(), count, options);
        }
    }
}