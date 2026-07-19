using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
}
namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal delegate bool EventConsumer(in Event ev);
}
namespace UnityEngine.InputForUI
{
	internal interface IEventProviderImpl
	{
		uint playerCount { get; }

		void Initialize();

		void Shutdown();

		void Update();

		void OnFocusChanged(bool focus);

		bool RequestCurrentState(Event.Type type);
	}
}
