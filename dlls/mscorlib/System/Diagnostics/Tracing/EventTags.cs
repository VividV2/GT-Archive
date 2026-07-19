namespace System.Diagnostics.CodeAnalysis
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
	public sealed class AllowNullAttribute : Attribute
	{
	}
}
namespace System.Diagnostics.Tracing
{
	/// <summary>Specifies the tracking of activity start and stop events. You should only use the lower 24 bits. For more information, see <see cref="T:System.Diagnostics.Tracing.EventSourceOptions" /> and <see cref="M:System.Diagnostics.Tracing.EventSource.Write(System.String,System.Diagnostics.Tracing.EventSourceOptions)" />.</summary>
	[Flags]
	public enum EventTags
	{
		/// <summary>Specifies no tag and is equal to zero.</summary>
		None = 0
	}
}
