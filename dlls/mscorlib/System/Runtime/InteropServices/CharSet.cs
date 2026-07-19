namespace System
{
	internal enum TokenType
	{
		NumberToken = 1,
		YearNumberToken = 2,
		Am = 3,
		Pm = 4,
		MonthToken = 5,
		EndOfString = 6,
		DayOfWeekToken = 7,
		TimeZoneToken = 8,
		EraToken = 9,
		DateWordToken = 10,
		UnknownToken = 11,
		HebrewNumber = 12,
		JapaneseEraToken = 13,
		TEraToken = 14,
		IgnorableSymbol = 15,
		SEP_Unk = 256,
		SEP_End = 512,
		SEP_Space = 768,
		SEP_Am = 1024,
		SEP_Pm = 1280,
		SEP_Date = 1536,
		SEP_Time = 1792,
		SEP_YearSuff = 2048,
		SEP_MonthSuff = 2304,
		SEP_DaySuff = 2560,
		SEP_HourSuff = 2816,
		SEP_MinuteSuff = 3072,
		SEP_SecondSuff = 3328,
		SEP_LocalTimeMark = 3584,
		SEP_DateOrOffset = 3840,
		RegularTokenMask = 255,
		SeparatorTokenMask = 65280
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Dictates which character set marshaled strings should use.</summary>
	/// <summary>Dictates which character set marshaled strings should use.</summary>
	public enum CharSet
	{
		/// <summary>This value is obsolete and has the same behavior as <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" />.</summary>
		None = 1,
		/// <summary>Marshal strings as multiple-byte character strings.</summary>
		Ansi,
		/// <summary>Marshal strings as Unicode 2-byte characters.</summary>
		Unicode,
		/// <summary>Automatically marshal strings appropriately for the target operating system. The default is <see cref="F:System.Runtime.InteropServices.CharSet.Unicode" /> on Windows NT, Windows 2000, Windows XP, and the Windows Server 2003 family; the default is <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" /> on Windows 98 and Windows Me. Although the common language runtime default is <see cref="F:System.Runtime.InteropServices.CharSet.Auto" />, languages may override this default. For example, by default C# marks all methods and types as <see cref="F:System.Runtime.InteropServices.CharSet.Ansi" />.</summary>
		Auto
	}
}
