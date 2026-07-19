using UnityEngine;

namespace GorillaTagScripts;

public class BuilderPieceInteractorPreInteract : MonoBehaviour
{
	public BuilderPieceInteractor interactor;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
public enum GTShaderTransparencyMode
{
	Opaque,
	AlphaTest,
	Transparent,
	Premultiplied,
	Add,
	Multiply,
	DitherBlueLive
}
