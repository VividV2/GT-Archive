namespace PlayFab.ClientModels;

[Serializable]
public class GetSegmentResult : PlayFabBaseModel
{
	public string ABTestParent;

	public string Id;

	public string Name;

	public GetSegmentResult()
	{
		base..ctor();
	}
}
