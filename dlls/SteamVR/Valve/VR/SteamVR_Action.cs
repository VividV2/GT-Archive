using System;

namespace Valve.VR;

[Serializable]
public abstract class SteamVR_Action<SourceMap, SourceElement> : SteamVR_Action, ISteamVR_Action, ISteamVR_Action_Source where SourceMap : SteamVR_Action_Source_Map<SourceElement>, new() where SourceElement : SteamVR_Action_Source, new()
{
	[NonSerialized]
	protected SourceMap sourceMap;

	[NonSerialized]
	protected bool initialized;

	public virtual SourceElement this[SteamVR_Input_Sources inputSource] => sourceMap[inputSource];

	public override string fullPath => sourceMap.fullPath;

	public override ulong handle => sourceMap.handle;

	public override SteamVR_ActionSet actionSet => sourceMap.actionSet;

	public override SteamVR_ActionDirections direction => sourceMap.direction;

	public override bool active => sourceMap[SteamVR_Input_Sources.Any].active;

	public override bool lastActive => sourceMap[SteamVR_Input_Sources.Any].lastActive;

	public override bool activeBinding => sourceMap[SteamVR_Input_Sources.Any].activeBinding;

	public override bool lastActiveBinding => sourceMap[SteamVR_Input_Sources.Any].lastActiveBinding;

	public override void PreInitialize(string newActionPath)
	{
		actionPath = newActionPath;
		sourceMap = new SourceMap();
		sourceMap.PreInitialize(this, actionPath);
		initialized = true;
	}

	protected override void CreateUninitialized(string newActionPath, bool caseSensitive)
	{
		actionPath = newActionPath;
		sourceMap = new SourceMap();
		sourceMap.PreInitialize(this, actionPath, throwErrors: false);
		needsReinit = true;
		initialized = false;
	}

	protected override void CreateUninitialized(string newActionSet, SteamVR_ActionDirections direction, string newAction, bool caseSensitive)
	{
		actionPath = SteamVR_Input_ActionFile_Action.CreateNewName(newActionSet, direction, newAction);
		sourceMap = new SourceMap();
		sourceMap.PreInitialize(this, actionPath, throwErrors: false);
		needsReinit = true;
		initialized = false;
	}

	public override string TryNeedsInitData()
	{
		if (needsReinit && actionPath != null)
		{
			SteamVR_Action steamVR_Action = SteamVR_Action.FindExistingActionForPartialPath(actionPath);
			if (!(steamVR_Action == null))
			{
				actionPath = steamVR_Action.fullPath;
				sourceMap = (SourceMap)steamVR_Action.GetSourceMap();
				initialized = true;
				needsReinit = false;
				return actionPath;
			}
			sourceMap = null;
		}
		return null;
	}

	public override void Initialize(bool createNew = false, bool throwErrors = true)
	{
		if (needsReinit)
		{
			TryNeedsInitData();
		}
		if (createNew)
		{
			sourceMap.Initialize();
		}
		else
		{
			sourceMap = SteamVR_Input.GetActionDataFromPath<SourceMap>(actionPath);
			_ = sourceMap;
		}
		initialized = true;
	}

	public override SteamVR_Action_Source_Map GetSourceMap()
	{
		return sourceMap;
	}

	protected override void InitializeCopy(string newActionPath, SteamVR_Action_Source_Map newData)
	{
		actionPath = newActionPath;
		sourceMap = (SourceMap)newData;
		initialized = true;
	}

	protected void InitAfterDeserialize()
	{
		if (sourceMap != null)
		{
			if (sourceMap.fullPath != actionPath)
			{
				needsReinit = true;
				TryNeedsInitData();
			}
			if (string.IsNullOrEmpty(actionPath))
			{
				sourceMap = null;
			}
		}
		if (!initialized)
		{
			Initialize(false, false);
		}
	}

	public override bool GetActive(SteamVR_Input_Sources inputSource)
	{
		return sourceMap[inputSource].active;
	}

	public override bool GetActiveBinding(SteamVR_Input_Sources inputSource)
	{
		return sourceMap[inputSource].activeBinding;
	}

	public override bool GetLastActive(SteamVR_Input_Sources inputSource)
	{
		return sourceMap[inputSource].lastActive;
	}

	public override bool GetLastActiveBinding(SteamVR_Input_Sources inputSource)
	{
		return sourceMap[inputSource].lastActiveBinding;
	}
}
