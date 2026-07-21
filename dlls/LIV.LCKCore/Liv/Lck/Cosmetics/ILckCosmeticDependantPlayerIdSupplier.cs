namespace Liv.Lck.Cosmetics
{
	public interface ILckCosmeticDependantPlayerIdSupplier
	{
		event PlayerIdUpdatedEvent PlayerIdUpdated;

		string GetPlayerId();

		void UpdatePlayerId();
	}
}
namespace Liv.Lck.Core.Cosmetics
{
}
namespace Liv.Lck.Core
{
}
