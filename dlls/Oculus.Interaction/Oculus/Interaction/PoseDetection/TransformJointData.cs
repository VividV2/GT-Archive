using System.Collections.Generic;
using Oculus.Interaction.Input;
using UnityEngine;
using System.Collections.Generic;
using Oculus.Interaction.Input;
using UnityEngine;

namespace Oculus.Interaction.PoseDetection
{
	public class TransformJointData
	{
		public bool IsValid;

		public Handedness Handedness;

		public Pose CenterEyePose;

		public Pose WristPose;

		public Vector3 TrackingSystemUp;

		public Vector3 TrackingSystemForward;
	}
}
namespace Oculus.Interaction.PoseDetection
{
	public class JointDeltaConfig(int instanceID, IEnumerable<HandJointId> jointIDs)
	{
		public readonly int InstanceID = instanceID;

		public readonly IEnumerable<HandJointId> JointIDs = jointIDs;
	}
}
