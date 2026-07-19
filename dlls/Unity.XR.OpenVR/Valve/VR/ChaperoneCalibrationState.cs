namespace Valve.VR
{
	public enum EVRSkeletalTrackingLevel
	{
		VRSkeletalTracking_Estimated = 0,
		VRSkeletalTracking_Partial = 1,
		VRSkeletalTracking_Full = 2,
		Count = 3,
		Max = 2
	}
}
namespace Valve.VR
{
	public enum ChaperoneCalibrationState
	{
		OK = 1,
		Warning = 100,
		Warning_BaseStationMayHaveMoved = 101,
		Warning_BaseStationRemoved = 102,
		Warning_SeatedBoundsInvalid = 103,
		Error = 200,
		Error_BaseStationUninitialized = 201,
		Error_BaseStationConflict = 202,
		Error_PlayAreaInvalid = 203,
		Error_CollisionBoundsInvalid = 204
	}
}
