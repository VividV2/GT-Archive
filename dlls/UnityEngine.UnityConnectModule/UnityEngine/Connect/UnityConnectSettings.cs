using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Advertisements
{
	[NativeHeader("Modules/UnityConnect/UnityAds/UnityAdsSettings.h")]
	internal static class UnityAdsSettings
	{
		[StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
		public static extern bool enabled
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[ThreadSafe]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[ThreadSafe]
			set;
		}

		[StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
		public static extern bool initializeOnStartup
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
		public static extern bool testMode
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[Obsolete("warning No longer supported and will always return true")]
		public static bool IsPlatformEnabled(RuntimePlatform platform)
		{
			return true;
		}

		[Obsolete("warning No longer supported and will do nothing")]
		public static void SetPlatformEnabled(RuntimePlatform platform, bool value)
		{
		}

		[StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
		public static string GetGameId(RuntimePlatform platform)
		{
			ManagedSpanWrapper ret = default(ManagedSpanWrapper);
			string stringAndDispose;
			ManagedSpanWrapper ret = default(ManagedSpanWrapper);
			string stringAndDispose;
			try
			{
				GetGameId_Injected(platform, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}

		[StaticAccessor("GetUnityAdsSettings()", StaticAccessorType.Dot)]
		public unsafe static void SetGameId(RuntimePlatform platform, string gameId)
		{
			//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				ManagedSpanWrapper managedSpanWrapper = default(ManagedSpanWrapper);
				ManagedSpanWrapper managedSpanWrapper = default(ManagedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(gameId, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = MemoryExtensions.AsSpan(gameId);
					ReadOnlySpan<char> readOnlySpan;
					fixed (char* begin = readOnlySpan)
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, readOnlySpan.Length);
						SetGameId_Injected(platform, ref managedSpanWrapper);
						return;
					}
				}
				SetGameId_Injected(platform, ref managedSpanWrapper);
			}
			finally
			{
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetGameId_Injected(RuntimePlatform platform, out ManagedSpanWrapper ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetGameId_Injected(RuntimePlatform platform, ref ManagedSpanWrapper gameId);
	}
}
namespace UnityEngine.Connect
{
	[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
	internal class UnityConnectSettings : Object
	{
		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public static extern bool enabled
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public static extern bool testMode
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public unsafe static string eventUrl
		{
			get
			{
				ManagedSpanWrapper ret = default(ManagedSpanWrapper);
				string stringAndDispose;
				try
				{
					get_eventUrl_Injected(out ret);
				}
				finally
				{
					stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
				}
				return stringAndDispose;
			}
			set
			{
				//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
				try
				{
					ManagedSpanWrapper managedSpanWrapper = default(ManagedSpanWrapper);
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
					{
						ReadOnlySpan<char> readOnlySpan = MemoryExtensions.AsSpan(value);
						fixed (char* begin = readOnlySpan)
						{
							managedSpanWrapper = new ManagedSpanWrapper(begin, readOnlySpan.Length);
							set_eventUrl_Injected(ref managedSpanWrapper);
							return;
						}
					}
					set_eventUrl_Injected(ref managedSpanWrapper);
				}
				finally
				{
				}
			}
		}

		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public unsafe static string eventOldUrl
		{
			get
			{
				ManagedSpanWrapper ret = default(ManagedSpanWrapper);
				string stringAndDispose;
				try
				{
					get_eventOldUrl_Injected(out ret);
				}
				finally
				{
					stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
				}
				return stringAndDispose;
			}
			set
			{
				//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
				try
				{
					ManagedSpanWrapper managedSpanWrapper = default(ManagedSpanWrapper);
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
					{
						ReadOnlySpan<char> readOnlySpan = MemoryExtensions.AsSpan(value);
						fixed (char* begin = readOnlySpan)
						{
							managedSpanWrapper = new ManagedSpanWrapper(begin, readOnlySpan.Length);
							set_eventOldUrl_Injected(ref managedSpanWrapper);
							return;
						}
					}
					set_eventOldUrl_Injected(ref managedSpanWrapper);
				}
				finally
				{
				}
			}
		}

		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public unsafe static string configUrl
		{
			get
			{
				ManagedSpanWrapper ret = default(ManagedSpanWrapper);
				string stringAndDispose;
				try
				{
					get_configUrl_Injected(out ret);
				}
				finally
				{
					stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
				}
				return stringAndDispose;
			}
			set
			{
				//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
				try
				{
					ManagedSpanWrapper managedSpanWrapper = default(ManagedSpanWrapper);
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
					{
						ReadOnlySpan<char> readOnlySpan = MemoryExtensions.AsSpan(value);
						fixed (char* begin = readOnlySpan)
						{
							managedSpanWrapper = new ManagedSpanWrapper(begin, readOnlySpan.Length);
							set_configUrl_Injected(ref managedSpanWrapper);
							return;
						}
					}
					set_configUrl_Injected(ref managedSpanWrapper);
				}
				finally
				{
				}
			}
		}

		[StaticAccessor("GetUnityConnectSettings()", StaticAccessorType.Dot)]
		public static extern int testInitMode
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_eventUrl_Injected(out ManagedSpanWrapper ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_eventUrl_Injected(ref ManagedSpanWrapper value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_eventOldUrl_Injected(out ManagedSpanWrapper ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_eventOldUrl_Injected(ref ManagedSpanWrapper value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_configUrl_Injected(out ManagedSpanWrapper ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_configUrl_Injected(ref ManagedSpanWrapper value);
	}
}
