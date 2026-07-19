using System;
using UnityEngine;
using System;
using UnityEngine;
using System;
using UnityEngine;

public enum GTShaderStencilOp
{
	Keep,
	Zero,
	Replace,
	IncrSat,
	DecrSat,
	Invert,
	IncrWrap,
	DecrWrap
}
namespace GorillaNetworking.Store;

[Serializable]
public class DayCycleTextureMoment
{
	public Texture2D sunnyTex;

	public Texture2D cloudyTex;
}
