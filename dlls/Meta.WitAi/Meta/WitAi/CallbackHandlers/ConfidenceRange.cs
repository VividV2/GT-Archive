using System;
using UnityEngine.Events;

namespace Meta.WitAi.CallbackHandlers
{
	[Serializable]
	public class ConfidenceRange
	{
		public float minConfidence;

		public float maxConfidence;

		public UnityEvent onWithinConfidenceRange = new UnityEvent();

		public UnityEvent onOutsideConfidenceRange = new UnityEvent();
	}
}
namespace Meta.WitAi.Attributes
{
}
namespace Meta.WitAi.Data.Entities
{
}
namespace Meta.WitAi.Requests
{
}
namespace Meta.WitAi.Configuration
{
}
namespace Meta.Conduit
{
}
