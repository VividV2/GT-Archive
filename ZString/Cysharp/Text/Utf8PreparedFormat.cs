using System;
using System.Buffers;

namespace Cysharp.Text;

public sealed class Utf8PreparedFormat<T1, T2, T3, T4, T5, T6, T7, T8>
{
	private readonly Utf8FormatSegment[] segments;

	private readonly byte[] utf8PreEncodedbuffer;

	public string FormatString { get; }

	public int MinSize { get; }

	public Utf8PreparedFormat(string format)
	{
		FormatString = format;
		segments = PreparedFormatHelper.Utf8Parse(format, out utf8PreEncodedbuffer);
		int num = 0;
		Utf8FormatSegment[] array = segments;
		for (int i = 0; i < array.Length; i++)
		{
			Utf8FormatSegment utf8FormatSegment = array[i];
			if (!utf8FormatSegment.IsFormatArgument)
			{
				num += utf8FormatSegment.Count;
			}
		}
		MinSize = num;
	}

	public string Format(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
	{
		Utf8ValueStringBuilder sb = new Utf8ValueStringBuilder(disposeImmediately: true);
		try
		{
			FormatTo(ref sb, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return sb.ToString();
		}
		finally
		{
			sb.Dispose();
		}
	}

	public void FormatTo<TBufferWriter>(ref TBufferWriter sb, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) where TBufferWriter : IBufferWriter<byte>
	{
		Span<byte> span = MemoryExtensions.AsSpan(utf8PreEncodedbuffer);
		Utf8FormatSegment[] array = segments;
		for (int i = 0; i < array.Length; i++)
		{
			Utf8FormatSegment utf8FormatSegment = array[i];
			switch (utf8FormatSegment.FormatIndex)
			{
			case -1:
			{
				Span<byte> span2 = span.Slice(utf8FormatSegment.Offset, utf8FormatSegment.Count);
				int count = utf8FormatSegment.Count;
				Span<byte> span3 = sb.GetSpan(count);
				span2.TryCopyTo(span3);
				int count2 = utf8FormatSegment.Count;
				sb.Advance(count2);
				break;
			}
			case 0:
				Utf8FormatHelper.FormatTo(ref sb, arg1, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg1");
				break;
			case 1:
				Utf8FormatHelper.FormatTo(ref sb, arg2, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg2");
				break;
			case 2:
				Utf8FormatHelper.FormatTo(ref sb, arg3, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg3");
				break;
			case 3:
				Utf8FormatHelper.FormatTo(ref sb, arg4, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg4");
				break;
			case 4:
				Utf8FormatHelper.FormatTo(ref sb, arg5, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg5");
				break;
			case 5:
				Utf8FormatHelper.FormatTo(ref sb, arg6, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg6");
				break;
			case 6:
				Utf8FormatHelper.FormatTo(ref sb, arg7, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg7");
				break;
			case 7:
				Utf8FormatHelper.FormatTo(ref sb, arg8, utf8FormatSegment.Alignment, utf8FormatSegment.StandardFormat, "arg8");
				break;
			}
		}
	}
}
