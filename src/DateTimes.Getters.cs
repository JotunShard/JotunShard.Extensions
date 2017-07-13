using System;
using System.Globalization;

namespace JotunShard.Extensions
{
    public static partial class DateTimes
    {
        public static int GetDayOfMonth(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfMonth(value);

        public static int GetDayOfMonth(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static DayOfWeek GetDayOfWeek(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfWeek(value);

        public static DayOfWeek GetDayOfWeek(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfWeek((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetDayOfYear(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetDayOfYear(value);

        public static int GetDayOfYear(this DateTime value, CultureInfo culture = null)
            => value.GetDayOfYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetEra(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetEra(value);

        public static int GetEra(this DateTime value, CultureInfo culture = null)
            => value.GetEra((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetHour(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetHour(value);

        public static int GetHour(this DateTime value, CultureInfo culture = null)
            => value.GetHour((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static double GetMilliseconds(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMilliseconds(value);

        public static double GetMilliseconds(this DateTime value, CultureInfo culture = null)
            => value.GetMilliseconds((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetMinute(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMinute(value);

        public static int GetMinute(this DateTime value, CultureInfo culture = null)
            => value.GetMinute((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetMonth(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetMonth(value);

        public static int GetMonth(this DateTime value, CultureInfo culture = null)
            => value.GetMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetSecond(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetSecond(value);

        public static int GetSecond(this DateTime value, CultureInfo culture = null)
            => value.GetSecond((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static int GetYear(this DateTime value, Calendar calendar)
            => (calendar ?? CultureInfo.CurrentCulture.Calendar).GetYear(value);

        public static int GetYear(this DateTime value, CultureInfo culture = null)
            => value.GetYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameDate(this DateTime value)
            => value.Date == DateTime.Now.Date;

        public static bool IsSameDay(this DateTime value)
            => value.Day == DateTime.Now.Day;

        public static bool IsSameDayOfWeek(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetDayOfWeek(value) == calendar.GetDayOfWeek(DateTime.Now);
        }

        public static bool IsSameDayOfWeek(this DateTime value, CultureInfo culture = null)
            => value.IsSameDayOfWeek((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameDayOfYear(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetDayOfYear(value) == calendar.GetDayOfYear(DateTime.Now);
        }

        public static bool IsSameDayOfYear(this DateTime value, CultureInfo culture = null)
            => value.IsSameDayOfYear((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameHour(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetHour(value) == calendar.GetHour(DateTime.Now);
        }

        public static bool IsSameHour(this DateTime value, CultureInfo culture = null)
            => value.IsSameHour((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameKind(this DateTime value)
            => value.Kind == DateTime.Now.Kind;

        public static bool IsSameMillisecond(this DateTime value)
            => value.Millisecond == DateTime.Now.Millisecond;

        public static bool IsSameMinute(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetMinute(value) == calendar.GetMinute(DateTime.Now);
        }

        public static bool IsSameMinute(this DateTime value, CultureInfo culture = null)
            => value.IsSameMinute((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameMonth(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetMonth(value) == calendar.GetMonth(DateTime.Now);
        }

        public static bool IsSameMonth(this DateTime value, CultureInfo culture = null)
            => value.IsSameMonth((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameSecond(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetSecond(value) == calendar.GetSecond(DateTime.Now);
        }

        public static bool IsSameSecond(this DateTime value, CultureInfo culture = null)
            => value.IsSameSecond((culture ?? CultureInfo.CurrentCulture).Calendar);

        public static bool IsSameTicks(this DateTime value)
            => value.Ticks == DateTime.Now.Ticks;

        public static bool IsSameTimeOfDay(this DateTime value)
            => value.TimeOfDay == DateTime.Now.TimeOfDay;

        public static bool IsSameYear(this DateTime value, Calendar calendar)
        {
            calendar = calendar ?? CultureInfo.CurrentCulture.Calendar;
            return calendar.GetYear(value) == calendar.GetYear(DateTime.Now);
        }

        public static bool IsSameYear(this DateTime value, CultureInfo culture = null)
            => value.IsSameYear((culture ?? CultureInfo.CurrentCulture).Calendar);
    }
}