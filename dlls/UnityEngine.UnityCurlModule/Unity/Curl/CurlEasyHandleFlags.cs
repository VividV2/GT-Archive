using System;

namespace Unity.Curl;

internal enum BufferOwnership
{
	Copy,
	Transfer,
	External
}
namespace Unity.Curl
{
}
namespace Unity.Curl
{
	[Flags]
	internal enum CurlEasyHandleFlags : uint
	{
		kSendBody = 1u,
		kReceiveHeaders = 2u,
		kReceiveBody = 4u,
		kFollowRedirects = 8u
	}
}
