using System;
using System.Globalization;

namespace JotunShard.Extensions
{
    public static partial class DateTimes
    {
        public static bool IsFuture(this DateTime value) => value > DateTime.Now;

        public static bool IsPast(this DateTime value) => value < DateTime.Now;

        public static bool IsToday(this DateTime value) => value.Date == DateTime.Today;

        public static DateTime AddWeeks(
            this DateTime value,
            int weeks,
            Calendar calendar = null)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar)
                .AddWeeks(value, weeks);

        private static DateTime OtherDayOfWeek(
            DateTime value,
            DayOfWeek target,
            Calendar calendar,
            int weekDiff,
            Func<int, bool> comparerOtherValue)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            if (comparerOtherValue(value.DayOfWeek - target))
                value = calendar.AddWeeks(value.Date, weekDiff);
            return calendar.AddDays(
                value.Date,
                target - calendar.GetDayOfWeek(value));
        }

        public static DateTime PreviousDayOfWeek(
            this DateTime value,
            DayOfWeek target,
            Calendar calendar = null)
            => OtherDayOfWeek(value, target, calendar, -1, v => v <= 0);

        public static DateTime NextDayOfWeek(
            this DateTime value,
            DayOfWeek target,
            Calendar calendar = null)
            => OtherDayOfWeek(value, target, calendar, 1, v => v >= 0);

        private static DateTime OtherDayOfMonth(
            DateTime value,
            int month,
            int day,
            Calendar calendar,
            int yearsDiff,
            Func<int, bool> comparerOtherValue)
        {
            month.CheckArgumentIsGreaterOrEqual(nameof(month), 1);
            day.CheckArgumentIsGreaterOrEqual(nameof(day), 1);
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            var diffMonths = calendar.GetMonth(value) - month;
            var diffDays = calendar.GetDayOfMonth(value) - day;
            var year = calendar.GetYear(value);
            if (comparerOtherValue(diffMonths)
                || diffMonths == 0
                    && (diffDays == 0 || comparerOtherValue(diffDays)))
                year += yearsDiff;
            month.CheckArgumentIsLesserOrEqual(
                nameof(month),
                calendar.GetMonthsInYear(year));
            day.CheckArgumentIsLesserOrEqual(
                nameof(day),
                calendar.GetDaysInMonth(year, month));
            return calendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static DateTime PreviousDayOfMonth(
            this DateTime value,
            int month,
            int day,
            Calendar calendar = null)
            => OtherDayOfMonth(value, month, day, calendar, -1, v => v < 0);

        public static DateTime NextDayOfMonth(
            this DateTime value,
            int month,
            int day,
            Calendar calendar = null)
            => OtherDayOfMonth(value, month, day, calendar, 1, v => v > 0);

        public static DateTime EndOfMonth(
            this DateTime value,
            Calendar calendar = null)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            var daysInMonth = calendar.GetDaysInMonth(
                calendar.GetYear(value),
                calendar.GetMonth(value),
                calendar.GetEra(value));
            return calendar.AddDays(
                value.Date,
                daysInMonth - calendar.GetDayOfMonth(value));
        }

        public static DateTime AddWeeks(this DateTime value, int weeks, CultureInfo culture = null)
            => AddWeeks(value, weeks, (culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DateTime PreviousDayOfWeek(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, (culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DateTime NextDayOfWeek(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, (culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DateTime PreviousDayOfMonth(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, (culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DateTime NextDayOfMonth(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, (culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DateTime EndOfMonth(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, (culture ?? CultureInfo.CurrentCulture).Calendar);
    }
}