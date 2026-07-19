using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Processors
{
	[DesignTimeVisible(false)]
	internal class CompensateRotationProcessor : InputProcessor<Quaternion>
	{
		public override CachingPolicy cachingPolicy => CachingPolicy.EvaluateOnEveryRead;

		public override Quaternion Process(Quaternion value, InputControl control)
		{
			if (!InputSystem.settings.compensateForScreenOrientation)
			{
				return value;
			}
			Quaternion quaternion = Quaternion.identity;
			switch (InputRuntime.s_Instance.screenOrientation)
			{
			case ScreenOrientation.PortraitUpsideDown:
				quaternion = new Quaternion(0f, 0f, 1f, 0f);
				break;
			case ScreenOrientation.LandscapeLeft:
				quaternion = new Quaternion(0f, 0f, 0.70710677f, -0.70710677f);
				break;
			case ScreenOrientation.LandscapeRight:
				quaternion = new Quaternion(0f, 0f, -0.70710677f, -0.70710677f);
				break;
			}
			return value * quaternion;
		}

		public override string ToString()
		{
			return "CompensateRotation()";
		}
	}
}
namespace UnityEngine.InputSystem.DualShock
{
}
namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	public struct SetSamplingFrequencyCommand : IInputDeviceCommandInfo
	{
		internal const int kSize = 12;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public float frequency;

		public static FourCC Type => new FourCC('S', 'S', 'P', 'L');

		public FourCC typeStatic => Type;

		public static SetSamplingFrequencyCommand Create(float frequency)
		{
			return new SetSamplingFrequencyCommand
			{
				baseCommand = new InputDeviceCommand(Type, 12),
				frequency = frequency
			};
		}
	}
}
