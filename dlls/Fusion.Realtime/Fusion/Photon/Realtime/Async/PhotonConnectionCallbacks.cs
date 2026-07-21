using System;
using System;

namespace Fusion.Photon.Realtime.Async;

internal class OperationException(short errorCode, string message) : Exception($"{message} (ErrorCode: {errorCode})")
{
	public short ErrorCode = errorCode;
}
