namespace System.Reflection
{
	/// <summary>Specifies flags that describe the attributes of a field.</summary>
	/// <summary>Specifies flags that describe the attributes of a field.</summary>
	[Flags]
	public enum FieldAttributes
	{
		/// <summary>Specifies the access level of a given field.</summary>
		/// <summary>Specifies the access level of a given field.</summary>
		FieldAccessMask = 7,
		/// <summary>Specifies that the field cannot be referenced.</summary>
		/// <summary>Specifies that the field cannot be referenced.</summary>
		PrivateScope = 0,
		/// <summary>Specifies that the field is accessible only by the parent type.</summary>
		/// <summary>Specifies that the field is accessible only by the parent type.</summary>
		Private = 1,
		/// <summary>Specifies that the field is accessible only by subtypes in this assembly.</summary>
		/// <summary>Specifies that the field is accessible only by subtypes in this assembly.</summary>
		FamANDAssem = 2,
		/// <summary>Specifies that the field is accessible throughout the assembly.</summary>
		/// <summary>Specifies that the field is accessible throughout the assembly.</summary>
		Assembly = 3,
		/// <summary>Specifies that the field is accessible only by type and subtypes.</summary>
		/// <summary>Specifies that the field is accessible only by type and subtypes.</summary>
		Family = 4,
		/// <summary>Specifies that the field is accessible by subtypes anywhere, as well as throughout this assembly.</summary>
		/// <summary>Specifies that the field is accessible by subtypes anywhere, as well as throughout this assembly.</summary>
		FamORAssem = 5,
		/// <summary>Specifies that the field is accessible by any member for whom this scope is visible.</summary>
		/// <summary>Specifies that the field is accessible by any member for whom this scope is visible.</summary>
		Public = 6,
		/// <summary>Specifies that the field represents the defined type, or else it is per-instance.</summary>
		/// <summary>Specifies that the field represents the defined type, or else it is per-instance.</summary>
		Static = 0x10,
		/// <summary>Specifies that the field is initialized only, and can be set only in the body of a constructor.</summary>
		/// <summary>Specifies that the field is initialized only, and can be set only in the body of a constructor.</summary>
		InitOnly = 0x20,
		/// <summary>Specifies that the field's value is a compile-time (static or early bound) constant. Any attempt to set it throws a <see cref="T:System.FieldAccessException" />.</summary>
		/// <summary>Specifies that the field's value is a compile-time (static or early bound) constant. Any attempt to set it throws a <see cref="T:System.FieldAccessException" />.</summary>
		Literal = 0x40,
		/// <summary>Specifies that the field does not have to be serialized when the type is remoted.</summary>
		/// <summary>Specifies that the field does not have to be serialized when the type is remoted.</summary>
		NotSerialized = 0x80,
		/// <summary>Specifies a special method, with the name describing how the method is special.</summary>
		/// <summary>Specifies a special method, with the name describing how the method is special.</summary>
		SpecialName = 0x200,
		/// <summary>Reserved for future use.</summary>
		/// <summary>Reserved for future use.</summary>
		PinvokeImpl = 0x2000,
		/// <summary>Specifies that the common language runtime (metadata internal APIs) should check the name encoding.</summary>
		/// <summary>Specifies that the common language runtime (metadata internal APIs) should check the name encoding.</summary>
		RTSpecialName = 0x400,
		/// <summary>Specifies that the field has marshaling information.</summary>
		/// <summary>Specifies that the field has marshaling information.</summary>
		HasFieldMarshal = 0x1000,
		/// <summary>Specifies that the field has a default value.</summary>
		/// <summary>Specifies that the field has a default value.</summary>
		HasDefault = 0x8000,
		/// <summary>Specifies that the field has a relative virtual address (RVA). The RVA is the location of the method body in the current image, as an address relative to the start of the image file in which it is located.</summary>
		/// <summary>Specifies that the field has a relative virtual address (RVA). The RVA is the location of the method body in the current image, as an address relative to the start of the image file in which it is located.</summary>
		HasFieldRVA = 0x100,
		/// <summary>Reserved.</summary>
		/// <summary>Reserved.</summary>
		ReservedMask = 0x9500
	}
}
namespace System.Reflection
{
	/// <summary>Defines a key/value metadata pair for the decorated assembly.</summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class AssemblyMetadataAttribute : Attribute
	{
		/// <summary>Gets the metadata key.</summary>
		/// <returns>The metadata key.</returns>
		public string Key { get; }

		/// <summary>Gets the metadata value.</summary>
		/// <returns>The metadata value.</returns>
		public string Value { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyMetadataAttribute" /> class by using the specified metadata key and value.</summary>
		/// <param name="key">The metadata key.</param>
		/// <param name="value">The metadata value.</param>
		public AssemblyMetadataAttribute(string key, string value)
		{
			Key = key;
			Value = value;
		}
	}
}
