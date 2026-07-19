using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
[ExcludeFromCodeCoverage]
internal sealed class RequiredMemberAttribute : Attribute
{
}
namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	[ExcludeFromCodeCoverage]
	internal sealed class InterpolatedStringHandlerArgumentAttribute : Attribute
	{
		public string[] Arguments { get; }

		public InterpolatedStringHandlerArgumentAttribute(string argument)
		{
			Arguments = new string[1] { argument };
		}

		public InterpolatedStringHandlerArgumentAttribute(params string[] arguments)
		{
			Arguments = arguments;
		}
	}
}
