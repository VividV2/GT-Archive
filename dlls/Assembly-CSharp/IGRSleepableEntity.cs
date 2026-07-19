using UnityEngine;

namespace GorillaNetworking.Store;

public interface IGRSleepableEntity
{
	Vector3 Position { get; }

	float WakeUpRadius { get; }

	bool IsSleeping();

	void WakeUp();

	void Sleep();
}
namespace Voxels
{
}
