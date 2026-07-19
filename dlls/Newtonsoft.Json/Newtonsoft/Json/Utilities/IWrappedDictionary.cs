using System;
using System.Collections;
using System;
using System.Collections;

namespace Newtonsoft.Json.Serialization
{
	public interface IContractResolver
	{
		JsonContract ResolveContract(Type type);
	}
}
namespace Newtonsoft.Json.Utilities
{
	internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable
	{
		object UnderlyingDictionary { get; }
	}
}
namespace Newtonsoft.Json.Serialization
{
}
namespace Newtonsoft.Json.Utilities
{
}
