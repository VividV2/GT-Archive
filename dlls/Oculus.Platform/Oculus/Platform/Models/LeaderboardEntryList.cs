using System;
using System.Collections.Generic;

namespace Oculus.Platform.Models
{
	public class ManagedInfo
	{
		public readonly string Department;

		public readonly string Email;

		public readonly string EmployeeNumber;

		public readonly string ExternalId;

		public readonly string Location;

		public readonly string Manager;

		public readonly string Name;

		public readonly string OrganizationId;

		public readonly string OrganizationName;

		public readonly string Position;

		public ManagedInfo(IntPtr o)
		{
			Department = CAPI.ovr_ManagedInfo_GetDepartment(o);
			Email = CAPI.ovr_ManagedInfo_GetEmail(o);
			EmployeeNumber = CAPI.ovr_ManagedInfo_GetEmployeeNumber(o);
			ExternalId = CAPI.ovr_ManagedInfo_GetExternalId(o);
			Location = CAPI.ovr_ManagedInfo_GetLocation(o);
			Manager = CAPI.ovr_ManagedInfo_GetManager(o);
			Name = CAPI.ovr_ManagedInfo_GetName(o);
			OrganizationId = CAPI.ovr_ManagedInfo_GetOrganizationId(o);
			OrganizationName = CAPI.ovr_ManagedInfo_GetOrganizationName(o);
			Position = CAPI.ovr_ManagedInfo_GetPosition(o);
		}
	}
}
namespace Oculus.Platform.Models
{
	public class LeaderboardEntryList : DeserializableList<LeaderboardEntry>
	{
		public readonly ulong TotalCount;

		public LeaderboardEntryList(IntPtr a)
		{
			int num = (int)(uint)CAPI.ovr_LeaderboardEntryArray_GetSize(a);
			_Data = new List<LeaderboardEntry>(num);
			for (int i = 0; i < num; i++)
			{
				_Data.Add(new LeaderboardEntry(CAPI.ovr_LeaderboardEntryArray_GetElement(a, (UIntPtr)(ulong)i)));
			}
			TotalCount = CAPI.ovr_LeaderboardEntryArray_GetTotalCount(a);
			_PreviousUrl = CAPI.ovr_LeaderboardEntryArray_GetPreviousUrl(a);
			_NextUrl = CAPI.ovr_LeaderboardEntryArray_GetNextUrl(a);
		}
	}
}
