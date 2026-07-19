namespace System.Runtime.ConstrainedExecution
{
	/// <summary>Instructs the native image generation service to prepare a method for inclusion in a constrained execution region (CER).</summary>
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
	public sealed class PrePrepareMethodAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.ConstrainedExecution.PrePrepareMethodAttribute" /> class.</summary>
		public PrePrepareMethodAttribute()
		{
		}
	}
}
namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Identifies the type description being bound to.</summary>
	/// <summary>Identifies the type description being bound to.</summary>
	[Serializable]
	public enum DESCKIND
	{
		/// <summary>Indicates that no match was found.</summary>
		/// <summary>Indicates that no match was found.</summary>
		DESCKIND_NONE,
		/// <summary>Indicates that a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure was returned.</summary>
		/// <summary>Indicates that a <see cref="T:System.Runtime.InteropServices.FUNCDESC" /> structure was returned.</summary>
		DESCKIND_FUNCDESC,
		/// <summary>Indicates that a <see langword="VARDESC" /> was returned.</summary>
		/// <summary>Indicates that a <see langword="VARDESC" /> was returned.</summary>
		DESCKIND_VARDESC,
		/// <summary>Indicates that a <see langword="TYPECOMP" /> was returned.</summary>
		/// <summary>Indicates that a <see langword="TYPECOMP" /> was returned.</summary>
		DESCKIND_TYPECOMP,
		/// <summary>Indicates that an <see langword="IMPLICITAPPOBJ" /> was returned.</summary>
		DESCKIND_IMPLICITAPPOBJ,
		/// <summary>Indicates an end-of-enumeration marker.</summary>
		DESCKIND_MAX
	}
}
