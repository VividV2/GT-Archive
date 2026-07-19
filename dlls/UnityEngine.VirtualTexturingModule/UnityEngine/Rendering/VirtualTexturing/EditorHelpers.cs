using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering.VirtualTexturing
{
	[StaticAccessor("VirtualTexturing::Editor", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
	[NativeConditional("UNITY_EDITOR")]
	public static class EditorHelpers
	{
		[NativeHeader("Runtime/Shaders/SharedMaterialData.h")]
		internal struct StackValidationResult
		{
			public string stackName;

			public string errorMessage;
		}

		[NativeThrows]
		internal static extern int tileSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[NativeThrows]
		public static bool ValidateTextureStack([Unmarshalled][NotNull] Texture[] textures, out string errorMessage)
		{
			if (textures == null)
			{
				ThrowHelper.ThrowArgumentNullException(textures, "textures");
			}
			ManagedSpanWrapper errorMessage2 = default(ManagedSpanWrapper);
			try
			{
				return ValidateTextureStack_Injected(textures, out errorMessage2);
			}
			finally
			{
				errorMessage = OutStringMarshaller.GetStringAndDispose(errorMessage2);
			}
		}

		[NativeThrows]
		internal static StackValidationResult[] ValidateMaterialTextureStacks([NotNull] Material mat)
		{
			if ((object)mat == null)
			{
				ThrowHelper.ThrowArgumentNullException(mat, "mat");
			}
			IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(mat);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowArgumentNullException(mat, "mat");
			}
			return ValidateMaterialTextureStacks_Injected(intPtr);
		}

		[NativeConditional("UNITY_EDITOR")]
		[NativeThrows]
		public static GraphicsFormat[] QuerySupportedFormats()
		{
			BlittableArrayWrapper ret = default(BlittableArrayWrapper);
			GraphicsFormat[] result;
			try
			{
				QuerySupportedFormats_Injected(out ret);
			}
			finally
			{
				GraphicsFormat[] array = default(GraphicsFormat[]);
				ret.Unmarshal(ref array);
				result = array;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ValidateTextureStack_Injected(Texture[] textures, out ManagedSpanWrapper errorMessage);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern StackValidationResult[] ValidateMaterialTextureStacks_Injected(IntPtr mat);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void QuerySupportedFormats_Injected(out BlittableArrayWrapper ret);
	}
}
namespace UnityEngine.Rendering.VirtualTexturing
{
	[NativeHeader("Modules/VirtualTexturing/ScriptBindings/VirtualTexturing.bindings.h")]
	[StaticAccessor("VirtualTexturing::System", StaticAccessorType.DoubleColon)]
	public static class System
	{
		public const int AllMips = int.MaxValue;

		internal static extern bool enabled
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[NativeThrows]
		public static extern void Update();

		[NativeThrows]
		internal static void SetDebugFlag(Guid guid, bool enabled)
		{
			SetDebugFlagInteger(guid.ToByteArray(), enabled ? 1 : 0);
		}

		[NativeThrows]
		internal static void SetDebugFlagInteger(Guid guid, long value)
		{
			SetDebugFlagInteger(guid.ToByteArray(), value);
		}

		[NativeThrows]
		internal static void SetDebugFlagDouble(Guid guid, double value)
		{
			SetDebugFlagDouble(guid.ToByteArray(), value);
		}

		[NativeThrows]
		private unsafe static void SetDebugFlagInteger(byte[] guid, long value)
		{
			Span<byte> span = new Span<byte>(guid);
			Span<byte> span;
			fixed (byte* begin = span)
			{
				ManagedSpanWrapper guid2 = new ManagedSpanWrapper(begin, span.Length);
				ManagedSpanWrapper guid2;
				SetDebugFlagInteger_Injected(ref guid2, value);
			}
		}

		[NativeThrows]
		private unsafe static void SetDebugFlagDouble(byte[] guid, double value)
		{
			Span<byte> span = new Span<byte>(guid);
			Span<byte> span;
			fixed (byte* begin = span)
			{
				ManagedSpanWrapper guid2 = new ManagedSpanWrapper(begin, span.Length);
				ManagedSpanWrapper guid2;
				SetDebugFlagDouble_Injected(ref guid2, value);
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetDebugFlagInteger_Injected(ref ManagedSpanWrapper guid, long value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetDebugFlagDouble_Injected(ref ManagedSpanWrapper guid, double value);
	}
}
