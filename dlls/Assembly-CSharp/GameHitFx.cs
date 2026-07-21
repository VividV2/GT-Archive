using System;
using UnityEngine;
using System;
using UnityEngine;

namespace GorillaNetworking;

public enum KidAgeConfirmationResult
{
	None,
	Confirm,
	Back
}
[Serializable]
public struct GameHitFx
{
	public AbilitySound hitSound;

	public ParticleSystem hitEffect;
}
