using System;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Valve.VR;

public struct IVRChaperoneSetup
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RevertWorkingCopy();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingCollisionBoundsInfo([In][Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingPerimeter([In][Out] HmdVector2_t[] pPointBuffer, uint unPointCount);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ExportLiveToBuffer(StringBuilder pBuffer, ref uint pnBufferLength);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ImportFromBufferToWorking(IntPtr pBuffer, uint nImportFlags);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowWorkingSetPreview();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideWorkingSetPreview();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RoomSetupStarting();

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CommitWorkingCopy CommitWorkingCopy;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RevertWorkingCopy RevertWorkingCopy;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPerimeter SetWorkingPerimeter;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadFromDisk ReloadFromDisk;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ExportLiveToBuffer ExportLiveToBuffer;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ImportFromBufferToWorking ImportFromBufferToWorking;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowWorkingSetPreview ShowWorkingSetPreview;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideWorkingSetPreview HideWorkingSetPreview;

	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RoomSetupStarting RoomSetupStarting;
}
namespace Valve.VR
{
	public struct HmdMatrix34_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;

		public Vector3 GetPosition()
		{
			return new Vector3(m3, m7, 0f - m11);
		}

		public bool IsRotationValid()
		{
			if (m2 != 0f || m6 != 0f || m10 != 0f)
			{
				if (m1 == 0f && m5 == 0f)
				{
					return m9 != 0f;
				}
				return true;
			}
			return false;
		}

		public Quaternion GetRotation()
		{
			if (IsRotationValid())
			{
				float w = Mathf.Sqrt(Mathf.Max(0f, 1f + m0 + m5 + m10)) / 2f;
				float sizeval = Mathf.Sqrt(Mathf.Max(0f, 1f + m0 - m5 - m10)) / 2f;
				float sizeval2 = Mathf.Sqrt(Mathf.Max(0f, 1f - m0 + m5 - m10)) / 2f;
				float sizeval3 = Mathf.Sqrt(Mathf.Max(0f, 1f - m0 - m5 + m10)) / 2f;
				_copysign(ref sizeval, 0f - m9 - (0f - m6));
				_copysign(ref sizeval2, 0f - m2 - (0f - m8));
				_copysign(ref sizeval3, m4 - m1);
				return new Quaternion(sizeval, sizeval2, sizeval3, w);
			}
			return Quaternion.identity;
		}

		private static void _copysign(ref float sizeval, float signval)
		{
			if (signval > 0f != sizeval > 0f)
			{
				sizeval = 0f - sizeval;
			}
		}
	}
}
