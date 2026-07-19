using System;
using System.Collections.Generic;
using System;

namespace Oculus.Platform.Models
{
	public class InstalledApplicationList : DeserializableList<InstalledApplication>
	{
		public InstalledApplicationList(IntPtr a)
		{
			int num = (int)(uint)CAPI.ovr_InstalledApplicationArray_GetSize(a);
			_Data = new List<InstalledApplication>(num);
			for (int i = 0; i < num; i++)
			{
				_Data.Add(new InstalledApplication(CAPI.ovr_InstalledApplicationArray_GetElement(a, (UIntPtr)(ulong)i)));
			}
		}
	}
}
namespace Oculus.Platform.Models
{
	public class ApplicationVersion(IntPtr o)
	{
		public readonly int CurrentCode = CAPI.ovr_ApplicationVersion_GetCurrentCode(o);

		public readonly string CurrentName = CAPI.ovr_ApplicationVersion_GetCurrentName(o);

		public readonly int LatestCode = CAPI.ovr_ApplicationVersion_GetLatestCode(o);

		public readonly string LatestName = CAPI.ovr_ApplicationVersion_GetLatestName(o);

		public readonly long ReleaseDate = CAPI.ovr_ApplicationVersion_GetReleaseDate(o);

		public readonly string Size = CAPI.ovr_ApplicationVersion_GetSize(o);
	}
}
