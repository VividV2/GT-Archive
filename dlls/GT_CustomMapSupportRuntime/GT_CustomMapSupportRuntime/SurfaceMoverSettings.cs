using UnityEngine;
using UnityEngine;

namespace GT_CustomMapSupportRuntime
{
	public static class Utilities
	{
		public static string SanitizeString(string str)
		{
			string text = "";
			int i;
			string text;
			for (int i = 0; i < str.Length; i++)
			{
				if (char.IsLetterOrDigit(str[i]))
				{
					text += str[i];
				}
				else if (char.IsWhiteSpace(str[i]))
				{
					text += "-";
				}
			}
			return text;
		}

		private static void StripMeshesForObjectsOfType<T>(GameObject rootObject)
		{
			T[] componentsInChildren = rootObject.GetComponentsInChildren<T>();
			T[] componentsInChildren;
			foreach (T val in componentsInChildren)
			{
				Component component = val as Component;
				Component component;
				if (!(component == null))
				{
					if (component.gameObject.GetComponent<Renderer>() != null)
					{
						Object.DestroyImmediate(component.gameObject.GetComponent<Renderer>());
					}
					if (component.gameObject.GetComponent<MeshFilter>() != null)
					{
						Object.DestroyImmediate(component.gameObject.GetComponent<MeshFilter>());
					}
				}
			}
		}

		public static string GetSceneNameFromFilePath(string filePath, bool sanitizeName = true)
		{
			string[] array = filePath.Split('/')[^1].Split('.');
			string text = "";
			int i;
			string[] array;
			string text;
			for (int i = 0; i < array.Length - 1; i++)
			{
				text += array[i];
				if (i < array.Length - 2)
				{
					text += ".";
				}
			}
			return sanitizeName ? SanitizeString(text) : text;
		}
	}
}
namespace GT_CustomMapSupportRuntime
{
	public class SurfaceMoverSettings : MonoBehaviour
	{
		public enum MoveType
		{
			Translation,
			Rotation
		}

		public enum RotationAxis
		{
			X,
			Y,
			Z
		}

		[SerializeField]
		public MoveType moveType = MoveType.Translation;

		[Range(0.001f, float.MaxValue)]
		[Tooltip("Meters per second for Translation | Revolutions per second for Rotation")]
		[SerializeField]
		public float velocity = 0.001f;

		[Range(0f, float.MaxValue)]
		[Tooltip("How long in seconds should the cycle be delayed?")]
		[SerializeField]
		public float cycleDelay;

		[Tooltip("If TRUE, Translation mode will move from End to Start; Rotation mode will rotate in the negative direction.")]
		[SerializeField]
		public bool reverseDir;

		[Tooltip("If TRUE, Translation mode movement direction will be reversed when it reaches Start or End; Rotation mode rotation direction will be reversed once it's rotated the full Rotation Amount")]
		[SerializeField]
		public bool reverseDirOnCycle = true;

		[SerializeField]
		public Transform? start;

		[SerializeField]
		public Transform? end;

		[Tooltip("Which local axis should the object rotate around?")]
		[SerializeField]
		public RotationAxis rotationAxis = RotationAxis.Y;

		[Range(0.001f, 360f)]
		[Tooltip("How far should the object rotate per-cycle (in degrees)")]
		[SerializeField]
		public float rotationAmount = 360f;

		[Tooltip("If TRUE the rotation starting point will be the initial Y-axis rotation value of the object when the map is loaded, otherwise it will start at 0")]
		[SerializeField]
		public bool rotationRelativeToStarting = true;

		public bool hasBeenExported;

		private AnimationCurve? lerpAlpha;

		private Vector3 startingRotation;

		private float cycleDuration;

		private float distance;

		private float currT;

		private float percent;

		private bool currForward;

		public void OnEnable()
		{
			if (hasBeenExported)
			{
				return;
			}
			if (moveType == MoveType.Translation && start != null && end != null)
			{
				distance = Vector3.Distance(end.position, start.position);
				float num = distance / velocity;
				cycleDuration = num + cycleDelay;
			}
			else
			{
				if (rotationRelativeToStarting)
				{
					startingRotation = base.transform.localRotation.eulerAngles;
				}
				cycleDuration = rotationAmount / 360f / velocity;
				cycleDuration += cycleDelay;
			}
			float num2 = cycleDelay / cycleDuration;
			Vector2 vector = new Vector2(num2 / 2f, 0f);
			Vector2 vector2 = new Vector2(1f - num2 / 2f, 1f);
			float num3 = (vector2.y - vector.y) / (vector2.x - vector.x);
			lerpAlpha = new AnimationCurve(new Keyframe(num2 / 2f, 0f, 0f, num3), new Keyframe(1f - num2 / 2f, 1f, num3, 0f));
		}

		private void FixedUpdate()
		{
			if (!hasBeenExported)
			{
				Move();
			}
		}

		private long NetworkTimeMs()
		{
			return (long)(Time.time * 1000f);
		}

		private long CycleLengthMs()
		{
			return (long)(cycleDuration * 1000f);
		}

		private double PlatformTime()
		{
			long num = NetworkTimeMs();
			long num2 = CycleLengthMs();
			long num3 = num - num / num2 * num2;
			return (double)num3 / 1000.0;
		}

		private int CycleCount()
		{
			return (int)(NetworkTimeMs() / CycleLengthMs());
		}

		private float CycleCompletionPercent()
		{
			float value = (float)(PlatformTime() / (double)cycleDuration);
			return Mathf.Clamp(value, 0f, 1f);
		}

		private bool IsEvenCycle()
		{
			int num = CycleCount();
			return num % 2 == 0;
		}

		public void Move()
		{
			Progress();
			switch (moveType)
			{
			case MoveType.Translation:
				base.transform.localPosition = UpdatePointToPoint(percent);
				break;
			case MoveType.Rotation:
				UpdateRotation(percent);
				break;
			}
		}

		private Vector3 UpdatePointToPoint(float percentage)
		{
			if (lerpAlpha == null || start == null || end == null)
			{
				return base.transform.localPosition;
			}
			float t = lerpAlpha.Evaluate(percentage);
			return Vector3.Lerp(start.localPosition, end.localPosition, t);
		}

		private void UpdateRotation(float percentage)
		{
			if (lerpAlpha == null)
			{
				return;
			}
			float num = lerpAlpha.Evaluate(percentage);
			float num2 = num * rotationAmount;
			if (rotationRelativeToStarting)
			{
				Vector3 euler = startingRotation;
				switch (rotationAxis)
				{
				case RotationAxis.X:
					euler.x += num2;
					break;
				case RotationAxis.Y:
					euler.y += num2;
					break;
				case RotationAxis.Z:
					euler.z += num2;
					break;
				}
				base.transform.localRotation = Quaternion.Euler(euler);
			}
			else
			{
				switch (rotationAxis)
				{
				case RotationAxis.X:
					base.transform.localRotation = Quaternion.AngleAxis(num2, Vector3.right);
					break;
				case RotationAxis.Y:
					base.transform.localRotation = Quaternion.AngleAxis(num2, Vector3.up);
					break;
				case RotationAxis.Z:
					base.transform.localRotation = Quaternion.AngleAxis(num2, Vector3.forward);
					break;
				}
			}
		}

		private void Progress()
		{
			currT = CycleCompletionPercent();
			currForward = IsEvenCycle();
			percent = currT;
			if (reverseDirOnCycle)
			{
				percent = (currForward ? currT : (1f - currT));
			}
			if (reverseDir)
			{
				percent = 1f - percent;
			}
		}
	}
}
