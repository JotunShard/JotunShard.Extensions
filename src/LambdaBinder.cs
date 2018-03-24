using System.Linq;
using System.Linq.Expressions;

namespace JotunShard.Extensions
{
    public class LambdaBinder : ExpressionVisitor
    {
        public static Expression Modify(Expression expr, params object[] boundParameterValues)
            => new LambdaBinder(boundParameterValues).Visit(expr);

        private readonly object[] boundParameterValues;

        private LambdaBinder(object[] boundParameterValues)
        {
            this.boundParameterValues = boundParameterValues;
        }

        protected override Expression VisitLambda<TDelegate>(Expression<TDelegate> node)
        {
            if (boundParameterValues.Length > 0)
            {
                boundParameterValues.CheckArgumentTooLarge(nameof(boundParameterValues), node.Parameters.Count);
                var newParameters = node.Parameters
                    .Take(node.Parameters.Count - boundParameterValues.Length);
                var boundParameters = boundParameterValues
                    .Select(Expression.Constant);
                var innerNode = Expression.Invoke(node, boundParameters);
                return Expression.Lambda(innerNode, newParameters);
            }
            return base.VisitLambda(node);
        }
    }
}