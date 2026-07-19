using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements
{
	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public interface IValueField<T>
	{
		T value { get; set; }

		void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue);

		void StartDragging();

		void StopDragging();
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
	internal struct Hashes
	{
		public const int kSize = 4;

		public unsafe fixed int hashes[4];
	}
}
