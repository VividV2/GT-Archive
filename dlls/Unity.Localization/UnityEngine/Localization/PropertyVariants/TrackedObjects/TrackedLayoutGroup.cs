using System;
using UnityEngine.UI;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	public interface IStringProperty : ITrackedProperty
	{
		string GetValueAsString(LocaleIdentifier localeIdentifier);

		string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback);

		void SetValueFromString(LocaleIdentifier localeIdentifier, string value);
	}
}
namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	[Serializable]
	[DisplayName("Layout Group", null)]
	[CustomTrackedObject(typeof(LayoutGroup), true)]
	public class TrackedLayoutGroup : JsonSerializerTrackedObject
	{
		protected override void PostApplyTrackedProperties()
		{
			if (base.Target is LayoutGroup { transform: RectTransform transform })
			{
				LayoutRebuilder.MarkLayoutForRebuild(transform);
			}
			base.PostApplyTrackedProperties();
		}
	}
}
