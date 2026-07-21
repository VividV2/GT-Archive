using System;
using System.Diagnostics;
using Fusion.Protocol;
using UnityEngine;
using Fusion.Protocol;

namespace Fusion
{
	internal class PeerPing(ReflexiveInfo reflexiveInfo)
	{
		public const float PING_DELAY = 0.1f;

		public int AttemptCount = 10;

		public float NextAttemptCountDown = 0.1f;

		public ReflexiveInfo ReflexiveInfo = null;

		public override string ToString()
		{
			return string.Format("[{0}: {1}={2}, {3}={4}]", "PeerPing", "AttemptCount", AttemptCount, "ReflexiveInfo", ReflexiveInfo);
		}
	}
}
namespace Fusion
{
	[AttributeUsage(AttributeTargets.Property)]
	[Conditional("FUSION_UNITY")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("UNITY_2020_1_OR_NEWER")]
	[UnityPropertyAttributeProxy(typeof(HeaderAttribute))]
	public sealed class UnityHeaderAttribute : Attribute
	{
		public int order { get; set; }

		public UnityHeaderAttribute(string header)
		{
		}
	}
}
