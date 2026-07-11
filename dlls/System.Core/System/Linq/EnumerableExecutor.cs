using System.Linq.Expressions;

namespace System.Linq;

/// <summary>Represents an expression tree and provides functionality to execute the expression tree after rewriting it.</summary>
public abstract class EnumerableExecutor
{
	internal abstract object ExecuteBoxed();

	internal static EnumerableExecutor Create(Expression expression)
	{
		return (EnumerableExecutor)Activator.CreateInstance(typeof(EnumerableExecutor<>).MakeGenericType(expression.Type), expression);
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Linq.EnumerableExecutor" /> class.</summary>
	protected EnumerableExecutor()
	{
	}
}
