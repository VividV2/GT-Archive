using System.Drawing.Imaging;
using System.Drawing.Imaging;

namespace System.Drawing
{
	internal interface IMacContext
	{
		void Synchronize();

		void Release();
	}
}
namespace System.Drawing
{
	internal struct GdipEncoderParameter
	{
		internal Guid guid;

		internal uint numberOfValues;

		internal EncoderParameterValueType type;

		internal IntPtr value;
	}
}
namespace System.Drawing
{
}
