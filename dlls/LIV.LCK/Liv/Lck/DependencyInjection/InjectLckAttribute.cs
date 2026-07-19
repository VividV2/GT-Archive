using System;
using UnityEngine;

namespace Liv.Lck
{
}
namespace Liv.Lck.DependencyInjection
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InjectLckAttribute : PropertyAttribute
	{
	}
}
