using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EUniverse
	{
		k_EUniverseInvalid,
		k_EUniversePublic,
		k_EUniverseBeta,
		k_EUniverseInternal,
		k_EUniverseDev,
		k_EUniverseMax
	}
}
namespace Steamworks
{
	public enum EVoiceResult
	{
		k_EVoiceResultOK,
		k_EVoiceResultNotInitialized,
		k_EVoiceResultNotRecording,
		k_EVoiceResultNoData,
		k_EVoiceResultBufferTooSmall,
		k_EVoiceResultDataCorrupted,
		k_EVoiceResultRestricted,
		k_EVoiceResultUnsupportedCodec,
		k_EVoiceResultReceiverOutOfDate,
		k_EVoiceResultReceiverDidNotAnswer
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct CallbackMsg_t
	{
		public int m_hSteamUser;

		public int m_iCallback;

		public IntPtr m_pubParam;

		public int m_cubParam;
	}
}
