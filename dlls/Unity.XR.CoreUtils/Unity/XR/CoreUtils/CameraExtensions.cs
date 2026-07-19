using System;
using UnityEngine;
using System;
using System;

namespace Unity.XR.CoreUtils
{
	public static class GuidExtensions
	{
		public static void Decompose(this Guid guid, out ulong low, out ulong high)
		{
			byte[] value = guid.ToByteArray();
			byte[] value;
			byte[] value;
			low = BitConverter.ToUInt64(value, 0);
			high = BitConverter.ToUInt64(value, 8);
		}
	}
}
namespace Unity.XR.CoreUtils
{
	public static class CameraExtensions
	{
		private const float k_OneOverSqrt2 = 0.70710677f;

		public static float GetVerticalFieldOfView(this Camera camera, float aspectNeutralFieldOfView)
		{
			return Mathf.Atan(Mathf.Tan(aspectNeutralFieldOfView * 0.5f * (MathF.PI / 180f)) * 0.70710677f / Mathf.Sqrt(camera.aspect)) * 2f * 57.29578f;
		}

		public static float GetHorizontalFieldOfView(this Camera camera)
		{
			float num = camera.fieldOfView * 0.5f;
			return 57.29578f * Mathf.Atan(Mathf.Tan(num * (MathF.PI / 180f)) * camera.aspect);
		}

		public static float GetVerticalOrthographicSize(this Camera camera, float size)
		{
			return size * 0.70710677f / Mathf.Sqrt(camera.aspect);
		}
	}
}
