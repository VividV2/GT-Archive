namespace Valve.VR;

public enum EChaperoneImportFlags
{
	EChaperoneImport_BoundsOnly = 1
}
namespace Valve.VR
{
	public enum EVRSkeletalReferencePose
	{
		BindPose,
		OpenHand,
		Fist,
		GripLimit
	}
}
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
