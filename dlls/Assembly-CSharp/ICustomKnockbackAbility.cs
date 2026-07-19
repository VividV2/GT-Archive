using UnityEngine;

namespace TagEffects;

public interface ICustomKnockbackAbility
{
	Vector3? CalculateImpulse(Transform targetTransform);
}
