using System;
using Meta.WitAi.Interfaces;
using UnityEngine;
using System;
using UnityEngine;

namespace Meta.WitAi.Data.Entities
{
	public class WitDynamicEntitiesData : ScriptableObject, IDynamicEntitiesProvider
	{
		public WitDynamicEntities entities;

		public WitDynamicEntities GetDynamicEntities()
		{
			return entities;
		}
	}
}
namespace Meta.WitAi.Attributes
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class HideWhenSetAttribute : PropertyAttribute
	{
	}
}
