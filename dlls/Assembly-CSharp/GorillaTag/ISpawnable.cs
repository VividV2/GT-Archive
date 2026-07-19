using GorillaTag.CosmeticSystem;

namespace GorillaTag
{
	public interface ISpawnable
	{
		bool IsSpawned { get; set; }

		ECosmeticSelectSide CosmeticSelectedSide { get; set; }

		void OnSpawn(VRRig rig);

		void OnDespawn();
	}
}
namespace GorillaTag
{
}
namespace Fusion.CodeGen
{
}
