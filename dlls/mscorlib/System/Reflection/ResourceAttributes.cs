namespace System.Reflection
{
	/// <summary>Specifies the attributes for a manifest resource.</summary>
	[Flags]
	public enum ResourceAttributes
	{
		/// <summary>A mask used to retrieve public manifest resources.</summary>
		Public = 1,
		/// <summary>A mask used to retrieve private manifest resources.</summary>
		Private = 2
	}
}
namespace System.Reflection
{
	/// <summary>Represents a type that you can reflect over.</summary>
	public interface IReflectableType
	{
		/// <summary>Retrieves an object that represents this type.</summary>
		/// <returns>An object that represents this type.</returns>
		TypeInfo GetTypeInfo();
	}
}
