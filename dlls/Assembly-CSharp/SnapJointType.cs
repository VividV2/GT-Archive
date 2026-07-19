using System;
using UnityEngine;
using UnityEngine;
using UnityEngine;

public class AttemptAgeUpdateData(SessionStatus status)
{
	public readonly SessionStatus status = status;
}
public class SIResourceMonkeIdol : SIResource
{
	[SerializeField]
	private GameObject depositEnabledParticle;

	protected override void OnEnable()
	{
		base.OnEnable();
		depositEnabledParticle.SetActive(SIPlayer.LocalPlayer.CanLimitedResourceBeDeposited(limitedDepositType));
	}

	public override void HandleDepositAuth(SIPlayer depositingPlayer)
	{
		SIPlayer.LocalPlayer.TriggerIdolDepositedCelebration(base.transform.position);
	}
}
[Flags]
public enum SnapJointType
{
	None = 0,
	HandL = 1,
	HandR = 4,
	Chest = 8,
	Back = 0x10,
	Head = 0x20,
	Holster = 0x40,
	ForearmL = 0x80,
	ForearmR = 0x100,
	AuxHead = 0x200,
	AuxBody1 = 0x400,
	AuxBody2 = 0x800,
	AuxShoulderL = 0x1000,
	AuxShoulderR = 0x2000,
	Max = 0x4000
}
