using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	/// <summary>Specifies the types of images and colors that will be affected by the color and grayscale adjustment settings of an <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
	/// <summary>Specifies the types of images and colors that will be affected by the color and grayscale adjustment settings of an <see cref="T:System.Drawing.Imaging.ImageAttributes" />.</summary>
	public enum ColorMatrixFlag
	{
		/// <summary>All color values, including gray shades, are adjusted by the same color-adjustment matrix.</summary>
		/// <summary>All color values, including gray shades, are adjusted by the same color-adjustment matrix.</summary>
		Default,
		/// <summary>All colors are adjusted, but gray shades are not adjusted. A gray shade is any color that has the same value for its red, green, and blue components.</summary>
		/// <summary>All colors are adjusted, but gray shades are not adjusted. A gray shade is any color that has the same value for its red, green, and blue components.</summary>
		SkipGrays,
		/// <summary>Only gray shades are adjusted.</summary>
		/// <summary>Only gray shades are adjusted.</summary>
		AltGrays
	}
}
namespace System.Drawing.Imaging
{
	/// <summary>Specifies flags that are passed to the flags parameter of the <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method. The <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method locks a portion of an image so that you can read or write the pixel data.</summary>
	/// <summary>Specifies flags that are passed to the flags parameter of the <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method. The <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method locks a portion of an image so that you can read or write the pixel data.</summary>
	public enum ImageLockMode
	{
		/// <summary>Specifies that a portion of the image is locked for reading.</summary>
		/// <summary>Specifies that a portion of the image is locked for reading.</summary>
		ReadOnly = 1,
		/// <summary>Specifies that a portion of the image is locked for writing.</summary>
		/// <summary>Specifies that a portion of the image is locked for writing.</summary>
		WriteOnly,
		/// <summary>Specifies that a portion of the image is locked for reading or writing.</summary>
		/// <summary>Specifies that a portion of the image is locked for reading or writing.</summary>
		ReadWrite,
		/// <summary>Specifies that the buffer used for reading or writing pixel data is allocated by the user. If this flag is set, the <paramref name="flags" /> parameter of the <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method serves as an input parameter (and possibly as an output parameter). If this flag is cleared, then the <paramref name="flags" /> parameter serves only as an output parameter.</summary>
		/// <summary>Specifies that the buffer used for reading or writing pixel data is allocated by the user. If this flag is set, the <paramref name="flags" /> parameter of the <see cref="Overload:System.Drawing.Bitmap.LockBits" /> method serves as an input parameter (and possibly as an output parameter). If this flag is cleared, then the <paramref name="flags" /> parameter serves only as an output parameter.</summary>
		UserInputBuffer
	}
}
namespace System.Drawing
{
}
namespace System.Drawing.Imaging
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal class ImageCodecInfoPrivate
	{
		[MarshalAs(UnmanagedType.Struct)]
		public Guid Clsid;

		[MarshalAs(UnmanagedType.Struct)]
		public Guid FormatID;

		public IntPtr CodecName = IntPtr.Zero;

		public IntPtr DllName = IntPtr.Zero;

		public IntPtr FormatDescription = IntPtr.Zero;

		public IntPtr FilenameExtension = IntPtr.Zero;

		public IntPtr MimeType = IntPtr.Zero;

		public int Flags;

		public int Version;

		public int SigCount;

		public int SigSize;

		public IntPtr SigPattern = IntPtr.Zero;

		public IntPtr SigMask = IntPtr.Zero;
	}
}
namespace System.Drawing
{
}
