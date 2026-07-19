using System.Runtime.InteropServices;

namespace System.Net
{
	[StructLayout(LayoutKind.Sequential)]
	internal class SecPkgContext_StreamSizes
	{
		public int cbHeader;

		public int cbTrailer;

		public int cbMaximumMessage;

		public int cBuffers;

		public int cbBlockSize;

		public static readonly int SizeOf = Marshal.SizeOf<SecPkgContext_StreamSizes>();

		internal unsafe SecPkgContext_StreamSizes(byte[] memory)
		{
			fixed (byte* ptr = memory)
			{
				void* value = ptr;
				IntPtr ptr2 = new IntPtr(value);
				try
				{
					cbHeader = (int)checked((uint)Marshal.ReadInt32(ptr2));
					cbTrailer = (int)checked((uint)Marshal.ReadInt32(ptr2, 4));
					cbMaximumMessage = (int)checked((uint)Marshal.ReadInt32(ptr2, 8));
					cBuffers = (int)checked((uint)Marshal.ReadInt32(ptr2, 12));
					cbBlockSize = (int)checked((uint)Marshal.ReadInt32(ptr2, 16));
				}
				catch (OverflowException)
				{
					NetEventSource.Fail(this, "Negative size.", ".ctor");
					throw;
				}
			}
		}
	}
}
namespace System.Net
{
	/// <summary>Provides the base interface for creating <see cref="T:System.Net.WebRequest" /> instances.</summary>
	public interface IWebRequestCreate
	{
		/// <summary>Creates a <see cref="T:System.Net.WebRequest" /> instance.</summary>
		/// <param name="uri">The uniform resource identifier (URI) of the Web resource.</param>
		/// <returns>A <see cref="T:System.Net.WebRequest" /> instance.</returns>
		/// <exception cref="T:System.NotSupportedException">The request scheme specified in <paramref name="uri" /> is not supported by this <see cref="T:System.Net.IWebRequestCreate" /> instance.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="uri" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.UriFormatException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.FormatException" />, instead.  
		///
		///
		///
		///
		///  The URI specified in <paramref name="uri" /> is not a valid URI.</exception>
		WebRequest Create(Uri uri);
	}
}
