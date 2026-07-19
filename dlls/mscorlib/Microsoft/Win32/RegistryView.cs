namespace Microsoft.Win32
{
	/// <summary>Specifies which registry view to target on a 64-bit operating system.</summary>
	/// <summary>Specifies which registry view to target on a 64-bit operating system.</summary>
	public enum RegistryView
	{
		/// <summary>The default view.</summary>
		Default = 0,
		/// <summary>The 64-bit view.</summary>
		Registry64 = 0x100,
		/// <summary>The 32-bit view.</summary>
		Registry32 = 0x200
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Enables users to write activation code for managed objects that extend <see cref="T:System.MarshalByRefObject" />.</summary>
	public interface ICustomFactory
	{
		/// <summary>Creates a new instance of the specified type.</summary>
		/// <param name="serverType">The type to activate.</param>
		/// <returns>A <see cref="T:System.MarshalByRefObject" /> associated with the specified type.</returns>
		MarshalByRefObject CreateInstance(Type serverType);
	}
}
