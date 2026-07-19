namespace UnityEngine.UIElements
{
	internal interface ISerializedObjectList : IList, ICollection, IEnumerable
	{
		int minArraySize { get; }

		int arraySize { get; set; }

		void ApplyChanges();

		void RemoveAt(int index, int listCount);

		void Move(int srcIndex, int destIndex);
	}
}
namespace UnityEngine.UIElements
{
	internal enum ColliderUpdateMode
	{
		[InspectorName("Match 3-D bounding box")]
		MatchBoundingBox,
		[InspectorName("Keep existing colliders (if any)")]
		Keep,
		[InspectorName("Match 2-D document rect")]
		MatchDocumentRect
	}
}
