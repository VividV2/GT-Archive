using System;
using System.Runtime.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace System
{
	internal static class BufferEx
	{
		internal unsafe static void ZeroMemory(byte* dest, uint len)
		{
			if (len != 0)
			{
				for (int i = 0; i < len; i++)
				{
					dest[i] = 0;
				}
			}
		}

		internal unsafe static void Memcpy(byte* dest, byte* src, int len)
		{
			if (len != 0)
			{
				for (int i = 0; i < len; i++)
				{
					dest[i] = src[i];
				}
			}
		}
	}
}
namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
	}
}
