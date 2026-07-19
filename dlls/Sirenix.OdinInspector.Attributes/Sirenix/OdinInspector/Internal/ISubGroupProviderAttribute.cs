using System.Collections.Generic;

namespace Sirenix.OdinInspector
{
}
namespace Sirenix.OdinInspector.Internal
{
	public interface ISubGroupProviderAttribute
	{
		IList<PropertyGroupAttribute> GetSubGroupAttributes();

		string RepathMemberAttribute(PropertyGroupAttribute attr);
	}
}
