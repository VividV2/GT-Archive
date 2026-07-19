using System;
using System;

namespace Liv.Lck.Cosmetics
{
	public interface ILckCosmeticsManager : IDisposable
	{
		void RegisterDependant(ILckCosmeticDependant dependant);

		void UnregisterDependant(ILckCosmeticDependant dependant);
	}
}
namespace Liv.Lck.Encoding
{
	internal struct LckEncodedPacketHandler
	{
		public ILckCaptureStateProvider CaptureStateProvider { get; }

		public LckEncodedPacketCallback EncodedPacketCallback { get; }

		public LckEncodedPacketHandler(ILckCaptureStateProvider captureStateProvider, LckEncodedPacketCallback encodedPacketCallback)
		{
			CaptureStateProvider = captureStateProvider;
			EncodedPacketCallback = encodedPacketCallback;
		}
	}
}
