using System;
using System.Globalization;
using Xunit;

namespace JotunShard.Extensions.Test
{
    using static Assert;

    public class DateTimesTest
    {
        #region Constants

        private const int
            LENGTH_WEEK = 7,
            COUNT_WEEKS = 3;

        private static readonly DateTime
            DAY = new DateTime(2017, 7, 4),
            DAY_BEFORE = DAY.AddDays(-1),
            DAY_AFTER = DAY.AddDays(1),
            DAY_EOMONTH = new DateTime(2017, 7, 31);

        public static readonly Calendar
            CALENDAR = new GregorianCalendar(GregorianCalendarTypes.USEnglish);

        #endregion Constants

        #region AddWeeks

        [Fact]
        public void AddWeeks_WithNoWeek_ExpectsSameDateTime()
            => Equal(DAY.AddWeeks(0, CALENDAR), DAY);

        [Fact]
        public void AddWeeks_WithSomeWeeks_ExpectsRightDateTime()
            => Equal(
                DAY.AddWeeks(COUNT_WEEKS, CALENDAR),
                CALENDAR.AddDays(DAY, COUNT_WEEKS * LENGTH_WEEK));

        #endregion AddWeeks

        #region PreviousDayOfWeek

        [Fact]
        public void PreviousDayOfWeek_WithSameDayOfWeek_ExpectsSameDateTimeWeekBefore()
            => Equal(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY),
                    CALENDAR),
                CALENDAR.AddDays(DAY, -LENGTH_WEEK));

        [Fact]
        public void PreviousDayOfWeek_WithPreviousDayOfWeek_ExpectsPreviousDateTime()
            => Equal(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_BEFORE),
                    CALENDAR),
                DAY_BEFORE);

        [Fact]
        public void PreviousDayOfWeek_WithNextDayOfWeek_ExpectsNextDateTimeWeekBefore()
            => Equal(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_AFTER),
                    CALENDAR),
                CALENDAR.AddDays(DAY_AFTER, -LENGTH_WEEK));

        #endregion PreviousDayOfWeek

        #region NextDayOfWeek

        [Fact]
        public void NextDayOfWeek_WithSameDayOfWeek_ExpectsSameDateTimeWeekAfter()
            => Equal(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY),
                    CALENDAR),
                CALENDAR.AddDays(DAY, LENGTH_WEEK));

        [Fact]
        public void NextDayOfWeek_WithNextDayOfWeek_ExpectsNextDateTime()
            => Equal(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_AFTER),
                    CALENDAR),
                DAY_AFTER);

        [Fact]
        public void NextDayOfWeek_WithPreviousDayOfWeek_ExpectsPreviousDateTimeWeekAfter()
            => Equal(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_BEFORE),
                    CALENDAR),
                CALENDAR.AddDays(DAY_BEFORE, LENGTH_WEEK));

        #endregion NextDayOfWeek

        #region PreviousDayOfMonth

        [Fact]
        public void PreviousDayOfMonth_WithWrongDay_Throws()
            => Throws<ArgumentOutOfRangeException>(
                () => DAY.PreviousDayOfMonth(
                    CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), CALENDAR.GetMonth(DAY)) + 1,
                    CALENDAR));

        [Fact]
        public void PreviousDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearBefore()
            => Equal(
                DAY.PreviousDayOfMonth(CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, -1));

        [Fact]
        public void PreviousDayOfMonth_WithPreviousDayOfMonth_ExpectsPreviousDateTime()
            => Equal(
                DAY.PreviousDayOfMonth(CALENDAR.GetDayOfMonth(DAY_BEFORE),
                    CALENDAR),
                DAY_BEFORE);

        #endregion PreviousDayOfMonth

        #region NextDayOfMonth

        [Fact]
        public void NextDayOfMonth_WithWrongDay_Throws()
        {
            var month = CALENDAR.GetMonth(DAY);
            Throws<ArgumentOutOfRangeException>(
                () => DAY.NextDayOfMonth(CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), month) + 1,
                    CALENDAR));
        }

        [Fact]
        public void NextDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearAfter()
            => Equal(
                DAY.NextDayOfMonth(CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, 1));

        [Fact]
        public void NextDayOfMonth_WithNextDayOfMonth_ExpectsNextDateTime()
            => Equal(
                DAY.NextDayOfMonth(CALENDAR.GetDayOfMonth(DAY_AFTER),
                    CALENDAR),
                DAY_AFTER);

        #endregion NextDayOfMonth

        #region EndOfMonth

        [Fact]
        public void EndOfMonth_WithEndOfMonth_ExpectsSame()
            => Equal(DAY_EOMONTH, DAY.EndOfMonth(CALENDAR));

        #endregion EndOfMonth
    }
}