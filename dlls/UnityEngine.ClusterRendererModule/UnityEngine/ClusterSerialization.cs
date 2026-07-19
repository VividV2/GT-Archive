using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[Obsolete("This type is deprecated and will be removed in Unity 7.", false)]
[NativeHeader("Modules/ClusterRenderer/ClusterNetwork.h")]
public class ClusterNetwork
{
	public static extern bool isMasterOfCluster
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	public static extern bool isDisconnected
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
	}

	public static extern int nodeIndex
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		set;
	}
}
namespace UnityEngine
{
	[NativeHeader("Modules/ClusterRenderer/ClusterSerialization.h")]
	[ExcludeFromDocs]
	[Obsolete("This type is deprecated and will be removed in Unity 7.", false)]
	public static class ClusterSerialization
	{
		public unsafe static int SaveTimeManagerState(NativeArray<byte> buffer)
		{
			return SaveTimeManagerStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		public unsafe static bool RestoreTimeManagerState(NativeArray<byte> buffer)
		{
			return RestoreTimeManagerStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		public unsafe static int SaveInputManagerState(NativeArray<byte> buffer)
		{
			return SaveInputManagerStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		public unsafe static bool RestoreInputManagerState(NativeArray<byte> buffer)
		{
			return RestoreInputManagerStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		public unsafe static int SaveClusterInputState(NativeArray<byte> buffer)
		{
			return SaveClusterInputStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		public unsafe static bool RestoreClusterInputState(NativeArray<byte> buffer)
		{
			return RestoreClusterInputStateInternal(NativeArrayUnsafeUtility.GetUnsafePtr(buffer), buffer.Length);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::SaveTimeManagerState")]
		private unsafe static extern int SaveTimeManagerStateInternal(void* intBuffer, int bufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::RestoreTimeManagerState")]
		private unsafe static extern bool RestoreTimeManagerStateInternal(void* buffer, int bufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::SaveInputManagerState")]
		private unsafe static extern int SaveInputManagerStateInternal(void* intBuffer, int bufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::RestoreInputManagerState")]
		private unsafe static extern bool RestoreInputManagerStateInternal(void* buffer, int bufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::SaveClusterInputState")]
		private unsafe static extern int SaveClusterInputStateInternal(void* intBuffer, int bufferSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("ClusterSerialization::RestoreClusterInputState")]
		private unsafe static extern bool RestoreClusterInputStateInternal(void* buffer, int bufferSize);
	}
}
