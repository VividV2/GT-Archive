namespace System
{
	internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
	{
		string InternalName { get; }
	}
}
namespace System.Runtime.Hosting
{
}
