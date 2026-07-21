using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class TreatmentAssignment : PlayFabBaseModel
	{
		public List<Variable> Variables;

		public List<string> Variants;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class StoreItem : PlayFabBaseModel
	{
		public object CustomData;

		public uint? DisplayPosition;

		public string ItemId;

		public Dictionary<string, uint> RealCurrencyPrices;

		public Dictionary<string, uint> VirtualCurrencyPrices;
	}
}
