using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JotunShard.Extensions.Test
{
    using static Assert;

    [TestClass]
    public class StringsTest
    {
        #region Constants

        private const string
            NULL = null,
            WORD_FIRST = "Hello",
            WORD_SEPARATOR = " ",
            WORD_LAST = "World",
            WORD = "Bye",
            WORD_REVERSED = "eyB",
            SENTENCE_FORMAT = "{0}{1}{2}",
            SENTENCE_WHITESPACE = " ";

        private static readonly string
            EMPTY = string.Empty,
            SENTENCE = $"{WORD_FIRST}{WORD_SEPARATOR}{WORD_LAST}";

        private static readonly int
            LENGTH_WORD = WORD_FIRST.Length,
            LENGTH_GREATER = LENGTH_WORD + SENTENCE.Length;

        #endregion Constants

        #region IsNullOrEmpty

        [TestMethod]
        public void IsNullOrEmpty_WithNull_ExpectsTrue()
            => IsTrue(NULL.IsNullOrEmpty());

        [TestMethod]
        public void IsNullOrEmpty_WithEmptyString_ExpectsTrue()
            => IsTrue(EMPTY.IsNullOrEmpty());

        [TestMethod]
        public void IsNullOrEmpty_WithSentenceString_ExpectsFalse()
            => IsFalse(SENTENCE.IsNullOrEmpty());

        #endregion IsNullOrEmpty

        #region IsNullOrWhiteSpace

        [TestMethod]
        public void IsNullOrWhiteSpace_WithNull_ExpectsTrue()
            => IsTrue(NULL.IsNullOrWhiteSpace());

        [TestMethod]
        public void IsNullOrWhiteSpace_WithEmptyString_ExpectsTrue()
            => IsTrue(EMPTY.IsNullOrWhiteSpace());

        [TestMethod]
        public void IsNullOrWhiteSpace_WithWordSeparator_ExpectsTrue()
            => IsTrue(WORD_SEPARATOR.IsNullOrWhiteSpace());

        [TestMethod]
        public void IsNullOrWhiteSpace_WithSentenceString_ExpectsFalse()
            => IsFalse(SENTENCE.IsNullOrWhiteSpace());

        #endregion IsNullOrWhiteSpace

        #region FormatWith

        [TestMethod]
        public void FormatWith_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.FormatWith());

        [TestMethod]
        public void FormatWith_WithEmptyString_ExpectsEmptyString()
            => AreEqual(EMPTY.FormatWith(), EMPTY);

        [TestMethod]
        public void FormatWith_WithUnformattedString_ExpectsSameString()
            => AreEqual(SENTENCE.FormatWith(), SENTENCE);

        [TestMethod]
        public void FormatWith_WithFormattedString_ExpectsSameSentenceString()
            => AreEqual(
                SENTENCE_FORMAT.FormatWith(WORD_FIRST, WORD_SEPARATOR, WORD_LAST),
                SENTENCE);

        #endregion FormatWith

        #region Left

        [TestMethod]
        public void Left_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.Left(0));

        [TestMethod]
        public void Left_WithEmptyStringAndPositiveLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Left(LENGTH_WORD), EMPTY);

        [TestMethod]
        public void Left_WithEmptyStringAndNegativeLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Left(-LENGTH_WORD), EMPTY);

        [TestMethod]
        public void Left_WithEmptyStringAndZeroLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Left(0), EMPTY);

        [TestMethod]
        public void Left_WithSentenceStringAndPositiveWordLength_ExpectsFirstWord()
            => AreEqual(SENTENCE.Left(LENGTH_WORD), WORD_FIRST);

        [TestMethod]
        public void Left_WithSentenceStringAndNegativeWordLength_ExpectsAllButLastWord()
            => AreEqual(SENTENCE.Left(-LENGTH_WORD), WORD_FIRST + WORD_SEPARATOR);

        [TestMethod]
        public void Left_WithSentenceStringAndPositiveGreaterLength_ExpectsSameString()
            => AreEqual(SENTENCE.Left(LENGTH_GREATER), SENTENCE);

        [TestMethod]
        public void Left_WithSentenceStringAndNegativeGreaterLength_ExpectsSameString()
            => AreEqual(SENTENCE.Left(-LENGTH_GREATER), SENTENCE);

        [TestMethod]
        public void Left_WithSentenceStringAndZeroLength_ExpectsEmptyString()
            => AreEqual(SENTENCE.Left(0), EMPTY);

        #endregion Left

        #region Right

        [TestMethod]
        public void Right_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.Right(0));

        [TestMethod]
        public void Right_WithEmptyStringAndPositiveLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Right(LENGTH_WORD), EMPTY);

        [TestMethod]
        public void Right_WithEmptyStringAndNegativeLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Right(-LENGTH_WORD), EMPTY);

        [TestMethod]
        public void Right_WithEmptyStringAndZeroLength_ExpectsEmptyString()
            => AreEqual(EMPTY.Right(0), EMPTY);

        [TestMethod]
        public void Right_WithSentenceStringAndPositiveWordLength_ExpectsLastWord()
            => AreEqual(SENTENCE.Right(LENGTH_WORD), WORD_LAST);

        [TestMethod]
        public void Right_WithSentenceStringAndNegativeWordLength_ExpectsAllButFirstWord()
            => AreEqual(SENTENCE.Right(-LENGTH_WORD), WORD_SEPARATOR + WORD_LAST);

        [TestMethod]
        public void Right_WithSentenceStringAndPositiveGreaterLength_ExpectsSameString()
            => AreEqual(SENTENCE.Right(LENGTH_GREATER), SENTENCE);

        [TestMethod]
        public void Right_WithSentenceStringAndNegativeGreaterLength_ExpectsSameString()
            => AreEqual(SENTENCE.Right(-LENGTH_GREATER), SENTENCE);

        [TestMethod]
        public void Right_WithSentenceStringAndZeroLength_ExpectsEmptyString()
            => AreEqual(SENTENCE.Right(0), EMPTY);

        #endregion Right

        #region Match

        [TestMethod]
        public void Match_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.Match(EMPTY));

        [TestMethod]
        public void Match_WithEmptyStringAndNullPattern_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => EMPTY.Match(NULL));

        [TestMethod]
        public void Match_WithEmptyStringAndEmptyPattern_ExpectsTrue()
            => IsTrue(EMPTY.Match(EMPTY));

        [TestMethod]
        public void Match_WithSentenceStringAndEmptyPattern_ExpectsTrue()
            => IsTrue(SENTENCE.Match(EMPTY));

        [TestMethod]
        public void Match_WithSentenceStringAndFirstWordPattern_ExpectsTrue()
            => IsTrue(SENTENCE.Match(WORD_FIRST));

        [TestMethod]
        public void Match_WithSentenceStringAndSamePattern_ExpectsTrue()
            => IsTrue(SENTENCE.Match(SENTENCE));

        [TestMethod]
        public void Match_WithSentenceStringAndUnknownWordPattern_ExpectsFalse()
            => IsFalse(SENTENCE.Match(WORD));

        #endregion Match

        #region EnsureEndsWith

        [TestMethod]
        public void EnsureEndsWith_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.EnsureEndsWith(WORD_LAST));

        [TestMethod]
        public void EnsureEndsWith_WithNullValue_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => SENTENCE.EnsureEndsWith(NULL));

        [TestMethod]
        public void EnsureEndsWith_WithSentenceStringAndUnknownWord_ExpectsConcatenationAtEnd()
            => AreEqual(
                SENTENCE + WORD,
                SENTENCE.EnsureEndsWith(WORD));

        [TestMethod]
        public void EnsureEndsWith_WithSentenceStringAndLastWord_ExpectsSentenceString()
            => AreEqual(
                SENTENCE,
                SENTENCE.EnsureEndsWith(WORD_LAST));

        #endregion EnsureEndsWith

        #region EnsureStartsWith

        [TestMethod]
        public void EnsureStartsWith_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.EnsureStartsWith(WORD_LAST));

        [TestMethod]
        public void EnsureStartsWith_WithNullValue_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => SENTENCE.EnsureStartsWith(NULL));

        [TestMethod]
        public void EnsureStartsWith_WithSentenceStringAndUnknownWord_ExpectsConcatenationAtStart()
            => AreEqual(
                WORD + SENTENCE,
                SENTENCE.EnsureStartsWith(WORD));

        [TestMethod]
        public void EnsureStartsWith_WithSentenceStringAndFirstWord_ExpectsSentenceString()
            => AreEqual(
                SENTENCE,
                SENTENCE.EnsureStartsWith(WORD_FIRST));

        #endregion EnsureStartsWith

        #region Reverse

        [TestMethod]
        public void Reverse_WithNullString_ThrowsException()
            => ThrowsException<ArgumentNullException>(() => NULL.Reverse());

        [TestMethod]
        public void Reverse_WithWordString_ExpectsReversedWordString()
            => AreEqual(
                WORD_REVERSED,
                WORD.Reverse());

        #endregion Reverse

        #region SubstringFollowing

        [TestMethod]
        public void SubstringFollowing()
            => Fail();

        #endregion SubstringFollowing

        #region SubstringPreceding

        [TestMethod]
        public void SubstringPreceding()
            => Fail();

        #endregion SubstringPreceding

        #region DefaultIfEmpty

        [TestMethod]
        public void DefaultIfEmpty_WithNullString_ExpectsDefaultString()
            => AreEqual(
                SENTENCE,
                NULL.DefaultIfEmpty(SENTENCE));

        [TestMethod]
        public void DefaultIfEmpty_WithEmptyString_ExpectsDefaultString()
            => AreEqual(
                SENTENCE,
                EMPTY.DefaultIfEmpty(SENTENCE));

        [TestMethod]
        public void DefaultIfEmpty_WithWhitespaceStringAndNotIgnoreWhitespace_ExpectsWhitespaceString()
            => AreEqual(
                SENTENCE_WHITESPACE,
                SENTENCE_WHITESPACE.DefaultIfEmpty(SENTENCE, false));

        [TestMethod]
        public void DefaultIfEmpty_WithWhitespaceStringAndDoIgnoreWhitespace_ExpectsDefaultString()
            => AreEqual(
                SENTENCE,
                SENTENCE_WHITESPACE.DefaultIfEmpty(SENTENCE, true));

        #endregion DefaultIfEmpty
    }
}