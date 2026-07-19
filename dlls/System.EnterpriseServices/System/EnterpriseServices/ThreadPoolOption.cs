using System.Collections;
using System.Runtime.InteropServices;
using System.Collections;

namespace System.EnterpriseServices
{
	public sealed class SecurityCallers : IEnumerable
	{
		public int Count
		{
			[System.MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		public SecurityIdentity this[int idx]
		{
			[System.MonoTODO]
			get
			{
				throw new NotImplementedException();
			}
		}

		internal SecurityCallers()
		{
		}

		internal SecurityCallers(ISecurityCallersColl collection)
		{
		}

		[System.MonoTODO]
		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
namespace System.EnterpriseServices
{
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class EventClassAttribute : Attribute
	{
		private bool allowInProcSubscribers;

		private bool fireInParallel;

		private string publisherFilter;

		public bool AllowInprocSubscribers
		{
			get
			{
				return allowInProcSubscribers;
			}
			set
			{
				allowInProcSubscribers = value;
			}
		}

		public bool FireInParallel
		{
			get
			{
				return fireInParallel;
			}
			set
			{
				fireInParallel = value;
			}
		}

		public string PublisherFilter
		{
			get
			{
				return publisherFilter;
			}
			set
			{
				publisherFilter = value;
			}
		}

		public EventClassAttribute()
		{
			allowInProcSubscribers = true;
			fireInParallel = false;
			publisherFilter = null;
		}
	}
}
