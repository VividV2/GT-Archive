using System;
using UnityEngine;
using UnityEngine;

namespace Unity.Cinemachine
{
	public sealed class CinemachineImpulseChannelPropertyAttribute : PropertyAttribute
	{
	}
}
namespace Unity.Cinemachine
{
	public sealed class RequiredTargetAttribute : Attribute
	{
		public enum RequiredTargets
		{
			None,
			Tracking,
			LookAt,
			GroupLookAt
		}

		public RequiredTargets RequiredTarget { get; private set; }

		public RequiredTargetAttribute(RequiredTargets requiredTarget)
		{
			RequiredTarget = requiredTarget;
		}
	}
}
namespace Unity.Cinemachine
{
}
