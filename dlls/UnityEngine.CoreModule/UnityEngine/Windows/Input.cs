using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
	public class Cursor
	{
		public static extern bool visible
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		public static extern CursorLockMode lockState
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		private static void SetCursor(Texture2D texture, CursorMode cursorMode)
		{
			SetCursor(texture, Vector2.zero, cursorMode);
		}

		public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
		{
			SetCursor_Injected(Object.MarshalledUnityObject.Marshal(texture), ref hotspot, cursorMode);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCursor_Injected(IntPtr texture, [In] ref Vector2 hotspot, CursorMode cursorMode);
	}
}
namespace UnityEngine.Windows
{
	[NativeHeader("PlatformDependent/Win/Bindings/InputBindings.h")]
	public static class Input
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[StaticAccessor("", StaticAccessorType.DoubleColon)]
		[ThreadSafe]
		[NativeName("ForwardRawInput")]
		private unsafe static extern void ForwardRawInputImpl(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize);

		public unsafe static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
			ForwardRawInput((uint*)(void*)rawInputHeaderIndices, (uint*)(void*)rawInputDataIndices, indicesCount, (byte*)(void*)rawInputData, rawInputDataSize);
		}

		public unsafe static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize)
		{
			if (rawInputHeaderIndices == null)
			{
				throw new ArgumentNullException("rawInputHeaderIndices");
			}
			if (rawInputDataIndices == null)
			{
				throw new ArgumentNullException("rawInputDataIndices");
			}
			if (rawInputData == null)
			{
				throw new ArgumentNullException("rawInputData");
			}
			ForwardRawInputImpl(rawInputHeaderIndices, rawInputDataIndices, indicesCount, rawInputData, rawInputDataSize);
		}
	}
}
namespace UnityEngine
{
}
namespace UnityEngine
{
}
