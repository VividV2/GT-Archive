using System;

namespace Oculus.Interaction
{
	public interface IPointableElement : IPointable
	{
		void ProcessPointerEvent(PointerEvent evt);
	}
}
namespace Oculus.Interaction
{
	public interface ISelector
	{
		event Action WhenSelected;

		event Action WhenUnselected;
	}
}
namespace Oculus.Interaction
{
}
