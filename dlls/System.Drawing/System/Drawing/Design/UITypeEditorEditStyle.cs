namespace System.Drawing.Drawing2D;

/// <summary>Specifies the different patterns available for <see cref="T:System.Drawing.Drawing2D.HatchBrush" /> objects.</summary>
public enum HatchStyle
{
	/// <summary>A pattern of horizontal lines.</summary>
	Horizontal = 0,
	/// <summary>A pattern of vertical lines.</summary>
	Vertical = 1,
	/// <summary>A pattern of lines on a diagonal from upper left to lower right.</summary>
	ForwardDiagonal = 2,
	/// <summary>A pattern of lines on a diagonal from upper right to lower left.</summary>
	BackwardDiagonal = 3,
	/// <summary>Specifies horizontal and vertical lines that cross.</summary>
	Cross = 4,
	/// <summary>A pattern of crisscross diagonal lines.</summary>
	DiagonalCross = 5,
	/// <summary>Specifies a 5-percent hatch. The ratio of foreground color to background color is 5:95.</summary>
	Percent05 = 6,
	/// <summary>Specifies a 10-percent hatch. The ratio of foreground color to background color is 10:90.</summary>
	Percent10 = 7,
	/// <summary>Specifies a 20-percent hatch. The ratio of foreground color to background color is 20:80.</summary>
	Percent20 = 8,
	/// <summary>Specifies a 25-percent hatch. The ratio of foreground color to background color is 25:75.</summary>
	Percent25 = 9,
	/// <summary>Specifies a 30-percent hatch. The ratio of foreground color to background color is 30:70.</summary>
	Percent30 = 10,
	/// <summary>Specifies a 40-percent hatch. The ratio of foreground color to background color is 40:60.</summary>
	Percent40 = 11,
	/// <summary>Specifies a 50-percent hatch. The ratio of foreground color to background color is 50:50.</summary>
	Percent50 = 12,
	/// <summary>Specifies a 60-percent hatch. The ratio of foreground color to background color is 60:40.</summary>
	Percent60 = 13,
	/// <summary>Specifies a 70-percent hatch. The ratio of foreground color to background color is 70:30.</summary>
	Percent70 = 14,
	/// <summary>Specifies a 75-percent hatch. The ratio of foreground color to background color is 75:25.</summary>
	Percent75 = 15,
	/// <summary>Specifies a 80-percent hatch. The ratio of foreground color to background color is 80:100.</summary>
	Percent80 = 16,
	/// <summary>Specifies a 90-percent hatch. The ratio of foreground color to background color is 90:10.</summary>
	Percent90 = 17,
	/// <summary>Specifies diagonal lines that slant to the right from top points to bottom points and are spaced 50 percent closer together than <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />, but are not antialiased.</summary>
	LightDownwardDiagonal = 18,
	/// <summary>Specifies diagonal lines that slant to the left from top points to bottom points and are spaced 50 percent closer together than <see cref="F:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal" />, but they are not antialiased.</summary>
	LightUpwardDiagonal = 19,
	/// <summary>Specifies diagonal lines that slant to the right from top points to bottom points, are spaced 50 percent closer together than, and are twice the width of <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />. This hatch pattern is not antialiased.</summary>
	DarkDownwardDiagonal = 20,
	/// <summary>Specifies diagonal lines that slant to the left from top points to bottom points, are spaced 50 percent closer together than <see cref="F:System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal" />, and are twice its width, but the lines are not antialiased.</summary>
	DarkUpwardDiagonal = 21,
	/// <summary>Specifies diagonal lines that slant to the right from top points to bottom points, have the same spacing as hatch style <see cref="F:System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal" />, and are triple its width, but are not antialiased.</summary>
	WideDownwardDiagonal = 22,
	WideUpwardDiagonal = 23,
	LightVertical = 24,
	LightHorizontal = 25,
	NarrowVertical = 26,
	NarrowHorizontal = 27,
	DarkVertical = 28,
	DarkHorizontal = 29,
	DashedDownwardDiagonal = 30,
	DashedUpwardDiagonal = 31,
	DashedHorizontal = 32,
	DashedVertical = 33,
	SmallConfetti = 34,
	LargeConfetti = 35,
	ZigZag = 36,
	Wave = 37,
	DiagonalBrick = 38,
	HorizontalBrick = 39,
	Weave = 40,
	Plaid = 41,
	Divot = 42,
	DottedGrid = 43,
	DottedDiamond = 44,
	Shingle = 45,
	Trellis = 46,
	Sphere = 47,
	SmallGrid = 48,
	SmallCheckerBoard = 49,
	LargeCheckerBoard = 50,
	OutlinedDiamond = 51,
	SolidDiamond = 52,
	LargeGrid = 4,
	Min = 0,
	Max = 4
}
