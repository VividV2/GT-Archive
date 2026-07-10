namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public abstract class XRInputDeviceValueReader : ScriptableObject
{
	[SerializeField]
	[Tooltip("Characteristics of the input device to read from. Controllers are either:\nHeld In Hand, Tracked Device, Controller, Left\nHeld In Hand, Tracked Device, Controller, Right")]
	private protected InputDeviceCharacteristics m_Characteristics;

	public InputDeviceCharacteristics characteristics
	{
		get
		{
			return m_Characteristics;
		}
		set
		{
			m_Characteristics = value;
		}
	}
}
