using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;

namespace JotunShard.Extensions.Test
{
    using static Assert;

    [TestClass]
    public class DateTimesTest
    {
        #region Constants

        private const int
            LENGTH_WEEK = 7,
            COUNT_WEEKS = 3;

        private static readonly int
            COUNT_MONTHS_IN_YEAR;

        private static readonly DateTime
            DAY = new DateTime(2017, 7, 4),
            DAY_BEFORE = DAY.AddDays(-1),
            DAY_AFTER = DAY.AddDays(1);

        public static readonly Calendar
            CALENDAR = new GregorianCalendar(GregorianCalendarTypes.USEnglish);

        static DateTimesTest()
        {
            COUNT_MONTHS_IN_YEAR = CALENDAR.GetMonthsInYear(DAY.Year);
        }

        #endregion Constants

        #region AddWeeks

        [TestMethod]
        public void AddWeeks_WithNoWeek_ExpectsSameDateTime()
            => AreEqual(DAY.AddWeeks(0, CALENDAR), DAY);

        [TestMethod]
        public void AddWeeks_WithSomeWeeks_ExpectsRightDateTime()
            => AreEqual(
                DAY.AddWeeks(COUNT_WEEKS, CALENDAR),
                CALENDAR.AddDays(DAY, COUNT_WEEKS * LENGTH_WEEK));

        #endregion AddWeeks

        #region PreviousDayOfWeek

        [TestMethod]
        public void PreviousDayOfWeek_WithSameDayOfWeek_ExpectsSameDateTimeWeekBefore()
            => AreEqual(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY),
                    CALENDAR),
                CALENDAR.AddDays(DAY, -LENGTH_WEEK));

        [TestMethod]
        public void PreviousDayOfWeek_WithPreviousDayOfWeek_ExpectsPreviousDateTime()
            => AreEqual(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_BEFORE),
                    CALENDAR),
                DAY_BEFORE);

        [TestMethod]
        public void PreviousDayOfWeek_WithNextDayOfWeek_ExpectsNextDateTimeWeekBefore()
            => AreEqual(
                DAY.PreviousDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_AFTER),
                    CALENDAR),
                CALENDAR.AddDays(DAY_AFTER, -LENGTH_WEEK));

        #endregion PreviousDayOfWeek

        #region NextDayOfWeek

        [TestMethod]
        public void NextDayOfWeek_WithSameDayOfWeek_ExpectsSameDateTimeWeekAfter()
            => AreEqual(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY),
                    CALENDAR),
                CALENDAR.AddDays(DAY, LENGTH_WEEK));

        [TestMethod]
        public void NextDayOfWeek_WithNextDayOfWeek_ExpectsNextDateTime()
            => AreEqual(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_AFTER),
                    CALENDAR),
                DAY_AFTER);

        [TestMethod]
        public void NextDayOfWeek_WithPreviousDayOfWeek_ExpectsPreviousDateTimeWeekAfter()
            => AreEqual(
                DAY.NextDayOfWeek(
                    CALENDAR.GetDayOfWeek(DAY_BEFORE),
                    CALENDAR),
                CALENDAR.AddDays(DAY_BEFORE, LENGTH_WEEK));

        #endregion NextDayOfWeek

        #region PreviousDayOfMonth

        [TestMethod]
        public void PreviousDayOfMonth_WithWrongMonth_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.PreviousDayOfMonth(
                    CALENDAR.GetMonthsInYear(CALENDAR.GetYear(DAY)) + 1,
                    CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR));

        [TestMethod]
        public void PreviousDayOfMonth_WithWrongDay_ThrowsException()
        {
            var month = CALENDAR.GetMonth(DAY);
            ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.PreviousDayOfMonth(
                    month,
                    CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), month) + 1,
                    CALENDAR));
        }

        [TestMethod]
        public void PreviousDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearBefore()
            => AreEqual(
                DAY.PreviousDayOfMonth(
                    DAY.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, -1));

        [TestMethod]
        public void PreviousDayOfMonth_WithPreviousDayOfMonth_ExpectsPreviousDateTime()
            => AreEqual(
                DAY.PreviousDayOfMonth(
                    DAY_BEFORE.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY_BEFORE),
                    CALENDAR),
                DAY_BEFORE);

        [TestMethod]
        public void PreviousDayOfMonth_WithNextDayOfMonth_ExpectsNextDateTimeYearBefore()
            => AreEqual(
                DAY.PreviousDayOfMonth(
                    DAY_AFTER.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY_AFTER),
                    CALENDAR),
                CALENDAR.AddYears(DAY_AFTER, -1));

        [TestMethod]
        public void PreviousDayOfMonth_WithPreviousDayOfNextMonth_ExpectsDateTimeYearBeforeMonthAfter()
            => AreEqual(
                DAY.PreviousDayOfMonth(
                    DAY_BEFORE.GetMonth() + 1,
                    CALENDAR.GetDayOfMonth(DAY_BEFORE),
                    CALENDAR),
                CALENDAR.AddYears(CALENDAR.AddMonths(DAY_BEFORE, 1), -1));

        #endregion PreviousDayOfMonth

        #region NextDayOfMonth

        [TestMethod]
        public void NextDayOfMonth_WithWrongMonth_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.NextDayOfMonth(
                    CALENDAR.GetMonthsInYear(CALENDAR.GetYear(DAY)) + 1,
                    CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR));

        [TestMethod]
        public void NextDayOfMonth_WithWrongDay_ThrowsException()
        {
            var month = CALENDAR.GetMonth(DAY);
            ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.NextDayOfMonth(
                    month,
                    CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), month) + 1,
                    CALENDAR));
        }

        [TestMethod]
        public void NextDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearAfter()
            => AreEqual(
                DAY.NextDayOfMonth(
                    DAY.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, 1));

        [TestMethod]
        public void NextDayOfMonth_WithNextDayOfMonth_ExpectsNextDateTime()
            => AreEqual(
                DAY.NextDayOfMonth(
                    DAY_AFTER.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY_AFTER),
                    CALENDAR),
                DAY_AFTER);

        [TestMethod]
        public void PreviousDayOfMonth_WithPreviousDayOfMonth_ExpectsNextDateTimeYearAfter()
            => AreEqual(
                DAY.NextDayOfMonth(
                    DAY_BEFORE.GetMonth(),
                    CALENDAR.GetDayOfMonth(DAY_BEFORE),
                    CALENDAR),
                CALENDAR.AddYears(DAY_BEFORE, 1));

        [TestMethod]
        public void NextDayOfMonth_WithNextDayOfPreviousMonth_ExpectsDateTimeYearAfterMonthBefore()
            => AreEqual(
                DAY.NextDayOfMonth(
                    DAY_AFTER.GetMonth() - 1,
                    CALENDAR.GetDayOfMonth(DAY_AFTER),
                    CALENDAR),
                CALENDAR.AddYears(CALENDAR.AddMonths(DAY_AFTER, -1), 1));

        #endregion NextDayOfMonth
    }
}