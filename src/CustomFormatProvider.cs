using System;

namespace JotunShard.Extensions
{
    public abstract class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType) => formatType == typeof(ICustomFormatter) ? this : null;

        public abstract string Format(string format, object arg, IFormatProvider formatProvider);
    }
}