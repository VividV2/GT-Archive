using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct lua_State
{
}
public enum EAssetReleaseTier
{
	Disabled,
	PublicRC,
	PrivateRC,
	PublicBeta,
	PrivateBeta,
	PublicAlpha,
	PrivateAlpha,
	Internal
}
