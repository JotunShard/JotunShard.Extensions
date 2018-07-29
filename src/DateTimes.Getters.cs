using System;
using System.Globalization;

namespace JotunShard.Extensions
{
    public static partial class DateTimes
    {
        /// <summary>
        /// Provision of the value for the property DayOfMonth
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property DayOfMonth</param>
        /// <returns>Value for the property DayOfMonth</returns>
        public static int GetDayOfMonth(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfMonth(value);

        /// <summary>
        /// Provision of the value for the property DayOfMonth
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property DayOfMonth</param>
        /// <returns>Value for the property DayOfMonth</returns>
        public static int GetDayOfMonth(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property DayOfWeek
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property DayOfWeek</param>
        /// <returns>Value for the property DayOfWeek</returns>
        public static DayOfWeek GetDayOfWeek(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfWeek(value);

        /// <summary>
        /// Provision of the value for the property DayOfWeek
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property DayOfWeek</param>
        /// <returns>Value for the property DayOfWeek</returns>
        public static DayOfWeek GetDayOfWeek(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfWeek((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property DayOfYear
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property DayOfYear</param>
        /// <returns>Value for the property DayOfYear</returns>
        public static int GetDayOfYear(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfYear(value);

        /// <summary>
        /// Provision of the value for the property DayOfYear
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property DayOfYear</param>
        /// <returns>Value for the property DayOfYear</returns>
        public static int GetDayOfYear(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Era
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Era</param>
        /// <returns>Value for the property Era</returns>
        public static int GetEra(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetEra(value);

        /// <summary>
        /// Provision of the value for the property Era
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Era</param>
        /// <returns>Value for the property Era</returns>
        public static int GetEra(this DateTime value, CultureInfo culture = null)
            => value.GetEra((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Hour
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Hour</param>
        /// <returns>Value for the property Hour</returns>
        public static int GetHour(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetHour(value);

        /// <summary>
        /// Provision of the value for the property Hour
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Hour</param>
        /// <returns>Value for the property Hour</returns>
        public static int GetHour(this DateTime value, CultureInfo culture = null)
            => value.GetHour((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Milliseconds
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Milliseconds</param>
        /// <returns>Value for the property Milliseconds</returns>
        public static double GetMilliseconds(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMilliseconds(value);

        /// <summary>
        /// Provision of the value for the property Milliseconds
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Milliseconds</param>
        /// <returns>Value for the property Milliseconds</returns>
        public static double GetMilliseconds(this DateTime value, CultureInfo culture = null)
            => value.GetMilliseconds((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Minute
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Minute</param>
        /// <returns>Value for the property Minute</returns>
        public static int GetMinute(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMinute(value);

        /// <summary>
        /// Provision of the value for the property Minute
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Minute</param>
        /// <returns>Value for the property Minute</returns>
        public static int GetMinute(this DateTime value, CultureInfo culture = null)
            => value.GetMinute((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Month</param>
        /// <returns>Value for the property Month</returns>
        public static int GetMonth(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMonth(value);

        /// <summary>
        /// Provision of the value for the property Month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Month</param>
        /// <returns>Value for the property Month</returns>
        public static int GetMonth(this DateTime value, CultureInfo culture = null)
            => value.GetMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Second
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Second</param>
        /// <returns>Value for the property Second</returns>
        public static int GetSecond(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetSecond(value);

        /// <summary>
        /// Provision of the value for the property Second
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Second</param>
        /// <returns>Value for the property Second</returns>
        public static int GetSecond(this DateTime value, CultureInfo culture = null)
            => value.GetSecond((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Provision of the value for the property Year
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Year</param>
        /// <returns>Value for the property Year</returns>
        public static int GetYear(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetYear(value);

        /// <summary>
        /// Provision of the value for the property Year
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Year</param>
        /// <returns>Value for the property Year</returns>
        public static int GetYear(this DateTime value, CultureInfo culture = null)
            => value.GetYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Day
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property Day</returns>
        public static bool IsSameDay(this DateTime value)
            => value.Day == DateTime.Now.Day;

        /// <summary>
        /// Predicate of a value being having the same as now on the property Hour
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Hour</param>
        /// <returns>Condition of equality for the property Hour</returns>
        public static bool IsSameHour(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetHour(value) == calendar.GetHour(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property Hour
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Hour</param>
        /// <returns>Condition of equality for the property Hour</returns>
        public static bool IsSameHour(this DateTime value, CultureInfo culture = null)
            => value.IsSameHour((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Month</param>
        /// <returns>Condition of equality for the property Month</returns>
        public static bool IsSameMonth(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetMonth(value) == calendar.GetMonth(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property Month
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Month</param>
        /// <returns>Condition of equality for the property Month</returns>
        public static bool IsSameMonth(this DateTime value, CultureInfo culture = null)
            => value.IsSameMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Minute
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Minute</param>
        /// <returns>Condition of equality for the property Minute</returns>
        public static bool IsSameMinute(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetMinute(value) == calendar.GetMinute(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property Minute
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Minute</param>
        /// <returns>Condition of equality for the property Minute</returns>
        public static bool IsSameMinute(this DateTime value, CultureInfo culture = null)
            => value.IsSameMinute((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Second
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Second</param>
        /// <returns>Condition of equality for the property Second</returns>
        public static bool IsSameSecond(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetSecond(value) == calendar.GetSecond(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property Second
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Second</param>
        /// <returns>Condition of equality for the property Second</returns>
        public static bool IsSameSecond(this DateTime value, CultureInfo culture = null)
            => value.IsSameSecond((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Year
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property Year</param>
        /// <returns>Condition of equality for the property Year</returns>
        public static bool IsSameYear(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetYear(value) == calendar.GetYear(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property Year
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property Year</param>
        /// <returns>Condition of equality for the property Year</returns>
        public static bool IsSameYear(this DateTime value, CultureInfo culture = null)
            => value.IsSameYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Date
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property Date</returns>
        public static bool IsSameDate(this DateTime value)
            => value.Date == DateTime.Now.Date;

        /// <summary>
        /// Predicate of a value being having the same as now on the property DayOfWeek
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property DayOfWeek</param>
        /// <returns>Condition of equality for the property DayOfWeek</returns>
        public static bool IsSameDayOfWeek(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetDayOfWeek(value) == calendar.GetDayOfWeek(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property DayOfWeek
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property DayOfWeek</param>
        /// <returns>Condition of equality for the property DayOfWeek</returns>
        public static bool IsSameDayOfWeek(this DateTime value, CultureInfo culture = null)
            => value.IsSameDayOfWeek((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property DayOfYear
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="calendar">The calendar on which to base the property DayOfYear</param>
        /// <returns>Condition of equality for the property DayOfYear</returns>
        public static bool IsSameDayOfYear(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetDayOfYear(value) == calendar.GetDayOfYear(DateTime.Now);
        }

        /// <summary>
        /// Predicate of a value being having the same as now on the property DayOfYear
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <param name="culture">The culture on which to base the property DayOfYear</param>
        /// <returns>Condition of equality for the property DayOfYear</returns>
        public static bool IsSameDayOfYear(this DateTime value, CultureInfo culture = null)
            => value.IsSameDayOfYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        /// <summary>
        /// Predicate of a value being having the same as now on the property Kind
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property Kind</returns>
        public static bool IsSameKind(this DateTime value)
            => value.Kind == DateTime.Now.Kind;

        /// <summary>
        /// Predicate of a value being having the same as now on the property Millisecond
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property Millisecond</returns>
        public static bool IsSameMillisecond(this DateTime value)
            => value.Millisecond == DateTime.Now.Millisecond;

        /// <summary>
        /// Predicate of a value being having the same as now on the property Ticks
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property Ticks</returns>
        public static bool IsSameTicks(this DateTime value)
            => value.Ticks == DateTime.Now.Ticks;

        /// <summary>
        /// Predicate of a value being having the same as now on the property TimeOfDay
        /// </summary>
        /// <param name="value">The subjected value</param>
        /// <returns>Condition of equality for the property TimeOfDay</returns>
        public static bool IsSameTimeOfDay(this DateTime value)
            => value.TimeOfDay == DateTime.Now.TimeOfDay;
    }
}