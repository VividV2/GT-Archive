using System;
using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public interface IVisualElementScheduledItem
	{
		VisualElement element { get; }

		bool isActive { get; }

		void Resume();

		void Pause();

		void ExecuteLater(long delayMs);

		IVisualElementScheduledItem StartingIn(long delayMs);

		IVisualElementScheduledItem Every(long intervalMs);

		IVisualElementScheduledItem Until(Func<bool> stopCondition);

		IVisualElementScheduledItem ForDuration(long durationMs);
	}
}
namespace UnityEngine.UIElements
{
	[NativeType(Header = "Modules/UIElements/VisualNodeTextData.h")]
	internal struct VisualNodeTextData
	{
		internal LanguageDirection LanguageDirection;

		internal LanguageDirection LocalLanguageDirection;
	}
}
namespace UnityEngine.UIElements
{
}
