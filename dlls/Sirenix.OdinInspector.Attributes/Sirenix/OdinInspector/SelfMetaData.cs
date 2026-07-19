using System;
using System.Collections.Generic;
using System;
using System;

namespace Sirenix.OdinInspector
{
	public class SelfMetaData : List<SelfValidationResult.ResultItemMetaData>
	{
		public void Add(string key, object value)
		{
			Add(new SelfValidationResult.ResultItemMetaData(key, value));
		}
	}
}
namespace Sirenix.OdinInspector
{
	[Flags]
	public enum SearchFilterOptions
	{
		PropertyName = 1,
		PropertyNiceName = 2,
		TypeOfValue = 4,
		ValueToString = 8,
		ISearchFilterableInterface = 0x10,
		All = -1
	}
}
namespace Sirenix.OdinInspector
{
	public enum TabLayouting
	{
		MultiRow,
		Shrink
	}
}
namespace Sirenix.OdinInspector
{
}
