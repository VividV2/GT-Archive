using System;

namespace UnityEngine;

public enum ParticleSystemCollisionQuality
{
	High,
	Medium,
	Low
}
namespace UnityEngine
{
	[Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", false)]
	public enum ParticleSystemEmissionType
	{
		Time,
		Distance
	}
}
