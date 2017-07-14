using System;

namespace JotunShard.Extensions
{
    public static class DefaultDelegates<TValue>
    {
        /// <summary>
        /// Definition of an always true function
        /// </summary>
        public static Func<bool> TautologicalFunction => () => true;

        /// <summary>
        /// Definition of an always false function
        /// </summary>
        public static Func<bool> ContradictionalFunction => () => false;

        /// <summary>
        /// Definition of an always true predicate
        /// </summary>
        public static Predicate<TValue> TautologicalPredicate => value => true;

        /// <summary>
        /// Definition of an always false predicate
        /// </summary>
        public static Predicate<TValue> ContradictionalPredicate => value => false;

        /// <summary>
        /// Definition of an function doing nothing
        /// </summary>
        public static Func<TValue, TValue> IdentityFunction => value => value;

        /// <summary>
        /// Definition of an action doing nothing
        /// </summary>
        public static Action EmptyAction => () => { };

        /// <summary>
        /// Definition of a function always returning the default value
        /// </summary>
        public static Func<TValue> DefaultValue => () => default(TValue);
    }
}