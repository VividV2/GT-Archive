using System;
using System;

namespace CSCore
{
	public interface IReadableAudioSource<in T> : IAudioSource, IDisposable
	{
		int Read(T[] buffer, int offset, int count);
	}
}
namespace CSCore
{
	public interface IWriteable
	{
		void Write(byte[] buffer, int offset, int count);
	}
}
namespace Photon.Voice.Unity
{
}
