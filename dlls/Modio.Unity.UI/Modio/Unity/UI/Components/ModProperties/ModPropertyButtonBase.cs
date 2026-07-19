using System;
using UnityEngine;
using System;
using UnityEngine;

namespace Modio.Unity.UI;

[AttributeUsage(AttributeTargets.Field)]
public class ShowIfAttribute : PropertyAttribute
{
	public ShowIfAttribute(string predicateName)
	{
	}
}
