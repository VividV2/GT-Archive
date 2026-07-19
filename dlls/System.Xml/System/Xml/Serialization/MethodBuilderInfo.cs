using System.Reflection;
using System.Reflection.Emit;

namespace System.Xml.Serialization
{
	internal class MethodBuilderInfo
	{
		public readonly MethodBuilder MethodBuilder;

		public readonly Type[] ParameterTypes;

		public MethodBuilderInfo(MethodBuilder methodBuilder, Type[] parameterTypes)
		{
			MethodBuilder = methodBuilder;
			ParameterTypes = parameterTypes;
		}

		public void Validate(Type returnType, Type[] parameterTypes, MethodAttributes attributes)
		{
		}
	}
}
namespace System.Xml
{
	/// <summary>Represents the XML type for the string. This allows the string to be read as a particular XML type, for example a CDATA section type.</summary>
	/// <summary>Represents the XML type for the string. This allows the string to be read as a particular XML type, for example a CDATA section type.</summary>
	public enum XmlTokenizedType
	{
		/// <summary>CDATA type.</summary>
		/// <summary>CDATA type.</summary>
		CDATA,
		/// <summary>ID type.</summary>
		/// <summary>ID type.</summary>
		ID,
		/// <summary>IDREF type.</summary>
		/// <summary>IDREF type.</summary>
		IDREF,
		/// <summary>IDREFS type.</summary>
		/// <summary>IDREFS type.</summary>
		IDREFS,
		/// <summary>ENTITY type.</summary>
		/// <summary>ENTITY type.</summary>
		ENTITY,
		/// <summary>ENTITIES type.</summary>
		/// <summary>ENTITIES type.</summary>
		ENTITIES,
		/// <summary>NMTOKEN type.</summary>
		/// <summary>NMTOKEN type.</summary>
		NMTOKEN,
		/// <summary>NMTOKENS type.</summary>
		/// <summary>NMTOKENS type.</summary>
		NMTOKENS,
		/// <summary>NOTATION type.</summary>
		/// <summary>NOTATION type.</summary>
		NOTATION,
		/// <summary>ENUMERATION type.</summary>
		/// <summary>ENUMERATION type.</summary>
		ENUMERATION,
		/// <summary>QName type.</summary>
		/// <summary>QName type.</summary>
		QName,
		/// <summary>NCName type.</summary>
		/// <summary>NCName type.</summary>
		NCName,
		/// <summary>No type.</summary>
		/// <summary>No type.</summary>
		None
	}
}
namespace System.Xml.Xsl.XsltOld
{
}
namespace System.Xml
{
}
