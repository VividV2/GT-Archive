using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;
using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	public interface IResourceLocator
	{
		string LocatorId { get; }

		IEnumerable<object> Keys { get; }

		IEnumerable<IResourceLocation> AllLocations { get; }

		bool Locate(object key, Type type, out IList<IResourceLocation> locations);
	}
}
namespace UnityEngine.AddressableAssets
{
	public enum AddressablesPlatform
	{
		Unknown,
		Windows,
		OSX,
		Linux,
		PS4,
		Switch,
		XboxOne,
		WebGL,
		iOS,
		Android,
		WindowsUniversal
	}
}
