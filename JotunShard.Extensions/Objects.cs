using JetBrains.Annotations;

namespace JotunShard.Extensions
{
    public static class Objects
    {
        public static bool EqualsOrNull<TObject>(
            [NotNull] this TObject self,
            TObject other)
            => ReferenceEquals(default(TObject), self)
                && ReferenceEquals(default(TObject), other)
                || Equals(self, other);
    }
}