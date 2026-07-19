using System.Collections.Generic;
using Valve.Newtonsoft.Json.Utilities;
using System.Collections.Generic;
using Valve.Newtonsoft.Json.Utilities;
using System.Collections.Generic;
using Valve.Newtonsoft.Json.Utilities;

namespace Valve.Newtonsoft.Json.Serialization;

internal class DefaultContractResolverState
{
	public Dictionary<ResolverContractKey, JsonContract> ContractCache;

	public PropertyNameTable NameTable = new PropertyNameTable();
}
namespace Valve.Newtonsoft.Json.Utilities
{
}
