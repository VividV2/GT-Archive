using UnityEngine;

namespace Valve.VR
{
	[Serializable]
	public class SteamVR_Input_BindingFile_Haptic
	{
		public string output;

		public string path;

		public override bool Equals(object obj)
		{
			if (obj is SteamVR_Input_BindingFile_Haptic)
			{
				steamVR_Input_BindingFile_Haptic = (SteamVR_Input_BindingFile_Haptic)obj;
				if (string.op_Equality(steamVR_Input_BindingFile_Haptic.output, output) && string.op_Equality(steamVR_Input_BindingFile_Haptic.path, path))
					return true;
				return false;
			}
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public SteamVR_Input_BindingFile_Haptic()
		{
			base..ctor();
		}
	}
}
namespace Valve.VR
{
	public interface ISteamVR_Action_Skeleton_Source
	{
		EVRSkeletalTrackingLevel skeletalTrackingLevel { get; }

		Vector3[] bonePositions { get; }

		Quaternion[] boneRotations { get; }

		Vector3[] lastBonePositions { get; }

		Quaternion[] lastBoneRotations { get; }

		EVRSkeletalMotionRange rangeOfMotion { get; set; }

		EVRSkeletalTransformSpace skeletalTransformSpace { get; set; }

		bool onlyUpdateSummaryData { get; set; }

		float thumbCurl { get; }

		float indexCurl { get; }

		float middleCurl { get; }

		float ringCurl { get; }

		float pinkyCurl { get; }

		float thumbIndexSplay { get; }

		float indexMiddleSplay { get; }

		float middleRingSplay { get; }

		float ringPinkySplay { get; }

		float lastThumbCurl { get; }

		float lastIndexCurl { get; }

		float lastMiddleCurl { get; }

		float lastRingCurl { get; }

		float lastPinkyCurl { get; }

		float lastThumbIndexSplay { get; }

		float lastIndexMiddleSplay { get; }

		float lastMiddleRingSplay { get; }

		float lastRingPinkySplay { get; }

		float[] fingerCurls { get; }

		float[] fingerSplays { get; }

		float[] lastFingerCurls { get; }

		float[] lastFingerSplays { get; }
	}
}
namespace Valve.VR
{
}
