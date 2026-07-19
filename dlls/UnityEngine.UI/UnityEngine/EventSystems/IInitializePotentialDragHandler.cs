namespace UnityEngine.EventSystems
{
	public interface IInitializePotentialDragHandler : IEventSystemHandler
	{
		void OnInitializePotentialDrag(PointerEventData eventData);
	}
}
namespace UnityEngine.EventSystems
{
	public interface IEndDragHandler : IEventSystemHandler
	{
		void OnEndDrag(PointerEventData eventData);
	}
}
