using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization.Metadata
{
	public interface IEntryOverride : IMetadata
	{
		EntryOverrideType GetOverride(out TableReference tableReference, out TableEntryReference tableEntryReference);
	}
}
namespace UnityEngine.Localization.SmartFormat.GlobalVariables
{
}
namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	internal interface ITrackedPropertyRemoveVariant
	{
		void RemoveVariant(LocaleIdentifier localeIdentifier);
	}
}
