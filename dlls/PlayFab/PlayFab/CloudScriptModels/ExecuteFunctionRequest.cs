namespace PlayFab.CloudScriptModels;

[Serializable]
public class TagModel : PlayFabBaseModel
{
	public string TagValue;

	public TagModel()
	{
		base..ctor();
	}
}
