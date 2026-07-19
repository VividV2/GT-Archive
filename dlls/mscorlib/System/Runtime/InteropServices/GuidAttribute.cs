namespace System.Runtime.InteropServices
{
	/// <summary>Supplies an explicit <see cref="T:System.Guid" /> when an automatic GUID is undesirable.</summary>
	/// <summary>Supplies an explicit <see cref="T:System.Guid" /> when an automatic GUID is undesirable.</summary>
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[ComVisible(true)]
	public sealed class GuidAttribute : Attribute
	{
		internal string _val;

		/// <summary>Gets the <see cref="T:System.Guid" /> of the class.</summary>
		/// <returns>The <see cref="T:System.Guid" /> of the class.</returns>
		/// <summary>Gets the <see cref="T:System.Guid" /> of the class.</summary>
		/// <returns>The <see cref="T:System.Guid" /> of the class.</returns>
		public string Value => _val;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.GuidAttribute" /> class with the specified GUID.</summary>
		/// <param name="guid">The <see cref="T:System.Guid" /> to be assigned.</param>
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.GuidAttribute" /> class with the specified GUID.</summary>
		/// <param name="guid">The <see cref="T:System.Guid" /> to be assigned.</param>
		public GuidAttribute(string guid)
		{
			_val = guid;
		}
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Specifies which <see cref="T:System.Type" /> exclusively uses an interface. This class cannot be inherited.</summary>
	/// <summary>Specifies which <see cref="T:System.Type" /> exclusively uses an interface. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibImportClassAttribute : Attribute
	{
		internal string _importClassName;

		/// <summary>Gets the name of a <see cref="T:System.Type" /> object that exclusively uses an interface.</summary>
		/// <returns>The name of a <see cref="T:System.Type" /> object that exclusively uses an interface.</returns>
		/// <summary>Gets the name of a <see cref="T:System.Type" /> object that exclusively uses an interface.</summary>
		/// <returns>The name of a <see cref="T:System.Type" /> object that exclusively uses an interface.</returns>
		public string Value => _importClassName;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.TypeLibImportClassAttribute" /> class specifying the <see cref="T:System.Type" /> that exclusively uses an interface.</summary>
		/// <param name="importClass">The <see cref="T:System.Type" /> object that exclusively uses an interface.</param>
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.TypeLibImportClassAttribute" /> class specifying the <see cref="T:System.Type" /> that exclusively uses an interface.</summary>
		/// <param name="importClass">The <see cref="T:System.Type" /> object that exclusively uses an interface.</param>
		public TypeLibImportClassAttribute(Type importClass)
		{
			_importClassName = importClass.ToString();
		}
	}
}
