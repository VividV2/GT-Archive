namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ListMembershipResponse : PlayFabResultCommon
	{
		public List<GroupWithRoles> Groups;

		public ListMembershipResponse()
		{
			base..ctor();
		}
	}
}
namespace PlayFab.ExperimentationModels
{
}
