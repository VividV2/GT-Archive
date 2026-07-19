namespace Fusion
{
	public interface IAfterRender : IPublicFacingInterface
	{
		void AfterRender();
	}
}
namespace Fusion
{
	public interface IInterestEnter : IPublicFacingInterface
	{
		void InterestEnter(PlayerRef player);
	}
}
