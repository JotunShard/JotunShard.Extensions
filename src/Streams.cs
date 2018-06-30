using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JotunShard.Extensions
{
    public static class Streams
    {
        public static IEnumerable<string> ReadLines(this TextReader reader)
        {
            reader.CheckArgumentNull(nameof(reader));
            for (string line; ((line = reader.ReadLine()) != null);)
            {
                yield return line;
            }
        }

        public static Task<string[]> ReadLinesAsync(this TextReader reader)
        {
            IEnumerable<Task<string>> GetAsyncLines()
            {
                for (Task<string> line; ((line = reader.ReadLineAsync()) != null);)
                {
                    yield return line;
                }
            }

            reader.CheckArgumentNull(nameof(reader));
            return Task.WhenAll(GetAsyncLines());
        }

        public static void WriteLines(this TextWriter writer, IEnumerable<string> lines)
        {
            writer.CheckArgumentNull(nameof(writer));
            lines.CheckArgumentNull(nameof(lines));
            foreach (var line in lines)
            {
                writer.WriteLineAsync(line);
            }
        }

        public static async Task WriteLinesAsync(this TextWriter writer, IEnumerable<string> lines)
        {
            writer.CheckArgumentNull(nameof(writer));
            lines.CheckArgumentNull(nameof(lines));
            foreach (var line in lines)
            {
                await writer.WriteLineAsync(line).ConfigureAwait(false);
            }
        }
    }
}