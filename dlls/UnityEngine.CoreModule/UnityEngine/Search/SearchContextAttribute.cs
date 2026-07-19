using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;

namespace UnityEngine.Analytics
{
	[Flags]
	public enum SendEventOptions
	{
		kAppendNone = 0,
		kAppendBuildGuid = 1,
		kAppendBuildTarget = 2
	}
}
namespace UnityEngine.Search
{
	[AttributeUsage(AttributeTargets.Field)]
	public class SearchContextAttribute : PropertyAttribute
	{
		public string query { get; private set; }

		public string[] providerIds { get; private set; }

		public Type[] instantiableProviders { get; private set; }

		public SearchViewFlags flags { get; private set; }

		public SearchContextAttribute(string query)
			: this(query, null, SearchViewFlags.None)
		{
		}

		public SearchContextAttribute(string query, SearchViewFlags flags)
			: this(query, null, flags)
		{
		}

		public SearchContextAttribute(string query, string providerIdsCommaSeparated)
			: this(query, providerIdsCommaSeparated, SearchViewFlags.None)
		{
		}

		public SearchContextAttribute(string query, string providerIdsCommaSeparated, SearchViewFlags flags)
			: this(query, flags, providerIdsCommaSeparated, (Type[])null)
		{
		}

		public SearchContextAttribute(string query, params Type[] instantiableProviders)
			: this(query, SearchViewFlags.None, null, instantiableProviders)
		{
		}

		public SearchContextAttribute(string query, SearchViewFlags flags, params Type[] instantiableProviders)
			: this(query, flags, null, instantiableProviders)
		{
		}

		public SearchContextAttribute(string query, SearchViewFlags flags, string providerIdsCommaSeparated, params Type[] instantiableProviders)
		{
			this.query = query;
			providerIds = providerIdsCommaSeparated?.Split(',', ';') ?? new string[0];
			this.instantiableProviders = instantiableProviders ?? new Type[0];
			this.flags = flags | SearchViewFlags.ObjectPicker;
		}
	}
}
namespace UnityEngine.Rendering
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[Obsolete("GPUFence has been deprecated. Use GraphicsFence instead (UnityUpgradable) -> GraphicsFence", false)]
	public struct GPUFence
	{
		public bool passed => true;
	}
}
