using System;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Events;

namespace Oculus.Assistant.VoiceCommand.Listeners
{
	[Serializable]
	public class SlotHandler
	{
		[Tooltip("The name of the slot to listen for")]
		public string slotName;

		public OnCommandSlotReceived onCommandSlotReceived = new OnCommandSlotReceived();

		public override string ToString()
		{
			return slotName;
		}
	}
}
namespace Oculus.Assistant.VoiceCommand.Configuration
{
}
namespace Oculus.Assistant.VoiceCommand.Listeners
{
	[Serializable]
	public class OnCommandSlotReceived : UnityEvent<string>
	{
	}
}
namespace Oculus.Assistant.VoiceCommand.Listeners
{
}
namespace Oculus.Assistant.VoiceCommand.Data
{
}
