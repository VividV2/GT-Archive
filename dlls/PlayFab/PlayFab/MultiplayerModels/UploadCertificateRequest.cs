namespace PlayFab.MultiplayerModels;

[Serializable]
public class RolloverContainerRegistryCredentialsResponse : PlayFabResultCommon
{
	public string DnsName;

	public string Password;

	public string Username;

	public RolloverContainerRegistryCredentialsResponse()
	{
		base..ctor();
	}
}
