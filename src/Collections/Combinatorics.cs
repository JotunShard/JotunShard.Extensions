using System.Collections.Generic;
using System.Linq;

namespace JotunShard.Extensions
{
    public static class Combinatorics
    {
        public static IEnumerable<IEnumerable<TElem>> ToAllCombinations<TElem>(
            this IEnumerable<TElem> source)
        {
            source.CheckArgumentNull(nameof(source));
            using (var enmrtr = source.GetEnumerator())
            {
                if (!enmrtr.MoveNext()) yield break;
                var firstElement = enmrtr.Current;
                if (!enmrtr.MoveNext())
                {
                    yield return source;
                    yield break;
                }
                var secondElement = enmrtr.Current;
                var oldCombinations = new List<IEnumerable<TElem>>();
                var firstPassDone = false;
                var secondPassDone = false;
                while (true)
                {
                    var element = firstPassDone
                        ? secondPassDone
                            ? enmrtr.Current
                            : secondElement
                        : firstElement;
                    var combinationOfOne = new[] { element };
                    yield return combinationOfOne;
                    var newCombinations = new List<IEnumerable<TElem>>();
                    foreach (var combination in oldCombinations)
                    {
                        var newCombination = combination.Union(combinationOfOne);
                        yield return newCombination;
                        newCombinations.Add(newCombination);
                    }
                    oldCombinations.AddRange(newCombinations);
                    oldCombinations.Add(combinationOfOne);
                    if (firstPassDone)
                    {
                        secondPassDone = true;
                    }
                    else if (!secondPassDone)
                    {
                        firstPassDone = true;
                        continue;
                    }
                    if (!enmrtr.MoveNext())
                    {
                        break;
                    }
                }
            }
        }
    }
}