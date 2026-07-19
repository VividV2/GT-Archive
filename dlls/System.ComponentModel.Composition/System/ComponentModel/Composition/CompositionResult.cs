using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using Microsoft.Internal.Collections;

namespace System.ComponentModel.Composition;

internal struct CompositionResult
{
	public static readonly CompositionResult SucceededResult;

	private readonly IEnumerable<CompositionError> _errors;

	public bool Succeeded
	{
		get
		{
			if (_errors != null)
			{
				return !_errors.FastAny();
			}
			return true;
		}
	}

	public IEnumerable<CompositionError> Errors => _errors ?? Enumerable.Empty<CompositionError>();

	public CompositionResult(params CompositionError[] errors)
		: this((IEnumerable<CompositionError>)errors)
	{
	}

	public CompositionResult(IEnumerable<CompositionError> errors)
	{
		_errors = errors;
	}

	public CompositionResult MergeResult(CompositionResult result)
	{
		if (Succeeded)
		{
			return result;
		}
		if (result.Succeeded)
		{
			return this;
		}
		return MergeErrors(result._errors);
	}

	public CompositionResult MergeError(CompositionError error)
	{
		return MergeErrors(new CompositionError[1] { error });
	}

	public CompositionResult MergeErrors(IEnumerable<CompositionError> errors)
	{
		return new CompositionResult(_errors.ConcatAllowingNull(errors));
	}

	public CompositionResult<T> ToResult<T>(T value)
	{
		return new CompositionResult<T>(value, _errors);
	}

	public void ThrowOnErrors()
	{
		ThrowOnErrors(null);
	}

	public void ThrowOnErrors(AtomicComposition atomicComposition)
	{
		if (!Succeeded)
		{
			if (atomicComposition == null)
			{
				throw new CompositionException(_errors);
			}
			throw new ChangeRejectedException(_errors);
		}
	}
}
