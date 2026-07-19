using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Runtime
{
	internal class SignalGate<T> : SignalGate
	{
		private T result;

		public bool Signal(T result)
		{
			this.result = result;
			return Signal();
		}

		public bool Unlock(out T result)
		{
			if (Unlock())
			{
				result = this.result;
				return true;
			}
			result = default(T);
			return false;
		}
	}
}
namespace System.Runtime
{
	internal class ReadOnlyKeyedCollection<TKey, TValue> : ReadOnlyCollection<TValue>
	{
		private KeyedCollection<TKey, TValue> innerCollection;

		public TValue this[TKey key] => innerCollection[key];

		public ReadOnlyKeyedCollection(KeyedCollection<TKey, TValue> innerCollection)
			: base((IList<TValue>)innerCollection)
		{
			this.innerCollection = innerCollection;
		}
	}
}
