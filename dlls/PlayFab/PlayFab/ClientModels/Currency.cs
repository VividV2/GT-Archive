using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels;

[Serializable]
public class GetCatalogItemsRequest : PlayFabRequestCommon
{
	public string CatalogVersion;
}
