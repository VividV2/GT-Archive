using System;
using GorillaNetworking.Store;
using GT_CustomMapSupportRuntime;

namespace LitJson
{
	internal delegate object ImporterFunc(object input);
}
namespace GorillaTagScripts.VirtualStumpCustomMaps
{
	[Serializable]
	public struct CustomMapCosmeticItem
	{
		public GTObjectPlaceholder.ECustomMapCosmeticItem customMapItemSlot;

		public HeadModel_CosmeticStand.BustType bustType;

		public string playFabID;
	}
}
namespace LitJson
{
}
