namespace UnityEngine.EventSystems;

public interface IMoveHandler : IEventSystemHandler
{
	void OnMove(AxisEventData eventData);
}
namespace UnityEngine.EventSystems
{
	public interface IScrollHandler : IEventSystemHandler
	{
		void OnScroll(PointerEventData eventData);
	}
}
