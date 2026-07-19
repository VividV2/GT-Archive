using System;

namespace Cysharp.Threading.Tasks.CompilerServices
{
	internal interface IStateMachineRunner
	{
		Action MoveNext { get; }

		void Return();
	}
}
namespace Cysharp.Threading.Tasks.Internal
{
}
