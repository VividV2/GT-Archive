namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class LabelTextAttribute : Attribute
	{
		public string Text;

		public bool NicifyText;

		public SdfIconType Icon;

		[ColorResolver]
		public string IconColor;

		public LabelTextAttribute(string text)
		{
			base..ctor();
			Text = text;
		}

		public LabelTextAttribute(SdfIconType icon)
		{
			base..ctor();
			Icon = icon;
		}

		public LabelTextAttribute(string text, bool nicifyText)
		{
			base..ctor();
			Text = text;
			NicifyText = nicifyText;
		}

		public LabelTextAttribute(string text, SdfIconType icon)
		{
			Text = text;
			Icon = icon;
		}

		public LabelTextAttribute(string text, bool nicifyText, SdfIconType icon)
		{
			Text = text;
			NicifyText = nicifyText;
			Icon = icon;
		}
	}
}
