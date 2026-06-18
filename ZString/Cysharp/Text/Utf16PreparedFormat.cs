using System;
using System.Buffers;

namespace Cysharp.Text;

public sealed class Utf16PreparedFormat<T1, T2, T3>
{
	private readonly Utf16FormatSegment[] segments;

	public string FormatString { get; }

	public int MinSize { get; }

	public Utf16PreparedFormat(string format)
	{
		FormatString = format;
		segments = PreparedFormatHelper.Utf16Parse(format);
		int num = 0;
		Utf16FormatSegment[] array = segments;
		for (int i = 0; i < array.Length; i++)
		{
			Utf16FormatSegment utf16FormatSegment = array[i];
			if (!utf16FormatSegment.IsFormatArgument)
			{
				num += utf16FormatSegment.Count;
			}
		}
		MinSize = num;
	}

	public string Format(T1 arg1, T2 arg2, T3 arg3)
	{
		Utf16ValueStringBuilder sb = new Utf16ValueStringBuilder(disposeImmediately: true);
		try
		{
			FormatTo(ref sb, arg1, arg2, arg3);
			return sb.ToString();
		}
		finally
		{
			sb.Dispose();
		}
	}

	public void FormatTo<TBufferWriter>(ref TBufferWriter sb, T1 arg1, T2 arg2, T3 arg3) where TBufferWriter : IBufferWriter<char>
	{
		ReadOnlySpan<char> readOnlySpan = MemoryExtensions.AsSpan(FormatString);
		Utf16FormatSegment[] array = segments;
		for (int i = 0; i < array.Length; i++)
		{
			Utf16FormatSegment utf16FormatSegment = array[i];
			switch (utf16FormatSegment.FormatIndex)
			{
			case -1:
			{
				ReadOnlySpan<char> readOnlySpan2 = readOnlySpan.Slice(utf16FormatSegment.Offset, utf16FormatSegment.Count);
				int count = utf16FormatSegment.Count;
				Span<char> span = sb.GetSpan(count);
				readOnlySpan2.TryCopyTo(span);
				int count2 = utf16FormatSegment.Count;
				sb.Advance(count2);
				break;
			}
			case 0:
				Utf16FormatHelper.FormatTo(ref sb, arg1, utf16FormatSegment.Alignment, readOnlySpan.Slice(utf16FormatSegment.Offset, utf16FormatSegment.Count), "arg1");
				break;
			case 1:
				Utf16FormatHelper.FormatTo(ref sb, arg2, utf16FormatSegment.Alignment, readOnlySpan.Slice(utf16FormatSegment.Offset, utf16FormatSegment.Count), "arg2");
				break;
			case 2:
				Utf16FormatHelper.FormatTo(ref sb, arg3, utf16FormatSegment.Alignment, readOnlySpan.Slice(utf16FormatSegment.Offset, utf16FormatSegment.Count), "arg3");
				break;
			}
		}
	}
}
