using UnityEngine.UIElements;
using UnityEngine.UIElements;

namespace Unity.Multiplayer.Center.Common.Analytics
{
	public interface IOnboardingSectionAnalyticsProvider
	{
		void SendInteractionEvent(InteractionDataType type, string displayName);
	}
}
namespace Unity.Multiplayer.Center.Common
{
	public interface IOnboardingSection
	{
		VisualElement Root { get; }

		void Load();

		void Unload();
	}
}
