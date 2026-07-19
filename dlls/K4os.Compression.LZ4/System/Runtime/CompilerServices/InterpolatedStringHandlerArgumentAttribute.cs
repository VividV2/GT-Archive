using System.Diagnostics.CodeAnalysis;

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
namespace K4os.Compression.LZ4.Internal
{
}
namespace K4os.Compression.LZ4.Internal
{
}
