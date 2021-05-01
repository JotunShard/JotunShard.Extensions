using System;
using Xunit;

namespace JotunShard.Extensions.Test
{
    using static Assert;

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

        [Fact]
        public void NullOrEmpty_WithNull_ExpectsTrue()
            => True(NULL.IsNullOrEmpty());

        [Fact]
        public void NullOrEmpty_WithEmptyString_ExpectsTrue()
            => True(EMPTY.IsNullOrEmpty());

        [Fact]
        public void NullOrEmpty_WithSentenceString_ExpectsFalse()
            => False(SENTENCE.IsNullOrEmpty());

        #endregion IsNullOrEmpty

        #region IsNullOrWhiteSpace

        [Fact]
        public void NullOrWhiteSpace_WithNull_ExpectsTrue()
            => True(NULL.IsNullOrWhiteSpace());

        [Fact]
        public void NullOrWhiteSpace_WithEmptyString_ExpectsTrue()
            => True(EMPTY.IsNullOrWhiteSpace());

        [Fact]
        public void NullOrWhiteSpace_WithWordSeparator_ExpectsTrue()
            => True(WORD_SEPARATOR.IsNullOrWhiteSpace());

        [Fact]
        public void NullOrWhiteSpace_WithSentenceString_ExpectsFalse()
            => False(SENTENCE.IsNullOrWhiteSpace());

        #endregion IsNullOrWhiteSpace

        #region FormatWith

        [Fact]
        public void FormatWith_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.FormatWith());

        [Fact]
        public void FormatWith_WithEmptyString_ExpectsEmptyString()
            => Equal(EMPTY.FormatWith(), EMPTY);

        [Fact]
        public void FormatWith_WithUnformattedString_ExpectsSameString()
            => Equal(SENTENCE.FormatWith(), SENTENCE);

        [Fact]
        public void FormatWith_WithFormattedString_ExpectsSameSentenceString()
            => Equal(
                SENTENCE_FORMAT.FormatWith(WORD_FIRST, WORD_SEPARATOR, WORD_LAST),
                SENTENCE);

        #endregion FormatWith

        #region Left

        [Fact]
        public void Left_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.Left(0));

        [Fact]
        public void Left_WithEmptyStringAndPositiveLength_ExpectsEmptyString()
            => Equal(EMPTY.Left(LENGTH_WORD), EMPTY);

        [Fact]
        public void Left_WithEmptyStringAndNegativeLength_ExpectsEmptyString()
            => Equal(EMPTY.Left(-LENGTH_WORD), EMPTY);

        [Fact]
        public void Left_WithEmptyStringAndZeroLength_ExpectsEmptyString()
            => Equal(EMPTY.Left(0), EMPTY);

        [Fact]
        public void Left_WithSentenceStringAndPositiveWordLength_ExpectsFirstWord()
            => Equal(SENTENCE.Left(LENGTH_WORD), WORD_FIRST);

        [Fact]
        public void Left_WithSentenceStringAndNegativeWordLength_ExpectsAllButLastWord()
            => Equal(SENTENCE.Left(-LENGTH_WORD), WORD_FIRST + WORD_SEPARATOR);

        [Fact]
        public void Left_WithSentenceStringAndPositiveGreaterLength_ExpectsSameString()
            => Equal(SENTENCE.Left(LENGTH_GREATER), SENTENCE);

        [Fact]
        public void Left_WithSentenceStringAndNegativeGreaterLength_ExpectsSameString()
            => Equal(SENTENCE.Left(-LENGTH_GREATER), SENTENCE);

        [Fact]
        public void Left_WithSentenceStringAndZeroLength_ExpectsEmptyString()
            => Equal(SENTENCE.Left(0), EMPTY);

        #endregion Left

        #region Right

        [Fact]
        public void Right_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.Right(0));

        [Fact]
        public void Right_WithEmptyStringAndPositiveLength_ExpectsEmptyString()
            => Equal(EMPTY.Right(LENGTH_WORD), EMPTY);

        [Fact]
        public void Right_WithEmptyStringAndNegativeLength_ExpectsEmptyString()
            => Equal(EMPTY.Right(-LENGTH_WORD), EMPTY);

        [Fact]
        public void Right_WithEmptyStringAndZeroLength_ExpectsEmptyString()
            => Equal(EMPTY.Right(0), EMPTY);

        [Fact]
        public void Right_WithSentenceStringAndPositiveWordLength_ExpectsLastWord()
            => Equal(SENTENCE.Right(LENGTH_WORD), WORD_LAST);

        [Fact]
        public void Right_WithSentenceStringAndNegativeWordLength_ExpectsAllButFirstWord()
            => Equal(SENTENCE.Right(-LENGTH_WORD), WORD_SEPARATOR + WORD_LAST);

        [Fact]
        public void Right_WithSentenceStringAndPositiveGreaterLength_ExpectsSameString()
            => Equal(SENTENCE.Right(LENGTH_GREATER), SENTENCE);

        [Fact]
        public void Right_WithSentenceStringAndNegativeGreaterLength_ExpectsSameString()
            => Equal(SENTENCE.Right(-LENGTH_GREATER), SENTENCE);

        [Fact]
        public void Right_WithSentenceStringAndZeroLength_ExpectsEmptyString()
            => Equal(SENTENCE.Right(0), EMPTY);

        #endregion Right

        #region Match

        [Fact]
        public void Match_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.Match(EMPTY));

        [Fact]
        public void Match_WithEmptyStringAndNullPattern_Throws()
            => Throws<ArgumentNullException>(() => EMPTY.Match(NULL));

        [Fact]
        public void Match_WithEmptyStringAndEmptyPattern_ExpectsTrue()
            => True(EMPTY.Match(EMPTY));

        [Fact]
        public void Match_WithSentenceStringAndEmptyPattern_ExpectsTrue()
            => True(SENTENCE.Match(EMPTY));

        [Fact]
        public void Match_WithSentenceStringAndFirstWordPattern_ExpectsTrue()
            => True(SENTENCE.Match(WORD_FIRST));

        [Fact]
        public void Match_WithSentenceStringAndSamePattern_ExpectsTrue()
            => True(SENTENCE.Match(SENTENCE));

        [Fact]
        public void Match_WithSentenceStringAndUnknownWordPattern_ExpectsFalse()
            => False(SENTENCE.Match(WORD));

        #endregion Match

        #region EnsureEndsWith

        [Fact]
        public void EnsureEndsWith_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.EnsureEndsWith(WORD_LAST));

        [Fact]
        public void EnsureEndsWith_WithNullValue_Throws()
            => Throws<ArgumentNullException>(() => SENTENCE.EnsureEndsWith(NULL));

        [Fact]
        public void EnsureEndsWith_WithSentenceStringAndUnknownWord_ExpectsConcatenationAtEnd()
            => Equal(
                SENTENCE + WORD,
                SENTENCE.EnsureEndsWith(WORD));

        [Fact]
        public void EnsureEndsWith_WithSentenceStringAndLastWord_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.EnsureEndsWith(WORD_LAST));

        #endregion EnsureEndsWith

        #region EnsureStartsWith

        [Fact]
        public void EnsureStartsWith_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.EnsureStartsWith(WORD_LAST));

        [Fact]
        public void EnsureStartsWith_WithNullValue_Throws()
            => Throws<ArgumentNullException>(() => SENTENCE.EnsureStartsWith(NULL));

        [Fact]
        public void EnsureStartsWith_WithSentenceStringAndUnknownWord_ExpectsConcatenationAtStart()
            => Equal(
                WORD + SENTENCE,
                SENTENCE.EnsureStartsWith(WORD));

        [Fact]
        public void EnsureStartsWith_WithSentenceStringAndFirstWord_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.EnsureStartsWith(WORD_FIRST));

        #endregion EnsureStartsWith

        #region Reverse

        [Fact]
        public void Reverse_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.Reverse());

        [Fact]
        public void Reverse_WithWordString_ExpectsReversedWordString()
            => Equal(
                WORD_REVERSED,
                WORD.Reverse());

        #endregion Reverse

        #region SubstringFollowing

        [Fact]
        public void SubstringFollowing_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.SubstringFollowing(WORD));

        [Fact]
        public void SubstringFollowing_WithSentenceStringAndUnknownWord_Throws()
            => Throws<ArgumentOutOfRangeException>(() => SENTENCE.SubstringFollowing(WORD));

        [Fact]
        public void SubstringFollowing_WithSentenceStringAndEmptyString_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.SubstringFollowing(EMPTY));

        [Fact]
        public void SubstringFollowing_WithSentenceStringAndFirstWord_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.SubstringFollowing(WORD_FIRST));

        [Fact]
        public void SubstringFollowing_WithSentenceStringAndLastWord_ExpectsLastWord()
            => Equal(
                WORD_LAST,
                SENTENCE.SubstringFollowing(WORD_LAST));

        #endregion SubstringFollowing

        #region SubstringPreceding

        [Fact]
        public void SubstringPreceding_WithNullString_Throws()
            => Throws<ArgumentNullException>(() => NULL.SubstringPreceding(WORD));

        [Fact]
        public void SubstringPreceding_WithSentenceStringAndUnknownWord_Throws()
            => Throws<ArgumentOutOfRangeException>(() => SENTENCE.SubstringPreceding(WORD));

        [Fact]
        public void SubstringPreceding_WithSentenceStringAndEmptyString_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.SubstringPreceding(EMPTY));

        [Fact]
        public void SubstringPreceding_WithSentenceStringAndLastWord_ExpectsSentenceString()
            => Equal(
                SENTENCE,
                SENTENCE.SubstringPreceding(WORD_LAST));

        [Fact]
        public void SubstringPreceding_WithSentenceStringAndFirstWord_ExpectsFirstWord()
            => Equal(
                WORD_FIRST,
                SENTENCE.SubstringPreceding(WORD_FIRST));

        #endregion SubstringPreceding

        #region DefaultIfEmpty

        [Fact]
        public void DefaultIfEmpty_WithNullString_ExpectsDefaultString()
            => Equal(
                SENTENCE,
                NULL.DefaultIfEmpty(SENTENCE));

        [Fact]
        public void DefaultIfEmpty_WithEmptyString_ExpectsDefaultString()
            => Equal(
                SENTENCE,
                EMPTY.DefaultIfEmpty(SENTENCE));

        [Fact]
        public void DefaultIfEmpty_WithWhitespaceStringAndNotIgnoreWhitespace_ExpectsWhitespaceString()
            => Equal(
                SENTENCE_WHITESPACE,
                SENTENCE_WHITESPACE.DefaultIfEmpty(SENTENCE, false));

        [Fact]
        public void DefaultIfEmpty_WithWhitespaceStringAndDoIgnoreWhitespace_ExpectsDefaultString()
            => Equal(
                SENTENCE,
                SENTENCE_WHITESPACE.DefaultIfEmpty(SENTENCE, true));

        #endregion DefaultIfEmpty
    }
}