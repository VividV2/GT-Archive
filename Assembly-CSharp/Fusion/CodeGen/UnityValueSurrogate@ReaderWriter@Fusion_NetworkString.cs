using System;
using Fusion.Internal;

namespace Fusion.CodeGen;

[Serializable]
[WeaverGenerated]
internal class UnityValueSurrogate@ReaderWriter@Fusion_NetworkString`1<Fusion__32> : UnityValueSurrogate<NetworkString<_32>, ReaderWriter@Fusion_NetworkString`1<Fusion__32>>
{
	[WeaverGenerated]
	public NetworkString<_32> Data;

	[WeaverGenerated]
	public override NetworkString<_32> DataProperty
	{
		[WeaverGenerated]
		get
		{
			return Data;
		}
		[WeaverGenerated]
		set
		{
			Data = value;
		}
	}

	[WeaverGenerated]
	public UnityValueSurrogate@ReaderWriter@Fusion_NetworkString`1<Fusion__32>()
	{
	}
}
