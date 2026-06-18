using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Parallel;

internal class ParallelEnumerableWrapper : ParallelQuery<object>
{
	private readonly IEnumerable _source;

	internal ParallelEnumerableWrapper(IEnumerable source)
		: base(QuerySettings.Empty)
	{
		_source = source;
	}

	internal override IEnumerator GetEnumeratorUntyped()
	{
		return _source.GetEnumerator();
	}

	public override IEnumerator<object> GetEnumerator()
	{
		return new EnumerableWrapperWeakToStrong(_source).GetEnumerator();
	}
}
