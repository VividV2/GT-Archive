using System.Reflection.Emit;

namespace System.Runtime.InteropServices;

/// <summary>Exposes the <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> class to unmanaged code.</summary>
[CLSCompliant(false)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ED3E4384-D7E2-3FA7-8FFD-8940D330519A")]
[TypeLibImportClass(typeof(ConstructorBuilder))]
[ComVisible(true)]
public interface _ConstructorBuilder
{
	/// <summary>Maps a set of names to a corresponding set of dispatch identifiers.</summary>
	/// <param name="riid">Reserved for future use. Must be IID_NULL.</param>
	/// <param name="rgszNames">An array of names to be mapped.</param>
	/// <param name="cNames">The count of the names to be mapped.</param>
	/// <param name="lcid">The locale context in which to interpret the names.</param>
	/// <param name="rgDispId">An array allocated by the caller that receives the identifiers corresponding to the names.</param>
	void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

	/// <summary>Retrieves the type information for an object, which can be used to get the type information for an interface.</summary>
	/// <param name="iTInfo">The type information to return.</param>
	/// <param name="lcid">The locale identifier for the type information.</param>
	/// <param name="ppTInfo">A pointer to the requested type information object.</param>
	void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

	/// <summary>Retrieves the number of type information interfaces that an object provides (either 0 or 1).</summary>
	/// <param name="pcTInfo">When this method returns, contains a pointer to a location that receives the number of type information interfaces provided by the object. This parameter is passed uninitialized.</param>
	void GetTypeInfoCount(out uint pcTInfo);

	/// <summary>Provides access to properties and methods exposed by an object.</summary>
	/// <param name="dispIdMember">An identifier of a member.</param>
	/// <param name="riid">Reserved for future use. Must be IID_NULL.</param>
	/// <param name="lcid">The locale context in which to interpret arguments.</param>
	/// <param name="wFlags">Flags describing the context of the call.</param>
	/// <param name="pDispParams">A pointer to a structure containing an array of arguments, an array of argument DISPIDs for named arguments, and counts for the number of elements in the arrays.</param>
	/// <param name="pVarResult">A pointer to the location where the result will be stored.</param>
	/// <param name="pExcepInfo">A pointer to a structure that contains exception information.</param>
	/// <param name="puArgErr">The index of the first argument that has an error.</param>
	void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
}
namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[CLSCompliant(false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("BCA8B44D-AAD6-3A86-8AB7-03349F4F2DA2")]
	[TypeLibImportClass(typeof(Type))]
	public interface _Type
	{
		MemberTypes MemberType { get; }

		string Name { get; }

		Type DeclaringType { get; }

		Type ReflectedType { get; }

		Guid GUID { get; }

		Module Module { get; }

		Assembly Assembly { get; }

		RuntimeTypeHandle TypeHandle { get; }

		string FullName { get; }

		string Namespace { get; }

		string AssemblyQualifiedName { get; }

		Type BaseType { get; }

		Type UnderlyingSystemType { get; }

		ConstructorInfo TypeInitializer { get; }

		TypeAttributes Attributes { get; }

		bool IsNotPublic { get; }

		bool IsPublic { get; }

		bool IsNestedPublic { get; }

		bool IsNestedPrivate { get; }

		bool IsNestedFamily { get; }

		bool IsNestedAssembly { get; }

		bool IsNestedFamANDAssem { get; }

		bool IsNestedFamORAssem { get; }

		bool IsAutoLayout { get; }

		bool IsLayoutSequential { get; }

		bool IsExplicitLayout { get; }

		bool IsClass { get; }

		bool IsInterface { get; }

		bool IsValueType { get; }

		bool IsAbstract { get; }

		bool IsSealed { get; }

		bool IsEnum { get; }

		bool IsSpecialName { get; }

		bool IsImport { get; }

		bool IsSerializable { get; }

		bool IsAnsiClass { get; }

		bool IsUnicodeClass { get; }

		bool IsAutoClass { get; }

		bool IsArray { get; }

		bool IsByRef { get; }

		bool IsPointer { get; }

		bool IsPrimitive { get; }

		bool IsCOMObject { get; }

		bool HasElementType { get; }

		bool IsContextful { get; }

		bool IsMarshalByRef { get; }

		void GetTypeInfoCount(out uint pcTInfo);

		void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

		void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

		void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);

		new string ToString();

		new bool Equals(object other);

		new int GetHashCode();

		new Type GetType();

		object[] GetCustomAttributes(Type attributeType, bool inherit);

		object[] GetCustomAttributes(bool inherit);

		bool IsDefined(Type attributeType, bool inherit);

		int GetArrayRank();

		ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

		Type GetInterface(string name, bool ignoreCase);

		Type[] GetInterfaces();

		Type[] FindInterfaces(TypeFilter filter, object filterCriteria);

		EventInfo GetEvent(string name, BindingFlags bindingAttr);

		EventInfo[] GetEvents();

		EventInfo[] GetEvents(BindingFlags bindingAttr);

		Type[] GetNestedTypes(BindingFlags bindingAttr);

		Type GetNestedType(string name, BindingFlags bindingAttr);

		MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr);

		MemberInfo[] GetDefaultMembers();

		MemberInfo[] FindMembers(MemberTypes memberType, BindingFlags bindingAttr, MemberFilter filter, object filterCriteria);

		Type GetElementType();

		bool IsSubclassOf(Type c);

		bool IsInstanceOfType(object o);

		bool IsAssignableFrom(Type c);

		InterfaceMapping GetInterfaceMap(Type interfaceType);

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

		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, CultureInfo culture);

		object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args);

		ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers);

		ConstructorInfo GetConstructor(Type[] types);

		ConstructorInfo[] GetConstructors();

		MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

		MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers);

		MethodInfo GetMethod(string name, Type[] types);

		MethodInfo GetMethod(string name);

		MethodInfo[] GetMethods();

		FieldInfo GetField(string name);

		FieldInfo[] GetFields();

		Type GetInterface(string name);

		EventInfo GetEvent(string name);

		PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers);

		PropertyInfo GetProperty(string name, Type returnType, Type[] types);

		PropertyInfo GetProperty(string name, Type[] types);

		PropertyInfo GetProperty(string name, Type returnType);

		PropertyInfo GetProperty(string name);

		PropertyInfo[] GetProperties();

		Type[] GetNestedTypes();

		Type GetNestedType(string name);

		MemberInfo[] GetMember(string name);

		MemberInfo[] GetMembers();

		bool Equals(Type o);
	}
}
