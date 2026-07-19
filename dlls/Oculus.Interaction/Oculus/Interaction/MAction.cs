using System;

namespace Oculus.Interaction.Surfaces
{
}
namespace Oculus.Interaction
{
	public interface MAction<out T>
	{
		event Action<T> Action;
	}
}
