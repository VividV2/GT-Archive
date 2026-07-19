namespace System.Runtime.Serialization
{
	/// <summary>Enables serialization of custom exception data in security-transparent code.</summary>
	/// <summary>Enables serialization of custom exception data in security-transparent code.</summary>
	public interface ISafeSerializationData
	{
		/// <summary>This method is called when the instance is deserialized.</summary>
		/// <param name="deserialized">An object that contains the state of the instance.</param>
		/// <summary>This method is called when the instance is deserialized.</summary>
		/// <param name="deserialized">An object that contains the state of the instance.</param>
		void CompleteDeserialization(object deserialized);
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Provides a way for clients to access the actual object, rather than the adapter object handed out by a custom marshaler.</summary>
	/// <summary>Provides a way for clients to access the actual object, rather than the adapter object handed out by a custom marshaler.</summary>
	public interface ICustomAdapter
	{
		/// <summary>Provides access to the underlying object wrapped by a custom marshaler.</summary>
		/// <returns>The object contained by the adapter object.</returns>
		/// <summary>Provides access to the underlying object wrapped by a custom marshaler.</summary>
		/// <returns>The object contained by the adapter object.</returns>
		[return: MarshalAs(UnmanagedType.IUnknown)]
		object GetUnderlyingObject();
	}
}
