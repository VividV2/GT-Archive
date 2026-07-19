namespace PlayFab.MultiplayerModels;

[Serializable]
public class ShutdownMultiplayerServerRequest : PlayFabRequestCommon
{
	public string BuildId;

	public string Region;

	public string SessionId;
}
