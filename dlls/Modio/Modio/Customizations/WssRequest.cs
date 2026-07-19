using System;
using Newtonsoft.Json.Linq;
using System;
using Newtonsoft.Json.Linq;

namespace Modio.Customizations
{
	internal static class WssRequest
	{
		public static WssMessage DeviceLogin()
		{
			return new WssMessage
			{
				operation = "device_login",
				context = JToken.FromObject(default(WssDeviceLoginRequest))
			};
		}
	}
}
namespace Modio.Customizations
{
	[Serializable]
	internal struct WssMessage
	{
		public string operation;

		public JToken context;

		public bool TryGetValue<TOutput>(out TOutput output) where TOutput : struct
		{
			JToken jToken = context;
			JToken jToken;
			if (jToken != null)
			{
				output = jToken.ToObject<TOutput>();
				return true;
			}
			output = default(TOutput);
			return false;
		}
	}
}
