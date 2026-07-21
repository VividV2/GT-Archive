using System.Reflection;

namespace Meta.XR.ImmersiveDebugger.UserInterface
{
	internal interface IInspector
	{
		IMember RegisterMember(MemberInfo memberInfo, DebugMember attribute);

		IMember GetMember(MemberInfo memberInfo);
	}
}
namespace Meta.XR.ImmersiveDebugger.Utils
{
}
