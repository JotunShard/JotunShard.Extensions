using JetBrains.Annotations;

namespace JotunShard.Extensions
{
    public static class Objects
    {
        /// <summary>
        /// Predicate of the equality between instances or any of them being null
        /// </summary>
        /// <typeparam name="TObject">The targeted type</typeparam>
        /// <param name="self">The targeted subject</param>
        /// <param name="other">The subjected value</param>
        /// <returns>Condition of equality or being null</returns>
        public static bool EqualsOrNull<TObject>(
            [NotNull] this TObject self,
            TObject other)
            => ReferenceEquals(default(TObject), self)
                && ReferenceEquals(default(TObject), other)
                || Equals(self, other);
    }
}