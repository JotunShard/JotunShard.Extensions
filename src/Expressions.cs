using System;
using System.Linq;
using System.Linq.Expressions;

namespace JotunShard.Extensions
{
#pragma warning disable S2436 // Classes and methods should not have too many generic parameters
    public static class Expressions
    {
        /// <summary>
        /// Redefinition of a function expression of 1 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TResult>(
            this Expression<Func<TArg1, TResult>> func, TArg1 arg1)
        {
            var boundParameters = new object[] { arg1, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with the binded values of arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TResult>(
            this Expression<Func<TArg1, TArg2, TResult>> func, TArg2 arg2)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TResult>(
            this Expression<Func<TArg1, TArg2, TResult>> func, TArg1 arg1, TArg2 arg2)
        {
            var boundParameters = new object[] { arg1, arg2, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TResult>> func, TArg3 arg3)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 32 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with the binded values of arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TResult>> func, TArg2 arg2, TArg3 arg3)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> func, TArg4 arg4)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 43 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> func, TArg3 arg3, TArg4 arg4)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with the binded values of arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func, TArg5 arg5)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 54 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 5432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with the binded values of arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg6 arg6)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 65 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 6543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 65432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with the binded values of arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 76 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 7654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 76543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with the binded values of arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 87 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 8765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 87654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 8765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with the binded values of arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 98 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 9876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 98765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 9876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 98765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with the binded values of arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 1098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 10987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 1098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 10987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 1098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with the binded values of arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 1110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 11109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 1110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 11109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 1110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 11109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with its arguments 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(11);
            var boundParameters = new object[] { arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 1211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 1211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 12111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 1211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 12111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 1211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 12111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 13 parameters with its arguments 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(12);
            var boundParameters = new object[] { arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with its arguments 1312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 13121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 1312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 13121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 1312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 13121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 1312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 13 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 14 parameters with its arguments 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(13);
            var boundParameters = new object[] { arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 13 parameters with its arguments 1413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with its arguments 141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 14131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 1413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 14131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 1413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 14131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 1413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 14131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 14 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 15 parameters with its arguments 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(14);
            var boundParameters = new object[] { arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 14 parameters with its arguments 1514 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(13);
            var boundParameters = new object[] { arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 13 parameters with its arguments 151413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with its arguments 15141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 1514131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 151413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 1514131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 15141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 151413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 1514131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 15141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 151413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 1514131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 15141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 15 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of a function expression of 16 parameters with its arguments 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(15);
            var boundParameters = new object[] { arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 15 parameters with its arguments 1615 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(14);
            var boundParameters = new object[] { arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 14 parameters with its arguments 161514 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(13);
            var boundParameters = new object[] { arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 13 parameters with its arguments 16151413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 12 parameters with its arguments 1615141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 11 parameters with its arguments 161514131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 10 parameters with its arguments 16151413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 9 parameters with its arguments 161514131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 8 parameters with its arguments 1615141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 7 parameters with its arguments 16151413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 6 parameters with its arguments 161514131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 5 parameters with its arguments 1615141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TArg4, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 4 parameters with its arguments 16151413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Func<TArg1, TArg2, TArg3, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 3 parameters with its arguments 161514131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Func<TArg1, TArg2, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 2 parameters with its arguments 1615141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Func<TArg1, TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = func.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Func<TArg1, TResult>>(innerFunc, newParameters);
        }

        /// <summary>
        /// Redefinition of a function expression of 16 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the function expression</typeparam>
        /// <param name="func">The targeted function expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Function with all the binded values</returns>
        public static Expression<Func<TResult>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>(
            this Expression<Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult>> func, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerFunc = Expression.Invoke(func, boundParameters);
            return Expression.Lambda<Func<TResult>>(innerFunc);
        }

        /// <summary>
        /// Redefinition of an action expression of 1 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1>(
            this Expression<Action<TArg1>> act, TArg1 arg1)
        {
            var boundParameters = new object[] { arg1, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 2 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Action with the binded values of arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2>(
            this Expression<Action<TArg1, TArg2>> act, TArg2 arg2)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2>(
            this Expression<Action<TArg1, TArg2>> act, TArg1 arg1, TArg2 arg2)
        {
            var boundParameters = new object[] { arg1, arg2, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 3 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Action with the binded values of arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3>(
            this Expression<Action<TArg1, TArg2, TArg3>> act, TArg3 arg3)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 32 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Action with the binded values of arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3>(
            this Expression<Action<TArg1, TArg2, TArg3>> act, TArg2 arg2, TArg3 arg3)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3>(
            this Expression<Action<TArg1, TArg2, TArg3>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 4 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Action with the binded values of arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4>> act, TArg4 arg4)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 43 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Action with the binded values of arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4>> act, TArg3 arg3, TArg4 arg4)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Action with the binded values of arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 5 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Action with the binded values of arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> act, TArg5 arg5)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 54 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Action with the binded values of arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> act, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Action with the binded values of arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 5432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Action with the binded values of arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 6 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with the binded values of arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg6 arg6)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 65 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with the binded values of arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with the binded values of arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 6543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with the binded values of arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 65432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with the binded values of arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 7 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 76 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 7654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 76543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with the binded values of arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 8 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 87 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 8765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 87654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 8765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with the binded values of arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 9 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 98 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 9876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 98765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 9876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 98765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with the binded values of arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 10 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 1098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 10987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 1098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 10987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 1098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with the binded values of arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 11 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 1110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 11109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 1110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 11109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 1110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 11109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with the binded values of arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with its arguments 12 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(11);
            var boundParameters = new object[] { arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 1211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 1211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 12111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 1211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 12111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 1211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 12111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with the binded values of arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
        /// <typeparam name="TArg4">The type of argument 4</typeparam>
        /// <typeparam name="TArg5">The type of argument 5</typeparam>
        /// <typeparam name="TArg6">The type of argument 6</typeparam>
        /// <typeparam name="TArg7">The type of argument 7</typeparam>
        /// <typeparam name="TArg8">The type of argument 8</typeparam>
        /// <typeparam name="TArg9">The type of argument 9</typeparam>
        /// <typeparam name="TArg10">The type of argument 10</typeparam>
        /// <typeparam name="TArg11">The type of argument 11</typeparam>
        /// <typeparam name="TArg12">The type of argument 12</typeparam>
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
        /// <param name="arg4">The provided value for the argument 4</param>
        /// <param name="arg5">The provided value for the argument 5</param>
        /// <param name="arg6">The provided value for the argument 6</param>
        /// <param name="arg7">The provided value for the argument 7</param>
        /// <param name="arg8">The provided value for the argument 8</param>
        /// <param name="arg9">The provided value for the argument 9</param>
        /// <param name="arg10">The provided value for the argument 10</param>
        /// <param name="arg11">The provided value for the argument 11</param>
        /// <param name="arg12">The provided value for the argument 12</param>
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 13 parameters with its arguments 13 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(12);
            var boundParameters = new object[] { arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with its arguments 1312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 13121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 1312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 13121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 1312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 13121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 1312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 13 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 14 parameters with its arguments 14 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(13);
            var boundParameters = new object[] { arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 13 parameters with its arguments 1413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with its arguments 141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 14131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 1413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 14131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 1413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 14131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 1413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 14131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 14 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 15 parameters with its arguments 15 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(14);
            var boundParameters = new object[] { arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 14 parameters with its arguments 1514 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(13);
            var boundParameters = new object[] { arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 13 parameters with its arguments 151413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with its arguments 15141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 1514131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 151413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 1514131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 15141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 151413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 1514131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 15141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 151413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 1514131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 15141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 15 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }

        /// <summary>
        /// Redefinition of an action expression of 16 parameters with its arguments 16 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(15);
            var boundParameters = new object[] { arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 15 parameters with its arguments 1615 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(14);
            var boundParameters = new object[] { arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 14 parameters with its arguments 161514 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(13);
            var boundParameters = new object[] { arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 13 parameters with its arguments 16151413 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(12);
            var boundParameters = new object[] { arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 12 parameters with its arguments 1615141312 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(11);
            var boundParameters = new object[] { arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 11 parameters with its arguments 161514131211 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(10);
            var boundParameters = new object[] { arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 10 parameters with its arguments 16151413121110 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(9);
            var boundParameters = new object[] { arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 9 parameters with its arguments 161514131211109 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(8);
            var boundParameters = new object[] { arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 8 parameters with its arguments 1615141312111098 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(7);
            var boundParameters = new object[] { arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 7 parameters with its arguments 16151413121110987 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(6);
            var boundParameters = new object[] { arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 6 parameters with its arguments 161514131211109876 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(5);
            var boundParameters = new object[] { arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4, TArg5>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 5 parameters with its arguments 1615141312111098765 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5</returns>
        public static Expression<Action<TArg1, TArg2, TArg3, TArg4>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(4);
            var boundParameters = new object[] { arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3, TArg4>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 4 parameters with its arguments 16151413121110987654 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4</returns>
        public static Expression<Action<TArg1, TArg2, TArg3>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(3);
            var boundParameters = new object[] { arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2, TArg3>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 3 parameters with its arguments 161514131211109876543 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3</returns>
        public static Expression<Action<TArg1, TArg2>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(2);
            var boundParameters = new object[] { arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1, TArg2>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 2 parameters with its arguments 1615141312111098765432 binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with the binded values of arg16arg15arg14arg13arg12arg11arg10arg9arg8arg7arg6arg5arg4arg3arg2</returns>
        public static Expression<Action<TArg1>> BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var newParameters = act.Parameters.Take(1);
            var boundParameters = new object[] { arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, newParameters.Cast<Expression>().Union(boundParameters));
            return Expression.Lambda<Action<TArg1>>(innerAct, newParameters);
        }

        /// <summary>
        /// Redefinition of an action expression of 16 parameters with all its arguments binded
        /// </summary>
        /// <typeparam name="TArg1">The type of argument 1</typeparam>
        /// <typeparam name="TArg2">The type of argument 2</typeparam>
        /// <typeparam name="TArg3">The type of argument 3</typeparam>
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
        /// <typeparam name="TResult">Resultant type of the action expression</typeparam>
        /// <param name="act">The targeted action expression</param>
        /// <param name="arg1">The provided value for the argument 1</param>
        /// <param name="arg2">The provided value for the argument 2</param>
        /// <param name="arg3">The provided value for the argument 3</param>
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
        /// <returns>Action with all the binded values</returns>
        public static BlockExpression BindParameters<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(
            this Expression<Action<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>> act, TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16)
        {
            var boundParameters = new object[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, }
                .Select(Expression.Constant);
            var innerAct = Expression.Invoke(act, boundParameters);
            return Expression.Block(innerAct);
        }
    }
#pragma warning restore S2436 // Classes and methods should not have too many generic parameters
}
