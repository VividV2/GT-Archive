using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling.LowLevel.Unsafe;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling.LowLevel.Unsafe;

namespace Unity.Profiling
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct ProfilerUtility
	{
		public static byte GetProfilerMarkerDataType<T>()
		{
			return Type.GetTypeCode(typeof(T)) switch
			{
				TypeCode.Int32 => 2, 
				TypeCode.UInt32 => 3, 
				TypeCode.Int64 => 4, 
				TypeCode.UInt64 => 5, 
				TypeCode.Single => 6, 
				TypeCode.Double => 7, 
				TypeCode.String => 9, 
				_ => throw new ArgumentException($"Type {typeof(T)} is unsupported by ProfilerCounter."), 
			};
		}
	}
}
namespace Unity.Profiling
{
	public static class ProfilerMarkerExtension
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, int metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 2,
				Size = (uint)UnsafeUtility.SizeOf<int>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, uint metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 3,
				Size = (uint)UnsafeUtility.SizeOf<uint>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, long metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 4,
				Size = (uint)UnsafeUtility.SizeOf<long>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, ulong metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 5,
				Size = (uint)UnsafeUtility.SizeOf<ulong>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, float metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 6,
				Size = (uint)UnsafeUtility.SizeOf<float>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, double metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 7,
				Size = (uint)UnsafeUtility.SizeOf<double>(),
				Ptr = &metadata
			};
			ProfilerMarkerData profilerMarkerData;
			ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("ENABLE_PROFILER")]
		public unsafe static void Begin(this ProfilerMarker marker, string metadata)
		{
			ProfilerMarkerData profilerMarkerData = new ProfilerMarkerData
			{
				Type = 9
			};
			fixed (char* ptr = metadata)
			{
				ProfilerMarkerData profilerMarkerData;
				profilerMarkerData.Size = (uint)((metadata.Length + 1) * 2);
				profilerMarkerData.Ptr = ptr;
				ProfilerUnsafeUtility.BeginSampleWithMetadata(marker.Handle, 1, &profilerMarkerData);
			}
		}
	}
}
