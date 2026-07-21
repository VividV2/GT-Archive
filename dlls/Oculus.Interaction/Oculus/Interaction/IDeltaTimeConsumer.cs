using System;

namespace Oculus.Interaction
{
}
namespace Oculus.Interaction
{
	public interface IDeltaTimeConsumer
	{
		void SetDeltaTimeProvider(Func<float> deltaTimeProvider);
	}
}
