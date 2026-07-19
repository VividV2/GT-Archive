using System;

namespace Meta.WitAi.Composer.Handlers
{
	[Serializable]
	public struct ComposerActionEventData
	{
		public string actionID;

		public ComposerActionEvent actionEvent;
	}
}
namespace Meta.WitAi.Composer.Handlers
{
	[Serializable]
	public struct ComposerSpeakerData
	{
		[]
		[FormerlySerializedAs("speakerName")]
		public string SpeakerName;

		[]
		[FormerlySerializedAs("speaker")]
		public TTSSpeaker Speaker;
	}
}
