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

        private static readonly DateTime
            DAY = new DateTime(2017, 7, 4),
            DAY_BEFORE = DAY.AddDays(-1),
            DAY_AFTER = DAY.AddDays(1),
            DAY_EOMONTH = new DateTime(2017, 7, 31);

        public static readonly Calendar
            CALENDAR = new GregorianCalendar(GregorianCalendarTypes.USEnglish);

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
        public void PreviousDayOfMonth_WithWrongDay_ThrowsException()
            => ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.PreviousDayOfMonth(
                    CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), CALENDAR.GetMonth(DAY)) + 1,
                    CALENDAR));

        [TestMethod]
        public void PreviousDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearBefore()
            => AreEqual(
                DAY.PreviousDayOfMonth(CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, -1));

        [TestMethod]
        public void PreviousDayOfMonth_WithPreviousDayOfMonth_ExpectsPreviousDateTime()
            => AreEqual(
                DAY.PreviousDayOfMonth(CALENDAR.GetDayOfMonth(DAY_BEFORE),
                    CALENDAR),
                DAY_BEFORE);

        #endregion PreviousDayOfMonth

        #region NextDayOfMonth

        [TestMethod]
        public void NextDayOfMonth_WithWrongDay_ThrowsException()
        {
            var month = CALENDAR.GetMonth(DAY);
            ThrowsException<ArgumentOutOfRangeException>(
                () => DAY.NextDayOfMonth(CALENDAR.GetDaysInMonth(CALENDAR.GetYear(DAY), month) + 1,
                    CALENDAR));
        }

        [TestMethod]
        public void NextDayOfMonth_WithSameDayOfMonth_ExpectsSameDateTimeYearAfter()
            => AreEqual(
                DAY.NextDayOfMonth(CALENDAR.GetDayOfMonth(DAY),
                    CALENDAR),
                CALENDAR.AddYears(DAY, 1));

        [TestMethod]
        public void NextDayOfMonth_WithNextDayOfMonth_ExpectsNextDateTime()
            => AreEqual(
                DAY.NextDayOfMonth(CALENDAR.GetDayOfMonth(DAY_AFTER),
                    CALENDAR),
                DAY_AFTER);

        #endregion NextDayOfMonth

        #region EndOfMonth

        [TestMethod]
        public void EndOfMonth_WithEndOfMonth_ExpectsSame()
            => AreEqual(DAY_EOMONTH, DAY.EndOfMonth(CALENDAR));

        #endregion EndOfMonth
    }
}