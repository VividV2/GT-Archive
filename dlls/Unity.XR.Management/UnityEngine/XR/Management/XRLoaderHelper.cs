using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Management
{
}
namespace UnityEngine.XR.Management
{
}
namespace UnityEngine.XR.Management
{
	public class XRGeneralSettings : ScriptableObject
	{
		public static string k_SettingsKey = "com.unity.xr.management.loader_settings";

		internal static XRGeneralSettings s_RuntimeSettingsInstance = null;

		[SerializeField]
		internal XRManagerSettings m_LoaderManagerInstance;

		[SerializeField]
		[Tooltip("Toggling this on/off will enable/disable the automatic startup of XR at run time.")]
		internal bool m_InitManagerOnStart = true;

		private XRManagerSettings m_XRManager;

		private bool m_ProviderIntialized;

		private bool m_ProviderStarted;

		public XRManagerSettings Manager
		{
			get
			{
				return m_LoaderManagerInstance;
			}
			set
			{
				m_LoaderManagerInstance = value;
			}
		}

		public static XRGeneralSettings Instance => s_RuntimeSettingsInstance;

		public XRManagerSettings AssignedSettings => m_LoaderManagerInstance;

		public bool InitManagerOnStart => m_InitManagerOnStart;

		private void Awake()
		{
			Debug.Log("XRGeneral Settings awakening...");
			s_RuntimeSettingsInstance = this;
			Application.quitting += Quit;
			Object.DontDestroyOnLoad(s_RuntimeSettingsInstance);
		}

		private static void Quit()
		{
			XRGeneralSettings instance = Instance;
			XRGeneralSettings instance;
			if (!(instance == null))
			{
				instance.DeInitXRSDK();
			}
		}

		private void Start()
		{
			StartXRSDK();
		}

		private void OnDestroy()
		{
			DeInitXRSDK();
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		internal static void AttemptInitializeXRSDKOnLoad()
		{
			XRGeneralSettings instance = Instance;
			XRGeneralSettings instance;
			if (!(instance == null) && instance.InitManagerOnStart)
			{
				instance.InitXRSDK();
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
		internal static void AttemptStartXRSDKOnBeforeSplashScreen()
		{
			XRGeneralSettings instance = Instance;
			XRGeneralSettings instance;
			if (!(instance == null) && instance.InitManagerOnStart)
			{
				instance.StartXRSDK();
			}
		}

		private void InitXRSDK()
		{
			if (!(Instance == null) && !(Instance.m_LoaderManagerInstance == null) && Instance.m_InitManagerOnStart)
			{
				m_XRManager = Instance.m_LoaderManagerInstance;
				if (m_XRManager == null)
				{
					Debug.LogError("Assigned GameObject for XR Management loading is invalid. No XR Providers will be automatically loaded.");
					return;
				}
				m_XRManager.automaticLoading = false;
				m_XRManager.automaticRunning = false;
				m_XRManager.InitializeLoaderSync();
				m_ProviderIntialized = true;
			}
		}

		private void StartXRSDK()
		{
			if (m_XRManager != null && m_XRManager.activeLoader != null)
			{
				m_XRManager.StartSubsystems();
				m_ProviderStarted = true;
			}
		}

		private void StopXRSDK()
		{
			if (m_XRManager != null && m_XRManager.activeLoader != null)
			{
				m_XRManager.StopSubsystems();
				m_ProviderStarted = false;
			}
		}

		private void DeInitXRSDK()
		{
			if (m_XRManager != null && m_XRManager.activeLoader != null)
			{
				m_XRManager.DeinitializeLoader();
				m_XRManager = null;
				m_ProviderIntialized = false;
			}
		}
	}
}
namespace UnityEngine.XR.Management
{
	public abstract class XRLoaderHelper : XRLoader
	{
		protected Dictionary<Type, ISubsystem> m_SubsystemInstanceMap = new Dictionary<Type, ISubsystem>();

		public override T GetLoadedSubsystem<T>()
		{
			Type typeFromHandle = typeof(T);
			m_SubsystemInstanceMap.TryGetValue(typeFromHandle, out var value);
			return value as T;
		}

		protected void StartSubsystem<T>() where T : class, ISubsystem
		{
			GetLoadedSubsystem<T>()?.Start();
		}

		protected void StopSubsystem<T>() where T : class, ISubsystem
		{
			GetLoadedSubsystem<T>()?.Stop();
		}

		protected void DestroySubsystem<T>() where T : class, ISubsystem
		{
			T loadedSubsystem = GetLoadedSubsystem<T>();
			if (loadedSubsystem != null)
			{
				Type typeFromHandle = typeof(T);
				if (m_SubsystemInstanceMap.ContainsKey(typeFromHandle))
				{
					m_SubsystemInstanceMap.Remove(typeFromHandle);
				}
				loadedSubsystem.Destroy();
			}
		}

		protected void CreateSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : ISubsystemDescriptor where TSubsystem : ISubsystem
		{
			if (descriptors == null)
			{
				throw new ArgumentNullException("descriptors");
			}
			SubsystemManager.GetSubsystemDescriptors(descriptors);
			if (descriptors.Count <= 0)
			{
				return;
			}
			foreach (TDescriptor descriptor in descriptors)
			{
				ISubsystem subsystem = null;
				if (string.Compare(descriptor.id, id, ignoreCase: true) == 0)
				{
					subsystem = descriptor.Create();
				}
				if (subsystem != null)
				{
					m_SubsystemInstanceMap[typeof(TSubsystem)] = subsystem;
					break;
				}
			}
		}

		[Obsolete("This method is obsolete. Please use the geenric CreateSubsystem method.", false)]
		protected void CreateIntegratedSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : IntegratedSubsystemDescriptor where TSubsystem : IntegratedSubsystem
		{
			CreateSubsystem<TDescriptor, TSubsystem>(descriptors, id);
		}

		[Obsolete("This method is obsolete. Please use the generic CreateSubsystem method.", false)]
		protected void CreateStandaloneSubsystem<TDescriptor, TSubsystem>(List<TDescriptor> descriptors, string id) where TDescriptor : SubsystemDescriptor where TSubsystem : Subsystem
		{
			CreateSubsystem<TDescriptor, TSubsystem>(descriptors, id);
		}

		public override bool Deinitialize()
		{
			m_SubsystemInstanceMap.Clear();
			return base.Deinitialize();
		}
	}
}
namespace UnityEngine.XR.Management
{
}
