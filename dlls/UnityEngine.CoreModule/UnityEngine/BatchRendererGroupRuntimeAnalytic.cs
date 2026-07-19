using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using System;
using System;
using Unity.Jobs.LowLevel.Unsafe;
using System;

namespace JetBrains.Annotations
{
	[Flags]
	public enum ImplicitUseKindFlags
	{
		Default = 7,
		Access = 1,
		Assign = 2,
		InstantiatedWithFixedConstructorSignature = 4,
		InstantiatedNoFixedConstructorSignature = 8
	}
}
namespace UnityEngine
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase
	{
		private int brgRuntimeStatus;

		private BatchRendererGroupRuntimeAnalytic()
			: base("brgPlayerUsage", 1)
		{
		}

		[RequiredByNativeCode]
		public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic()
		{
			return new BatchRendererGroupRuntimeAnalytic();
		}
	}
}
namespace UnityEngine
{
}
namespace Unity.Jobs
{
	[Unity.Jobs.LowLevel.Unsafe.JobProducerType(typeof(IJobForExtensions.ForJobStruct<>))]
	public interface IJobFor
	{
		void Execute(int index);
	}
}
namespace UnityEngine
{
	public enum RenderTextureFormat
	{
		ARGB32 = 0,
		Depth = 1,
		ARGBHalf = 2,
		Shadowmap = 3,
		RGB565 = 4,
		ARGB4444 = 5,
		ARGB1555 = 6,
		Default = 7,
		ARGB2101010 = 8,
		DefaultHDR = 9,
		ARGB64 = 10,
		ARGBFloat = 11,
		RGFloat = 12,
		RGHalf = 13,
		RFloat = 14,
		RHalf = 15,
		R8 = 16,
		ARGBInt = 17,
		RGInt = 18,
		RInt = 19,
		BGRA32 = 20,
		RGB111110Float = 22,
		RG32 = 23,
		RGBAUShort = 24,
		RG16 = 25,
		BGRA10101010_XR = 26,
		BGR101010_XR = 27,
		R16 = 28
	}
}
