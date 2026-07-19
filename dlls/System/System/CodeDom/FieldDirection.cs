using System.Runtime.InteropServices;

namespace System.Configuration
{
	[ComVisible(false)]
	public interface IConfigurationSystem
	{
		object GetConfig(string configKey);

		void Init();
	}
}
namespace System.Text.RegularExpressions
{
}
namespace System.Security.Permissions
{
}
