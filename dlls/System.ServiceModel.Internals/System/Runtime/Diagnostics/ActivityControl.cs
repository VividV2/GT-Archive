namespace System.Runtime.Diagnostics
{
	internal enum ActivityControl : uint
	{
		EVENT_ACTIVITY_CTRL_GET_ID = 1u,
		EVENT_ACTIVITY_CTRL_SET_ID,
		EVENT_ACTIVITY_CTRL_CREATE_ID,
		EVENT_ACTIVITY_CTRL_GET_SET_ID,
		EVENT_ACTIVITY_CTRL_CREATE_SET_ID
	}
}
namespace System.Runtime.Diagnostics
{
	internal enum EventSeverity : uint
	{
		Success = 0u,
		Informational = 1073741824u,
		Warning = 2147483648u,
		Error = 3221225472u
	}
}
