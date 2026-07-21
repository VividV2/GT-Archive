namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class NameIdentifier : PlayFabBaseModel
	{
		public string Id;

		public string Name;

		public NameIdentifier()
		{
			base..ctor();
		}
	}
}
