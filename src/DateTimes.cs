using System;
using System.Globalization;

namespace JotunShard.Extensions
{
    public static partial class DateTimes
    {
        /// <summary>
        /// Predicate of a DateTime being in the future.
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition being in the future</returns>
        public static bool IsFuture(this DateTime value) => value > DateTime.Now;

        /// <summary>
        /// Predicate of a DateTime being in the past.
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition being in the past</returns>
        public static bool IsPast(this DateTime value) => value < DateTime.Now;

        /// <summary>
        /// Predicate of a DateTime being today.
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition being today</returns>
        public static bool IsToday(this DateTime value) => value.Date == DateTime.Today;

        /// <summary>
        /// Addition of weeks to a DateTime
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="weeks">The number of weeks</param>
        /// <param name="calendar">The calendar on which to count a week</param>
        /// <returns>Projected DateTime by the count of weeks</returns>
        public static DateTime AddWeeks(
            this DateTime value,
            int weeks,
            Calendar calendar)
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
            {
                value = calendar.AddWeeks(value.Date, weekDiff);
            }

            return calendar.AddDays(
                value.Date,
                target - calendar.GetDayOfWeek(value));
        }

        /// <summary>
        /// Precedence of a certain day of the week
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="target">The targeted day of the week</param>
        /// <param name="calendar">The calendar on which to count a week</param>
        /// <returns>Projected DateTime on the corresponding day of the week</returns>
        public static DateTime PreviousDayOfWeek(
            this DateTime value,
            DayOfWeek target,
            Calendar calendar)
            => OtherDayOfWeek(value, target, calendar, -1, v => v <= 0);

        /// <summary>
        /// Succession of a certain day of the week
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="target">The targeted day of the week</param>
        /// <param name="calendar">The calendar on which to count a week</param>
        /// <returns>Projected DateTime on the corresponding day of the week</returns>
        public static DateTime NextDayOfWeek(
            this DateTime value,
            DayOfWeek target,
            Calendar calendar)
            => OtherDayOfWeek(value, target, calendar, 1, v => v >= 0);

        private static DateTime OtherDayOfMonth(
            DateTime value,
            int day,
            Calendar calendar,
            int valueDiff,
            Func<int, bool> comparerOtherValue)
        {
            day.CheckArgumentIsGreaterOrEqual(nameof(day), 1);
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            var year = value.Year;
            var month = value.Month;
            day.CheckArgumentIsLesserOrEqual(
                nameof(day),
                calendar.GetDaysInMonth(year, month));
            var diffDays = calendar.GetDayOfMonth(value) - day;
            if (comparerOtherValue(diffDays))
            {
                month += valueDiff;
            }
            else if (diffDays == 0)
            {
                year += valueDiff;
            }

            month.CheckArgumentIsLesserOrEqual(
                nameof(month),
                calendar.GetMonthsInYear(year));
            return calendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        /// <summary>
        /// Precedence of a certain day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="day">The day of the targeted day</param>
        /// <param name="calendar">The calendar on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding day of the month</returns>
        public static DateTime PreviousDayOfMonth(
            this DateTime value,
            int day,
            Calendar calendar)
            => OtherDayOfMonth(value, day, calendar, -1, v => v < 0);

        /// <summary>
        /// Succession of a certain day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="day">The day of the targeted day</param>
        /// <param name="calendar">The calendar on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding day of the month</returns>
        public static DateTime NextDayOfMonth(
            this DateTime value,
            int day,
            Calendar calendar)
            => OtherDayOfMonth(value, day, calendar, 1, v => v > 0);

        /// <summary>
        /// Succession of the last day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding last day of the month</returns>
        public static DateTime EndOfMonth(
            this DateTime value,
            Calendar calendar)
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

        /// <summary>
        /// Addition of weeks to a DateTime
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="weeks">The number of weeks</param>
        /// <param name="culture">The culture on which to count a week</param>
        /// <returns>Projected DateTime by the count of weeks</returns>
        public static DateTime AddWeeks(this DateTime value, int weeks, CultureInfo culture = null)
            => AddWeeks(value, weeks, culture?.Calendar);

        /// <summary>
        /// Precedence of a certain day of the week
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="target">The targeted day of the week</param>
        /// <param name="culture">The culture on which to count a week</param>
        /// <returns>Projected DateTime on the corresponding day of the week</returns>
        public static DateTime PreviousDayOfWeek(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, culture?.Calendar);

        /// <summary>
        /// Succession of a certain day of the week
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="target">The targeted day of the week</param>
        /// <param name="culture">The culture on which to count a week</param>
        /// <returns>Projected DateTime on the corresponding day of the week</returns>
        public static DateTime NextDayOfWeek(this DateTime value, DayOfWeek target, CultureInfo culture = null)
            => PreviousDayOfWeek(value, target, culture?.Calendar);

        /// <summary>
        /// Precedence of a certain day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="day">The targeted day of the month</param>
        /// <param name="culture">The culture on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding day of the month</returns>
        public static DateTime PreviousDayOfMonth(this DateTime value, int day, CultureInfo culture = null)
            => PreviousDayOfMonth(value, day, culture?.Calendar);

        /// <summary>
        /// Succession of a certain day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="day">The targeted day of the month</param>
        /// <param name="culture">The culture on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding day of the month</returns>
        public static DateTime NextDayOfMonth(this DateTime value, int day, CultureInfo culture = null)
            => NextDayOfMonth(value, day, culture?.Calendar);

        /// <summary>
        /// Succession of the last day of the month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base a month</param>
        /// <returns>Projected DateTime on the corresponding last day of the month</returns>
        public static DateTime EndOfMonth(this DateTime value, CultureInfo culture = null)
            => EndOfMonth(value, culture?.Calendar);
    }
}