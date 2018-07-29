using System;

namespace JotunShard.Extensions
{
    public abstract class CustomFormattable : IFormattable
    {
        public abstract CustomFormatProvider FormatProvider { get; }

        public string ToString(string format) => ToString(format, System.Globalization.CultureInfo.CurrentCulture);

        public string ToString(string format, IFormatProvider formatProvider)
            => FormatProvider.Format(format, this, formatProvider);
    }
}