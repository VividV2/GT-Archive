using System;
using UnityEngine.Scripting;
using System;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	[AttributeUsage(AttributeTargets.Field)]
	[RequiredByNativeCode]
	public sealed class NativeFixedLengthAttribute(int fixedLength) : Attribute
	{
		public int FixedLength = fixedLength;
	}
}
namespace UnityEngine
{
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine
{
	public interface IExposedPropertyTable
	{
		void SetReferenceValue(PropertyName id, Object value);

		Object GetReferenceValue(PropertyName id, out bool idValid);

		void ClearReferenceValue(PropertyName id);
	}
}
