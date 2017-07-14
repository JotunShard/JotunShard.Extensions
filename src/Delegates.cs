using JetBrains.Annotations;
using System;

namespace JotunShard.Extensions
{
    public static class Delegates
    {
        /// <summary>
        /// Composition of a function of 1 parameters with its arguments 1 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <returns>Function with the binded values of arg1</returns>
        public static Func<TResult> Bind<TArg1, TResult>(
            [NotNull] this Func<TArg1, TResult> func, TArg1 arg1)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1);
        }

        /// <summary>
        /// Composition of a function of 2 parameters with its arguments 1, 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg1, arg2</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TResult>(
            [NotNull] this Func<TArg1, TArg2, TResult> func, TArg1 arg1, TArg2 arg2)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 1, 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 1, 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 1, 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 1, 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 1, 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg2</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TResult>(
            [NotNull] this Func<TArg1, TArg2, TResult> func, TArg2 arg2)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg2, arg3</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg2 arg2, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg3</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg3, arg4</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg4</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg4, arg5</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg5, arg6</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg6, arg7</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg7, arg8</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg8, arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg9, arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg10, arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg11, arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg12, arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg13</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg13, arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg13, arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg13, arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg14</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg14, arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg14, arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg15</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg15, arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg16</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 1 parameters with its arguments 1 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <returns>Function with the binded values of arg1</returns>
        public static Action Bind<TArg1>(
            [NotNull] this Action<TArg1> act, TArg1 arg1)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1);
        }

        /// <summary>
        /// Composition of a function of 2 parameters with its arguments 1, 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg1, arg2</returns>
        public static Action Bind<TArg1, TArg2>(
            [NotNull] this Action<TArg1, TArg2> act, TArg1 arg1, TArg2 arg2)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 1, 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3</returns>
        public static Action Bind<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 1, 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 1, 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 1, 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 1, 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg2</returns>
        public static Action<TArg1> Bind<TArg1, TArg2>(
            [NotNull] this Action<TArg1, TArg2> act, TArg2 arg2)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg2, arg3</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg2 arg2, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 3 parameters with its arguments 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg3</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg3, arg4</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 3, 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 4 parameters with its arguments 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg4</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg4, arg5</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 4, 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 4, 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 5 parameters with its arguments 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg5, arg6</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 5, 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 5, 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 5, 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 6 parameters with its arguments 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg6, arg7</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 6, 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 6, 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 6, 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 6, 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 7 parameters with its arguments 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg7, arg8</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 7, 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 7, 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 7, 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 7, 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 7, 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 8 parameters with its arguments 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 8, 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg8, arg9</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 8, 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 8, 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 8, 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 8, 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 8, 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 9 parameters with its arguments 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 9, 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg9, arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 9, 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 9, 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 9, 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 9, 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 9, 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 9, 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 10 parameters with its arguments 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 10, 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg10, arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 10, 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 10, 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 10, 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 10, 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 10, 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg10, arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 11 parameters with its arguments 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 11, 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg11, arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 11, 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 11, 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 11, 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 11, 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg11, arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 12 parameters with its arguments 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 12, 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg12, arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 12, 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 12, 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 12, 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg12, arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 13 parameters with its arguments 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <returns>Function with the binded values of arg13</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 13, 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg13, arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 13, 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg13, arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 13, 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg13, arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 14 parameters with its arguments 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <returns>Function with the binded values of arg14</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 14, 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg14, arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 14, 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg14, arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 15 parameters with its arguments 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <returns>Function with the binded values of arg15</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 15, 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg15, arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Composition of a function of 16 parameters with its arguments 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TArg13">The type of argument 13</typeparam>
        /// <typeparam name="TArg14">The type of argument 14</typeparam>
        /// <typeparam name="TArg15">The type of argument 15</typeparam>
        /// <typeparam name="TArg16">The type of argument 16</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <param name="arg13">The provided value for the argument 13</param>
        /// <param name="arg14">The provided value for the argument 14</param>
        /// <param name="arg15">The provided value for the argument 15</param>
        /// <param name="arg16">The provided value for the argument 16</param>
        /// <returns>Function with the binded values of arg16</returns>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> Bind<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }
    }
}