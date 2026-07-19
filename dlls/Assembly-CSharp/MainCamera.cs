using UnityEngine;
using UnityEngine;

public enum GRShiftStatType
{
	EnemyDeaths,
	PlayerDeaths,
	CoresCollected,
	SentientCoresCollected
}
public class GRLevelAnchor : MonoBehaviour
{
	public Transform navigablePoint;
}
public class MainCamera : MonoBehaviourStatic<MainCamera>
{
	public Camera camera;

	public static implicit operator Camera(MainCamera mc)
	{
		return mc.camera;
	}
}
