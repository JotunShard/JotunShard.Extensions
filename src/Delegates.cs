using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace JotunShard.Extensions
{
#pragma warning disable S2436 // Classes and methods should not have too many generic parameters
    public static class Delegates
    {
        /// <summary>
        /// Redefinition of a function of 1 parameters with its arguments 1 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <returns>Function with the binded values of arg1</returns>
        public static Func<TResult>
            BindParameters<TArg1, TResult>(
            [NotNull] this Func<TArg1, TResult> func, TArg1 arg1)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1);
        }

        /// <summary>
        /// Redefinition of a function of 2 parameters with its arguments 1, 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg1, arg2</returns>
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TResult>(
            [NotNull] this Func<TArg1, TArg2, TResult> func, TArg1 arg1, TArg2 arg2)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2);
        }

        /// <summary>
        /// Redefinition of a function of 3 parameters with its arguments 1, 2, 3 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of a function of 4 parameters with its arguments 1, 2, 3, 4 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of a function of 5 parameters with its arguments 1, 2, 3, 4, 5 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 1, 2, 3, 4, 5, 6 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 1, 2, 3, 4, 5, 6, 7 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function</typeparam>
        /// <param name="func">The targeted function</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg2</returns>
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TResult>(
            [NotNull] this Func<TArg1, TArg2, TResult> func, TArg2 arg2)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2);
        }

        /// <summary>
        /// Redefinition of a function of 3 parameters with its arguments 2, 3 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg2 arg2, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of a function of 4 parameters with its arguments 2, 3, 4 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of a function of 5 parameters with its arguments 2, 3, 4, 5 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 2, 3, 4, 5, 6 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 2, 3, 4, 5, 6, 7 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 2, 3, 4, 5, 6, 7, 8 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 3 parameters with its arguments 3 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TResult> func, TArg3 arg3)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of a function of 4 parameters with its arguments 3, 4 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg3 arg3, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of a function of 5 parameters with its arguments 3, 4, 5 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 3, 4, 5, 6 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 3, 4, 5, 6, 7 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 3, 4, 5, 6, 7, 8 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 3, 4, 5, 6, 7, 8, 9 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 4 parameters with its arguments 4 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TResult> func, TArg4 arg4)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of a function of 5 parameters with its arguments 4, 5 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg4 arg4, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 4, 5, 6 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 4, 5, 6, 7 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 4, 5, 6, 7, 8 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 4, 5, 6, 7, 8, 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 4, 5, 6, 7, 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 5 parameters with its arguments 5 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> func, TArg5 arg5)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 5, 6 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg5 arg5, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 5, 6, 7 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 5, 6, 7, 8 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 5, 6, 7, 8, 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 5, 6, 7, 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 5, 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 6 parameters with its arguments 6 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> func, TArg6 arg6)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 6, 7 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg6 arg6, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 6, 7, 8 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 6, 7, 8, 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 6, 7, 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 6, 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 6, 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 7 parameters with its arguments 7 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> func, TArg7 arg7)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 7, 8 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg7 arg7, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 7, 8, 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 7, 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 7, 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 7, 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 7, 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 8 parameters with its arguments 8 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> func, TArg8 arg8)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 8, 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg8 arg8, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 8, 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 8, 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 8, 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 8, 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 8, 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 9 parameters with its arguments 9 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> func, TArg9 arg9)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 9, 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg9 arg9, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 9, 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 9, 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 9, 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 9, 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 9, 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 10 parameters with its arguments 10 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> func, TArg10 arg10)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 10, 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg10 arg10, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 10, 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 10, 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 10, 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 10, 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 10, 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 11 parameters with its arguments 11 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> func, TArg11 arg11)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 11, 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg11 arg11, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 11, 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 11, 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 11, 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 11, 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 12 parameters with its arguments 12 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> func, TArg12 arg12)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 12, 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg12 arg12, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 12, 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 12, 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 12, 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 13 parameters with its arguments 13 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> func, TArg13 arg13)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 13, 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg13 arg13, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 13, 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 13, 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 14 parameters with its arguments 14 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> func, TArg14 arg14)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 14, 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg14 arg14, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 14, 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 15 parameters with its arguments 15 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> func, TArg15 arg15)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 15, 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg15 arg15, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of a function of 16 parameters with its arguments 16 binded
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
        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> func, TArg16 arg16)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 1 parameters with its arguments 1 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        public static Action
            BindParameters<TArg1>(
            [NotNull] this Action<TArg1> act, TArg1 arg1)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1);
        }

        /// <summary>
        /// Redefinition of an action of 2 parameters with its arguments 1, 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        public static Action
            BindParameters<TArg1, TArg2>(
            [NotNull] this Action<TArg1, TArg2> act, TArg1 arg1, TArg2 arg2)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2);
        }

        /// <summary>
        /// Redefinition of an action of 3 parameters with its arguments 1, 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of an action of 4 parameters with its arguments 1, 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of an action of 5 parameters with its arguments 1, 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 1, 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 1, 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return () => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2>(
            [NotNull] this Action<TArg1, TArg2> act, TArg2 arg2)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2);
        }

        /// <summary>
        /// Redefinition of an action of 3 parameters with its arguments 2, 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg2 arg2, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of an action of 4 parameters with its arguments 2, 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of an action of 5 parameters with its arguments 2, 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 2, 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 2, 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 2, 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 3 parameters with its arguments 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act, TArg3 arg3)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3);
        }

        /// <summary>
        /// Redefinition of an action of 4 parameters with its arguments 3, 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg3 arg3, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of an action of 5 parameters with its arguments 3, 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 3, 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 3, 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 3, 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 3, 4, 5, 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 4 parameters with its arguments 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act, TArg4 arg4)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4);
        }

        /// <summary>
        /// Redefinition of an action of 5 parameters with its arguments 4, 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg4 arg4, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 4, 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 4, 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 4, 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 4, 5, 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 4, 5, 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 5 parameters with its arguments 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act, TArg5 arg5)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 5, 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg5 arg5, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 5, 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 5, 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 5, 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 5, 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 5, 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 6 parameters with its arguments 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act, TArg6 arg6)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 6, 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg6 arg6, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 6, 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 6, 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 6, 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 6, 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 6, 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 7 parameters with its arguments 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act, TArg7 arg7)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 7, 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg7 arg7, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 7, 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 7, 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 7, 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 7, 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 7, 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 8 parameters with its arguments 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> act, TArg8 arg8)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 8, 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg8 arg8, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 8, 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 8, 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 8, 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 8, 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 8, 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 8, 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 9 parameters with its arguments 9 binded
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
        /// <param name="act">The targeted action</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> act, TArg9 arg9)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 9, 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg9 arg9, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 9, 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 9, 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 9, 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 9, 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 9, 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 9, 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 10 parameters with its arguments 10 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> act, TArg10 arg10)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 10, 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg10 arg10, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 10, 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 10, 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 10, 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 10, 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 10, 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 11 parameters with its arguments 11 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> act, TArg11 arg11)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 11, 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg11 arg11, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 11, 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 11, 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 11, 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 11, 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 12 parameters with its arguments 12 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> act, TArg12 arg12)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 12, 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg12 arg12, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 12, 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 12, 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 12, 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 13 parameters with its arguments 13 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> act, TArg13 arg13)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 13, 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg13 arg13, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 13, 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 13, 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 14 parameters with its arguments 14 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> act, TArg14 arg14)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 14, 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg14 arg14, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 14, 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 15 parameters with its arguments 15 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> act, TArg15 arg15)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 15, 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg15 arg15, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        /// <summary>
        /// Redefinition of an action of 16 parameters with its arguments 16 binded
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
        /// <param name="act">The targeted action</param>
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
        public static Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
            BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> act, TArg16 arg16)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => act(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<TArg1, TArg1>
            AsFluent<TArg1>(
            [NotNull] this Action<TArg1> act)
        {
            act.CheckArgumentNull(nameof(act));
            return arg1 =>
            {
                act(arg1);
                return arg1;
            };
        }

        public static Func<TArg1, TArg2, Tuple<TArg1, TArg2>>
            AsFluent<TArg1, TArg2>(
            [NotNull] this Action<TArg1, TArg2> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2) =>
            {
                act(arg1, arg2);
                return Tuple.Create(arg1, arg2);
            };
        }

        public static Func<TArg1, TArg2, TArg3, Tuple<TArg1, TArg2, TArg3>>
            AsFluent<TArg1, TArg2, TArg3>(
            [NotNull] this Action<TArg1, TArg2, TArg3> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3) =>
            {
                act(arg1, arg2, arg3);
                return Tuple.Create(arg1, arg2, arg3);
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, Tuple<TArg1, TArg2, TArg3, TArg4>>
            AsFluent<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4) =>
            {
                act(arg1, arg2, arg3, arg4);
                return Tuple.Create(arg1, arg2, arg3, arg4);
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>>
            AsFluent<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                act(arg1, arg2, arg3, arg4, arg5);
                return Tuple.Create(arg1, arg2, arg3, arg4, arg5);
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>
            AsFluent<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                act(arg1, arg2, arg3, arg4, arg5, arg6);
                return Tuple.Create(arg1, arg2, arg3, arg4, arg5, arg6);
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>
            AsFluent<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> act)
        {
            act.CheckArgumentNull(nameof(act));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                act(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                return Tuple.Create(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            };
        }

        public static IEnumerable<TArg1>
            ToGenerator<TArg1>(
            [NotNull] this Func<TArg1, TArg1> func,
            TArg1 seed = default(TArg1))
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed); ;
                value = func(value))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2>>
            ToGenerator<TArg1, TArg2>(
            [NotNull] this Func<TArg1, TArg2, Tuple<TArg1, TArg2>> func,
            Tuple<TArg1, TArg2> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2); ;
                value = func(value.Item1, value.Item2))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3>>
            ToGenerator<TArg1, TArg2, TArg3>(
            [NotNull] this Func<TArg1, TArg2, TArg3, Tuple<TArg1, TArg2, TArg3>> func,
            Tuple<TArg1, TArg2, TArg3> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3); ;
                value = func(value.Item1, value.Item2, value.Item3))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, Tuple<TArg1, TArg2, TArg3, TArg4>> func,
            Tuple<TArg1, TArg2, TArg3, TArg4> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3, seed.Item4); ;
                value = func(value.Item1, value.Item2, value.Item3, value.Item4))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>> func,
            Tuple<TArg1, TArg2, TArg3, TArg4, TArg5> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3, seed.Item4, seed.Item5); ;
                value = func(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> func,
            Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3, seed.Item4, seed.Item5, seed.Item6); ;
                value = func(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> func,
            Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3, seed.Item4, seed.Item5, seed.Item6, seed.Item7); ;
                value = func(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> func,
            Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> seed)
        {
            func.CheckArgumentNull(nameof(func));
            for (var value = func(seed.Item1, seed.Item2, seed.Item3, seed.Item4, seed.Item5, seed.Item6, seed.Item7, seed.Rest); ;
                value = func(value.Item1, value.Item2, value.Item3, value.Item4, value.Item5, value.Item6, value.Item7, value.Rest))
            {
                yield return value;
            }
        }

        public static IEnumerable<Tuple<TArg1, TArg2>>
            ToGenerator<TArg1, TArg2>(
            [NotNull] this Func<TArg1, TArg2, Tuple<TArg1, TArg2>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3>>
            ToGenerator<TArg1, TArg2, TArg3>(
            [NotNull] this Func<TArg1, TArg2, TArg3, Tuple<TArg1, TArg2, TArg3>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2), default(TArg3)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, Tuple<TArg1, TArg2, TArg3, TArg4>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2), default(TArg3), default(TArg4)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2), default(TArg3), default(TArg4), default(TArg5)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2), default(TArg3), default(TArg4), default(TArg5), default(TArg6)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> func)
            => func.ToGenerator(Tuple.Create(default(TArg1), default(TArg2), default(TArg3), default(TArg4), default(TArg5), default(TArg6), default(TArg7)));

        public static IEnumerable<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>
            ToGenerator<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> func)
            => func.ToGenerator(new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(default(TArg1), default(TArg2), default(TArg3), default(TArg4), default(TArg5), default(TArg6), default(TArg7), default(TArg8)));

        public struct Bounce<TArg1, TResult>
        {
            public TArg1 Param1 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1) : this()
            {
                Param1 = param1;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2) : this()
            {
                Param1 = param1;
                Param2 = param2;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public TArg12 Param12 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11, TArg12 param12) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                Param12 = param12;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public TArg12 Param12 { get; }

            public TArg13 Param13 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11, TArg12 param12, TArg13 param13) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                Param12 = param12;
                Param13 = param13;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public TArg12 Param12 { get; }

            public TArg13 Param13 { get; }

            public TArg14 Param14 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11, TArg12 param12, TArg13 param13, TArg14 param14) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                Param12 = param12;
                Param13 = param13;
                Param14 = param14;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public TArg12 Param12 { get; }

            public TArg13 Param13 { get; }

            public TArg14 Param14 { get; }

            public TArg15 Param15 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11, TArg12 param12, TArg13 param13, TArg14 param14, TArg15 param15) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                Param12 = param12;
                Param13 = param13;
                Param14 = param14;
                Param15 = param15;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public struct Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>
        {
            public TArg1 Param1 { get; }

            public TArg2 Param2 { get; }

            public TArg3 Param3 { get; }

            public TArg4 Param4 { get; }

            public TArg5 Param5 { get; }

            public TArg6 Param6 { get; }

            public TArg7 Param7 { get; }

            public TArg8 Param8 { get; }

            public TArg9 Param9 { get; }

            public TArg10 Param10 { get; }

            public TArg11 Param11 { get; }

            public TArg12 Param12 { get; }

            public TArg13 Param13 { get; }

            public TArg14 Param14 { get; }

            public TArg15 Param15 { get; }

            public TArg16 Param16 { get; }

            public bool HasResult { get; }

            public TResult Result { get; }

            internal Bounce(TArg1 param1, TArg2 param2, TArg3 param3, TArg4 param4, TArg5 param5, TArg6 param6, TArg7 param7, TArg8 param8, TArg9 param9, TArg10 param10, TArg11 param11, TArg12 param12, TArg13 param13, TArg14 param14, TArg15 param15, TArg16 param16) : this()
            {
                Param1 = param1;
                Param2 = param2;
                Param3 = param3;
                Param4 = param4;
                Param5 = param5;
                Param6 = param6;
                Param7 = param7;
                Param8 = param8;
                Param9 = param9;
                Param10 = param10;
                Param11 = param11;
                Param12 = param12;
                Param13 = param13;
                Param14 = param14;
                Param15 = param15;
                Param16 = param16;
                HasResult = false;
            }

            internal Bounce(TResult result) : this()
            {
                Result = result;
                HasResult = true;
            }
        }

        public static class Trampoline
        {
            public static Bounce<TArg1, TResult>
                ReturnResult<TArg1, TResult>(TResult result)
                => new Bounce<TArg1, TResult>(result);

            public static Bounce<TArg1, TArg2, TResult>
                ReturnResult<TArg1, TArg2, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(result);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>
                ReturnResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(TResult result)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(result);

            public static Bounce<TArg1, TResult>
                Recurse<TArg1, TResult>(TArg1 arg1)
                => new Bounce<TArg1, TResult>(arg1);

            public static Bounce<TArg1, TArg2, TResult>
                Recurse<TArg1, TArg2, TResult>(TArg1 arg1, TArg2 arg2)
                => new Bounce<TArg1, TArg2, TResult>(arg1, arg2);

            public static Bounce<TArg1, TArg2, TArg3, TResult>
                Recurse<TArg1, TArg2, TArg3, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3)
                => new Bounce<TArg1, TArg2, TArg3, TResult>(arg1, arg2, arg3);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TResult>(arg1, arg2, arg3, arg4);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(arg1, arg2, arg3, arg4, arg5);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(arg1, arg2, arg3, arg4, arg5, arg6);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

            public static Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>
                Recurse<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
                => new Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }

        public static Func<TArg1, TResult>
            ToTrampoline<TArg1, TResult>(
            [NotNull] this Func<TArg1, Bounce<TArg1, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) =>
            {
                for (var value = func(arg1); ;
                    value = func(value.Param1))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TResult>
            ToTrampoline<TArg1, TArg2, TResult>(
            [NotNull] this Func<TArg1, TArg2, Bounce<TArg1, TArg2, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) =>
            {
                for (var value = func(arg1, arg2); ;
                    value = func(value.Param1, value.Param2))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, Bounce<TArg1, TArg2, TArg3, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) =>
            {
                for (var value = func(arg1, arg2, arg3); ;
                    value = func(value.Param1, value.Param2, value.Param3))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, Bounce<TArg1, TArg2, TArg3, TArg4, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11, value.Param12))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11, value.Param12, value.Param13))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11, value.Param12, value.Param13, value.Param14))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11, value.Param12, value.Param13, value.Param14, value.Param15))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>
            ToTrampoline<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, Bounce<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                for (var value = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16); ;
                    value = func(value.Param1, value.Param2, value.Param3, value.Param4, value.Param5, value.Param6, value.Param7, value.Param8, value.Param9, value.Param10, value.Param11, value.Param12, value.Param13, value.Param14, value.Param15, value.Param16))
                {
                    if (value.HasResult)
                    {
                        return value.Result;
                    }
                }
            };
        }

        public static Func<TArg1, bool>
            Not<TArg1>(
            [NotNull] this Func<TArg1, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1) => !func(arg1);
        }

        public static Func<TArg1, TArg2, bool>
            Not<TArg1, TArg2>(
            [NotNull] this Func<TArg1, TArg2, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2) => !func(arg1, arg2);
        }

        public static Func<TArg1, TArg2, TArg3, bool>
            Not<TArg1, TArg2, TArg3>(
            [NotNull] this Func<TArg1, TArg2, TArg3, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3) => !func(arg1, arg2, arg3);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, bool>
            Not<TArg1, TArg2, TArg3, TArg4>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4) => !func(arg1, arg2, arg3, arg4);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5) => !func(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6) => !func(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        }

        public static Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, bool>
            Not<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            [NotNull] this Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, bool> func)
        {
            func.CheckArgumentNull(nameof(func));
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => !func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        }
    }
#pragma warning restore S2436 // Classes and methods should not have too many generic parameters
}