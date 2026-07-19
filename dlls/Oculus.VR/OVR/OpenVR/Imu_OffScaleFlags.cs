using UnityEngine;
using UnityEngine;

namespace OVR.OpenVR
{
	public enum Imu_OffScaleFlags
	{
		OffScale_AccelX = 1,
		OffScale_AccelY = 2,
		OffScale_AccelZ = 4,
		OffScale_GyroX = 8,
		OffScale_GyroY = 0x10,
		OffScale_GyroZ = 0x20
	}
}
namespace Assets.OVR.Scripts
{
	internal delegate void FixMethodDelegate(Object obj, bool isLastInSet, int selectedIndex);
}
