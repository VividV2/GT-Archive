using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Describes how to transfer a structure element, parameter, or function return value between processes.</summary>
	/// <summary>Describes how to transfer a structure element, parameter, or function return value between processes.</summary>
	/// <summary>Describes how to transfer a structure element, parameter, or function return value between processes.</summary>
	[Serializable]
	[Flags]
	public enum IDLFLAG : short
	{
		/// <summary>Does not specify whether the parameter passes or receives information.</summary>
		/// <summary>Does not specify whether the parameter passes or receives information.</summary>
		/// <summary>Does not specify whether the parameter passes or receives information.</summary>
		IDLFLAG_NONE = 0,
		/// <summary>The parameter passes information from the caller to the callee.</summary>
		/// <summary>The parameter passes information from the caller to the callee.</summary>
		/// <summary>The parameter passes information from the caller to the callee.</summary>
		IDLFLAG_FIN = 1,
		/// <summary>The parameter returns information from the callee to the caller.</summary>
		/// <summary>The parameter returns information from the callee to the caller.</summary>
		/// <summary>The parameter returns information from the callee to the caller.</summary>
		IDLFLAG_FOUT = 2,
		/// <summary>The parameter is the local identifier of a client application.</summary>
		/// <summary>The parameter is the local identifier of a client application.</summary>
		/// <summary>The parameter is the local identifier of a client application.</summary>
		IDLFLAG_FLCID = 4,
		/// <summary>The parameter is the return value of the member.</summary>
		/// <summary>The parameter is the return value of the member.</summary>
		/// <summary>The parameter is the return value of the member.</summary>
		IDLFLAG_FRETVAL = 8
	}
}
namespace System.Runtime.InteropServices.ComTypes
{
	[Guid("AFBF15E5-C37C-11d2-B88E-00A0C9B471B8")]
	internal interface IReflect
	{
		Type UnderlyingSystemType { get; }

		MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);

		MethodInfo GetMethod(string name, BindingFlags bindingAttr);

		MethodInfo[] GetMethods(BindingFlags bindingAttr);

		FieldInfo GetField(string name, BindingFlags bindingAttr);

		FieldInfo[] GetFields(BindingFlags bindingAttr);

		PropertyInfo GetProperty(string name, BindingFlags bindingAttr);

		PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

		PropertyInfo[] GetProperties(BindingFlags bindingAttr);

		MemberInfo[] GetMember(string name, BindingFlags bindingAttr);

		MemberInfo[] GetMembers(BindingFlags bindingAttr);

		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);
	}
}
