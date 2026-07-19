using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	public sealed class ResourceFormattedPathsAttribute : ResourcePathsBaseAttribute
	{
		public ResourceFormattedPathsAttribute(string pathFormat, int rangeMin, int rangeMax, SearchType location = SearchType.ProjectPath)
			: base(null, isField: false, location)
		{
		}

		private static string[] CreateFormattedPaths(string format, int rangeMin, int rangeMax)
		{
			string[] array = new string[rangeMax - rangeMin];
			int num = rangeMin;
			int num2 = 0;
			while (num < rangeMax)
			{
				array[num2] = string.Format(format, num);
				num++;
				num2++;
			}
			return array;
		}
	}
}
namespace UnityEngine.Rendering
{
	[NativeHeader("PlatformDependent/Win/Profiler/PixBindings.h")]
	[NativeConditional("PLATFORM_WIN && ENABLE_PROFILER")]
	public class PIX
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("PIX::BeginGPUCapture")]
		public static extern void BeginGPUCapture();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("PIX::EndGPUCapture")]
		public static extern void EndGPUCapture();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("PIX::IsAttached")]
		public static extern bool IsAttached();
	}
}
