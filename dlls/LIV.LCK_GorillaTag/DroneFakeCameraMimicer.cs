using UnityEngine;
using UnityEngine;

namespace Liv.Lck.GorillaTag
{
	public class DroneCamera(Camera camera)
	{
		private Camera _camera = camera;

		private float _targetFov;

		private float _smoothness;

		public void SetFov(float fov)
		{
			_targetFov = fov;
		}

		public void SetSmoothness(float smoothness)
		{
			_smoothness = smoothness;
		}

		public void Run()
		{
			if (!Mathf.Approximately(_camera.fieldOfView, _targetFov))
			{
				_camera.fieldOfView = Mathf.Lerp(_camera.fieldOfView, _targetFov, Time.deltaTime / _smoothness);
			}
		}
	}
}
namespace Liv.Lck.Tablet
{
}
[RequireComponent(typeof(Camera))]
public class DroneFakeCameraMimicer : MonoBehaviour
{
	[SerializeField]
	private Camera _target;

	private Camera _mimicer;

	private void Awake()
	{
		_mimicer = GetComponent<Camera>();
	}

	private void LateUpdate()
	{
		if (_target == null)
		{
			Debug.LogWarning("No target assigned to DroneFakeCameraMimicer");
		}
		else
		{
			_mimicer.fieldOfView = _target.fieldOfView;
		}
	}
}
