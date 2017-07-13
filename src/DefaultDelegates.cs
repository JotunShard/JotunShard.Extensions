using System;

namespace JotunShard.Extensions
{
    public static class DefaultDelegates<TValue>
    {
        public static Func<bool> TautologicalFunction => () => true;

        public static Func<bool> ContradictionalFunction => () => false;

        public static Predicate<TValue> TautologicalPredicate => value => true;

        public static Predicate<TValue> ContradictionalPredicate => value => false;

        public static Func<TValue, TValue> IdentityFunction => value => value;

        public static Action EmptyAction => () => { };

        public static Func<TValue> DefaultValue => () => default(TValue);
    }
}