namespace System.Security
{
	/// <summary>Specifies the type of a managed code policy level.</summary>
	public enum PolicyLevelType
	{
		/// <summary>Security policy for all managed code in an application.</summary>
		AppDomain = 3,
		/// <summary>Security policy for all managed code in an enterprise.</summary>
		Enterprise = 2,
		Machine = 1,
		User = 0
	}
}
namespace System
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	internal class MonoDocumentationNoteAttribute : MonoTODOAttribute
	{
		public MonoDocumentationNoteAttribute(string comment)
			: base(comment)
		{
		}
	}
}
