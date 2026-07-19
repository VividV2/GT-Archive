using System.Reflection;
using System.Reflection;

namespace System.Runtime.InteropServices;

[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComVisible(true)]
[Guid("f1c3bf76-c3e4-11d3-88e7-00902754c43a")]
public interface ITypeLibImporterNotifySink
{
	void ReportEvent(ImporterEventKind eventKind, int eventCode, string eventMsg);

	Assembly ResolveRef([MarshalAs(UnmanagedType.Interface)] object typeLib);
}
namespace System.Runtime.InteropServices
{
	[Serializable]
	[Flags]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.VARFLAGS instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	public enum VARFLAGS : short
	{
		VARFLAG_FREADONLY = 1,
		VARFLAG_FSOURCE = 2,
		VARFLAG_FBINDABLE = 4,
		VARFLAG_FREQUESTEDIT = 8,
		VARFLAG_FDISPLAYBIND = 0x10,
		VARFLAG_FDEFAULTBIND = 0x20,
		VARFLAG_FHIDDEN = 0x40,
		VARFLAG_FRESTRICTED = 0x80,
		VARFLAG_FDEFAULTCOLLELEM = 0x100,
		VARFLAG_FUIDEFAULT = 0x200,
		VARFLAG_FNONBROWSABLE = 0x400,
		VARFLAG_FREPLACEABLE = 0x800,
		VARFLAG_FIMMEDIATEBIND = 0x1000
	}
}
