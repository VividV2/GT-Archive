namespace UnityEngine.ProBuilder
{
	public enum HandleOrientation
	{
		World,
		ActiveObject,
		ActiveElement
	}
}
namespace UnityEngine.ProBuilder
{
	internal interface IHasDefault
	{
		void SetDefaultValues();
	}
}
