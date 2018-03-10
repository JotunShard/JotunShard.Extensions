using System;

namespace JotunShard.Extensions
{
    public abstract class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }

        public abstract string Format(string format, object arg, IFormatProvider formatProvider);
    }
}