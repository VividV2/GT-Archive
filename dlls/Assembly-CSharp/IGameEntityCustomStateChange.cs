using System;

public interface IGameEntityCustomStateChange
{
	bool CanChangeState(long newState, int playerId);
}
[Serializable]
public struct SAnnouncementData
{
	public string ShowAnnouncement;

	public string AnnouncementID;

	public string AnnouncementTitle;

	public string Message;
}
