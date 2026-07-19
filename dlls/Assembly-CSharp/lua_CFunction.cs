using System.Runtime.InteropServices;

namespace GorillaNetworking.Store;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int lua_CFunction(lua_State* L);
