using System;
using System;

namespace Valve.VR
{
	public struct NotificationBitmap_t
	{
		public IntPtr m_pImageData;

		public int m_nWidth;

		public int m_nHeight;

		public int m_nBytesPerPixel;
	}
}
namespace Valve.VR
{
	public enum EVRNotificationError
	{
		OK = 0,
		InvalidNotificationId = 100,
		NotificationQueueFull = 101,
		InvalidOverlayHandle = 102,
		SystemWithUserValueAlreadyExists = 103
	}
}
