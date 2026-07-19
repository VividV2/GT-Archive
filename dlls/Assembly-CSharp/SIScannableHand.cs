using UnityEngine;

public enum GTAgeStatusType
{
	PROHIBITED,
	DIGITALMINOR,
	DIGITALYOUTH,
	LEGALADULT
}
public class SIScannableHand : MonoBehaviour
{
	public SIPlayer parentPlayer;

	private void Awake()
	{
		parentPlayer = GetComponentInParent<SIPlayer>();
	}
}
