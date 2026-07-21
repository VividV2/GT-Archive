using System;
using UnityEngine.Scripting.APIUpdating;
using System;
using System;

namespace UnityEngine.Rendering
{
	public enum ReflectionProbeTimeSlicingMode
	{
		AllFacesAtOnce,
		IndividualFaces,
		NoTimeSlicing
	}
}
namespace UnityEngine.Events
{
	[Serializable]
	public enum PersistentListenerMode
	{
		EventDefined,
		Void,
		Object,
		Int,
		Float,
		String,
		Bool
	}
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine.Analytics
{
	[Flags]
	public enum SendEventOptions
	{
		kAppendNone = 0,
		kAppendBuildGuid = 1,
		kAppendBuildTarget = 2
	}
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine
{
	[Serializable]
	public struct FrustumPlanes
	{
		public float left;

		public float right;

		public float bottom;

		public float top;

		public float zNear;

		public float zFar;
	}
}
namespace UnityEngine
{
}
namespace Unity.IntegerTime
{
}
namespace UnityEngine
{
}
namespace Unity.Profiling
{
	public enum ProfilerMarkerDataUnit : byte
	{
		Undefined,
		TimeNanoseconds,
		Bytes,
		Count,
		Percent,
		FrequencyHz
	}
}
namespace UnityEngine.Networking.PlayerConnection
{
	[MovedFrom("UnityEngine.Experimental.Networking.PlayerConnection")]
	public enum ConnectionTarget
	{
		None,
		Player,
		Editor
	}
}
namespace UnityEngine
{
}
