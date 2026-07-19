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
