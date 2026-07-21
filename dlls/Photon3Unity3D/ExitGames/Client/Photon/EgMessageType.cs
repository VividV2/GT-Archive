using System;
using System;

namespace ExitGames.Client.Photon
{
	internal enum EgMessageType : byte
	{
		Init,
		InitResponse,
		Operation,
		OperationResponse,
		Event,
		DisconnectReason,
		InternalOperationRequest,
		InternalOperationResponse,
		Message,
		RawMessage
	}
}
namespace ExitGames.Client.Photon
{
	[Flags]
	internal enum InitV3Flags : short
	{
		NoFlags = 0,
		EncryptionFlag = 1,
		IPv6Flag = 2,
		ReleaseSdkFlag = 4
	}
}
