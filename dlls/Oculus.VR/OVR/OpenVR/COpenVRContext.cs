using System;

namespace OVR.OpenVR
{
	public struct COpenVRContext
	{
		public IntPtr m_pVRSystem;

		public IntPtr m_pVRChaperone;

		public IntPtr m_pVRChaperoneSetup;

		public IntPtr m_pVRCompositor;

		public IntPtr m_pVROverlay;

		public IntPtr m_pVRResources;

		public IntPtr m_pVRRenderModels;

		public IntPtr m_pVRExtendedDisplay;

		public IntPtr m_pVRSettings;

		public IntPtr m_pVRApplications;

		public IntPtr m_pVRTrackedCamera;

		public IntPtr m_pVRScreenshots;

		public IntPtr m_pVRDriverManager;

		public IntPtr m_pVRInput;

		public IntPtr m_pVRIOBuffer;

		public IntPtr m_pVRSpatialAnchors;
	}
}
namespace OVR.OpenVR
{
	public enum EVRApplicationError
	{
		None = 0,
		AppKeyAlreadyExists = 100,
		NoManifest = 101,
		NoApplication = 102,
		InvalidIndex = 103,
		UnknownApplication = 104,
		IPCFailed = 105,
		ApplicationAlreadyRunning = 106,
		InvalidManifest = 107,
		InvalidApplication = 108,
		LaunchFailed = 109,
		ApplicationAlreadyStarting = 110,
		LaunchInProgress = 111,
		OldApplicationQuitting = 112,
		TransitionAborted = 113,
		IsTemplate = 114,
		SteamVRIsExiting = 115,
		BufferTooSmall = 200,
		PropertyNotSet = 201,
		UnknownProperty = 202,
		InvalidParameter = 203
	}
}
