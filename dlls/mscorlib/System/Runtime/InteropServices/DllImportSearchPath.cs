using System.Reflection;
using System.Security;

namespace System.Runtime.InteropServices
{
}
namespace System.Runtime.InteropServices
{
	[Guid("CCBD682C-73A5-4568-B8B0-C7007E11ABA2")]
	[ComVisible(true)]
	public interface IRegistrationServices
	{
		[SecurityCritical]
		bool RegisterAssembly(Assembly assembly, AssemblyRegistrationFlags flags);

		[SecurityCritical]
		bool UnregisterAssembly(Assembly assembly);

		[SecurityCritical]
		Type[] GetRegistrableTypesInAssembly(Assembly assembly);

		[SecurityCritical]
		string GetProgIdForType(Type type);

		[SecurityCritical]
		void RegisterTypeForComClients(Type type, ref Guid g);

		Guid GetManagedCategoryGuid();

		[SecurityCritical]
		bool TypeRequiresRegistration(Type type);

		bool TypeRepresentsComType(Type type);
	}
}
namespace System.Runtime.InteropServices
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.ELEMDESC instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	public struct ELEMDESC
	{
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		[ComVisible(false)]
		public struct DESCUNION
		{
			[FieldOffset(0)]
			public IDLDESC idldesc;

			[FieldOffset(0)]
			public PARAMDESC paramdesc;
		}

		public TYPEDESC tdesc;

		public DESCUNION desc;
	}
}
