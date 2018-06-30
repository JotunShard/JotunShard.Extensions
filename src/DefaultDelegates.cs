using System;

namespace JotunShard.Extensions
{
    public static class DefaultDelegates
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
        /// <typeparam name="TValue"></typeparam>
        public static Predicate<TValue> TautologicalPredicate<TValue>() => _ => true;

        /// <summary>
        /// Definition of an always false predicate
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        public static Predicate<TValue> ContradictionalPredicate<TValue>() => _ => false;

        /// <summary>
        /// Definition of an function doing nothing
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        public static Func<TValue, TValue> IdentityFunction<TValue>() => value => value;

        /// <summary>
        /// Definition of an action doing nothing
        /// </summary>
        public static Action EmptyAction => () => { };

        /// <summary>
        /// Definition of a function always returning the default value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        public static Func<TValue> DefaultValue<TValue>() => () => default(TValue);
    }
}