using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	public struct InputDeviceCommand : IInputDeviceCommandInfo
	{
		internal const int kBaseCommandSize = 8;

		public const int BaseCommandSize = 8;

		public const long GenericFailure = -1L;

		public const long GenericSuccess = 1L;

		[FieldOffset(0)]
		public FourCC type;

		[FieldOffset(4)]
		public int sizeInBytes;

		public int payloadSizeInBytes => sizeInBytes - 8;

		public unsafe void* payloadPtr
		{
			get
			{
				fixed (InputDeviceCommand* ptr = &this)
				{
					void* ptr2 = ptr;
					void* ptr2;
					return (byte*)ptr2 + 8;
				}
			}
		}

		public FourCC typeStatic => default(FourCC);

		public InputDeviceCommand(FourCC type, int sizeInBytes = 8)
		{
			this.type = type;
			this.sizeInBytes = sizeInBytes;
		}

		public unsafe static NativeArray<byte> AllocateNative(FourCC type, int payloadSize)
		{
			int length = payloadSize + 8;
			int length;
			NativeArray<byte> nativeArray = new NativeArray<byte>(length, Allocator.Temp);
			NativeArray<byte> nativeArray;
			InputDeviceCommand* unsafePtr = (InputDeviceCommand*)nativeArray.GetUnsafePtr();
			InputDeviceCommand* unsafePtr;
			unsafePtr->type = type;
			unsafePtr->sizeInBytes = length;
			return nativeArray;
		}
	}
}
namespace UnityEngine.InputSystem.Haptics
{
	internal struct DualMotorRumble
	{
		public float lowFrequencyMotorSpeed { get; private set; }

		public float highFrequencyMotorSpeed { get; private set; }

		public bool isRumbling
		{
			get
			{
				if (Mathf.Approximately(lowFrequencyMotorSpeed, 0f))
				{
					return !Mathf.Approximately(highFrequencyMotorSpeed, 0f);
				}
				return true;
			}
		}

		public void PauseHaptics(InputDevice device)
		{
			if (device == null)
			{
				throw new ArgumentNullException("device");
			}
			if (isRumbling)
			{
				DualMotorRumbleCommand command = DualMotorRumbleCommand.Create(0f, 0f);
				device.ExecuteCommand(ref command);
			}
		}

		public void ResumeHaptics(InputDevice device)
		{
			if (device == null)
			{
				throw new ArgumentNullException("device");
			}
			if (isRumbling)
			{
				SetMotorSpeeds(device, lowFrequencyMotorSpeed, highFrequencyMotorSpeed);
			}
		}

		public void ResetHaptics(InputDevice device)
		{
			if (device == null)
			{
				throw new ArgumentNullException("device");
			}
			if (isRumbling)
			{
				SetMotorSpeeds(device, 0f, 0f);
			}
		}

		public void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency)
		{
			if (device == null)
			{
				throw new ArgumentNullException("device");
			}
			lowFrequencyMotorSpeed = Mathf.Clamp(lowFrequency, 0f, 1f);
			highFrequencyMotorSpeed = Mathf.Clamp(highFrequency, 0f, 1f);
			DualMotorRumbleCommand command = DualMotorRumbleCommand.Create(lowFrequencyMotorSpeed, highFrequencyMotorSpeed);
			device.ExecuteCommand(ref command);
		}
	}
}
