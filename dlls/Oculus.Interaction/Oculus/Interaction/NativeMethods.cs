using System.Runtime.InteropServices;
using System.Security;

namespace Oculus.Interaction
{
	[SuppressUnmanagedCodeSecurity]
	internal static class NativeMethods
	{
		public const int IsdkSuccess = 0;

		[DllImport("InteractionSdk")]
		public static extern int isdk_NativeComponent_Activate(ulong id);
	}
}
namespace Oculus.Interaction
{
}
namespace Oculus.Interaction.PoseDetection
{
}
namespace Oculus.Interaction.PoseDetection
{
}
