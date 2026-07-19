using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System;

namespace Oculus.Platform.Models;

public class NetSyncConnection(IntPtr o)
{
	public readonly long ConnectionId = CAPI.ovr_NetSyncConnection_GetConnectionId(o);

	public readonly NetSyncDisconnectReason DisconnectReason = CAPI.ovr_NetSyncConnection_GetDisconnectReason(o);

	public readonly ulong SessionId = CAPI.ovr_NetSyncConnection_GetSessionId(o);

	public readonly NetSyncConnectionStatus Status = CAPI.ovr_NetSyncConnection_GetStatus(o);

	public readonly string ZoneId = CAPI.ovr_NetSyncConnection_GetZoneId(o);
}
namespace Oculus.Platform.Models
{
	public class InstalledApplicationList : DeserializableList<InstalledApplication>
	{
		public InstalledApplicationList(IntPtr a)
		{
			int num = (int)(uint)CAPI.ovr_InstalledApplicationArray_GetSize(a);
			int num;
			_Data = new List<InstalledApplication>(num);
			int i;
			for (int i = 0; i < num; i++)
			{
				_Data.Add(new InstalledApplication(CAPI.ovr_InstalledApplicationArray_GetElement(a, (UIntPtr)(ulong)i)));
			}
		}
	}
}
