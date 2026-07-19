using System;
using System.Collections;
using System.Collections.Generic;

namespace POpusCodec.Enums;

public enum SignalHint
{
	Auto = -1000,
	Voice = 3001,
	Music = 3002
}
namespace Photon.Voice
{
	public interface IDeviceEnumerator : IDisposable, IEnumerable<DeviceInfo>, IEnumerable
	{
		bool IsSupported { get; }

		string Error { get; }

		void Refresh();
	}
}
