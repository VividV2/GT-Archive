using System.Diagnostics;
using System.Security.Permissions;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics.Eventing.Reader
{
	/// <summary>When the <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> event is raised, an instance of this object is passed to the delegate method that handles the event. This object contains the event that was published to the event log or the exception that occurred when the event subscription failed. </summary>
	/// <summary>When the <see cref="E:System.Diagnostics.Eventing.Reader.EventLogWatcher.EventRecordWritten" /> event is raised, an instance of this object is passed to the delegate method that handles the event. This object contains the event that was published to the event log or the exception that occurred when the event subscription failed. </summary>
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class EventRecordWrittenEventArgs : EventArgs
	{
		/// <summary>Gets the exception that occurred when the event subscription failed. The exception has a description of why the subscription failed.</summary>
		/// <returns>Returns an <see cref="T:System.Exception" /> object.</returns>
		/// <summary>Gets the exception that occurred when the event subscription failed. The exception has a description of why the subscription failed.</summary>
		/// <returns>Returns an <see cref="T:System.Exception" /> object.</returns>
		public Exception EventException
		{
			get
			{
				Unity.ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		/// <summary>Gets the event record that is published to the event log. This event matches the criteria from the query specified in the event subscription.</summary>
		/// <returns>Returns a <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> object.</returns>
		/// <summary>Gets the event record that is published to the event log. This event matches the criteria from the query specified in the event subscription.</summary>
		/// <returns>Returns a <see cref="T:System.Diagnostics.Eventing.Reader.EventRecord" /> object.</returns>
		public EventRecord EventRecord
		{
			get
			{
				Unity.ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		internal EventRecordWrittenEventArgs()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
		}
	}
}
namespace System.Collections.Generic
{
	internal sealed class ICollectionDebugView<T>
	{
		private readonly ICollection<T> _collection;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				T[] array = new T[_collection.Count];
				_collection.CopyTo(array, 0);
				return array;
			}
		}

		public ICollectionDebugView(ICollection<T> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			_collection = collection;
		}
	}
}
