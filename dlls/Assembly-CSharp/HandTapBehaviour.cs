using UnityEngine;

namespace Fusion.CodeGen;

public abstract class HandTapBehaviour : MonoBehaviour
{
	internal abstract void OnTap(HandEffectContext handContext);
}
