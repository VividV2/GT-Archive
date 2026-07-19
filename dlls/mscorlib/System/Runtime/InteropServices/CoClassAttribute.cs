namespace System
{
	/// <summary>Indicates that a field of a serializable class should not be serialized. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class NonSerializedAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.NonSerializedAttribute" /> class.</summary>
		public NonSerializedAttribute()
		{
		}
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.CONNECTDATA" /> instead.</summary>
	/// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.CONNECTDATA" /> instead.</summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.CONNECTDATA instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	public struct CONNECTDATA
	{
		/// <summary>Represents a pointer to the <see langword="IUnknown" /> interface on a connected advisory sink. The caller must call <see langword="IUnknown::Release" /> on this pointer when the <see langword="CONNECTDATA" /> structure is no longer needed.</summary>
		/// <summary>Represents a pointer to the <see langword="IUnknown" /> interface on a connected advisory sink. The caller must call <see langword="IUnknown::Release" /> on this pointer when the <see langword="CONNECTDATA" /> structure is no longer needed.</summary>
		[MarshalAs(UnmanagedType.Interface)]
		public object pUnk;

		/// <summary>Represents a connection token that is returned from a call to <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		/// <summary>Represents a connection token that is returned from a call to <see cref="M:System.Runtime.InteropServices.UCOMIConnectionPoint.Advise(System.Object,System.Int32@)" />.</summary>
		public int dwCookie;
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Specifies the class identifier of a coclass imported from a type library.</summary>
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class CoClassAttribute : Attribute
	{
		internal Type _CoClass;

		/// <summary>Gets the class identifier of the original coclass.</summary>
		/// <returns>A <see cref="T:System.Type" /> containing the class identifier of the original coclass.</returns>
		public Type CoClass => _CoClass;

		/// <summary>Initializes new instance of the <see cref="T:System.Runtime.InteropServices.CoClassAttribute" /> with the class identifier of the original coclass.</summary>
		/// <param name="coClass">A <see cref="T:System.Type" /> that contains the class identifier of the original coclass.</param>
		public CoClassAttribute(Type coClass)
		{
			_CoClass = coClass;
		}
	}
}
