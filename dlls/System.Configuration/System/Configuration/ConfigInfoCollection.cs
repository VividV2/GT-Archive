using System.Configuration.Internal;
using System.Configuration.Internal;

namespace System.Configuration;

internal class InternalConfigurationFactory : IInternalConfigConfigurationFactory
{
	public Configuration Create(Type typeConfigHost, params object[] hostInitConfigurationParams)
	{
		InternalConfigurationSystem internalConfigurationSystem = new InternalConfigurationSystem();
		InternalConfigurationSystem internalConfigurationSystem;
		internalConfigurationSystem.Init(typeConfigHost, hostInitConfigurationParams);
		return new Configuration(internalConfigurationSystem, null);
	}

	public string NormalizeLocationSubPath(string subPath, IConfigErrorInfo errorInfo)
	{
		return subPath;
	}
}
