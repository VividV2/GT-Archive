namespace Valve.VR;

public abstract class SteamVR_Action_Source_Map<SourceElement> : SteamVR_Action_Source_Map where SourceElement : SteamVR_Action_Source, new()
{
	protected SourceElement[] sources = new SourceElement[SteamVR_Input_Source.numSources];

	public SourceElement this[SteamVR_Input_Sources inputSource] => GetSourceElementForIndexer(inputSource);

	protected virtual void OnAccessSource(SteamVR_Input_Sources inputSource)
	{
	}

	public override void Initialize()
	{
		base.Initialize();
		for (int i = 0; i < sources.Length; i++)
		{
			if (sources[i] != null)
			{
				sources[i].Initialize();
			}
		}
	}

	protected override void PreinitializeMap(SteamVR_Input_Sources inputSource, SteamVR_Action wrappingAction)
	{
		sources[(int)inputSource] = new SourceElement();
		sources[(int)inputSource].Preinitialize(wrappingAction, inputSource);
	}

	protected virtual SourceElement GetSourceElementForIndexer(SteamVR_Input_Sources inputSource)
	{
		OnAccessSource(inputSource);
		return sources[(int)inputSource];
	}
}
