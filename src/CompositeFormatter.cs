using System;
using System.Collections.Generic;

namespace JotunShard.Extensions
{
    public class CompositeFormatter<TContainer> : CustomFormatProvider
    {
        private readonly IEnumerable<FieldFormatter<TContainer>> fields;

        public CompositeFormatter(IEnumerable<FieldFormatter<TContainer>> fields)
        {
            this.fields = fields;
        }

        public string Format(string format, object arg) => Format(format, arg, System.Globalization.CultureInfo.CurrentCulture);

        public override string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format.Length == 0 || arg == null || !(arg is TContainer cnt))
            {
                return string.Empty;
            }
            var result = new System.Text.StringBuilder();
            var startIndex = 0;
            while (startIndex < format.Length)
            {
                foreach (var f in fields)
                {
                    var fieldToken = f.Token;
                    var fieldAccessor = f.Accessor;
                    if (fieldToken.Length > format.Length)
                    {
                        continue;
                    }
                    if (format.StartsWith(fieldToken))
                    {
                        result.Append(fieldAccessor(cnt));
                        startIndex = 0;
                        format = format.Remove(0, fieldToken.Length);
                        break;
                    }
                }
                result.Append(format, startIndex, 1);
                startIndex++;
                format = format.Substring(startIndex);
            }
            return result.ToString();
        }
    }

    public struct FieldFormatter<TContainer>
    {
        public string Token { get; }

        public Func<TContainer, object> Accessor { get; }

        public FieldFormatter(string Token, Func<TContainer, object> Accessor)
        {
            this.Token = Token;
            this.Accessor = Accessor;
        }
    }
}