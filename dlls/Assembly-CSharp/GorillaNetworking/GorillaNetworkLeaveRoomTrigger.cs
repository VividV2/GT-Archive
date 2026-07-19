using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GorillaTagScripts;
using UnityEngine;

namespace GorillaNetworking
{
	public class GorillaNetworkLeaveRoomTrigger : GorillaTriggerBox
	{
		[SerializeField]
		private bool excludePrivateRooms;

		public override void OnBoxTriggered()
		{
			base.OnBoxTriggered();
			if (NetworkSystem.Instance.InRoom && (!excludePrivateRooms || !NetworkSystem.Instance.SessionIsPrivate))
			{
				if (FriendshipGroupDetection.Instance.IsInParty)
				{
					FriendshipGroupDetection.Instance.LeaveParty();
					DisconnectAfterDelay(1f);
				}
				else
				{
					NetworkSystem.Instance.ReturnToSinglePlayer();
				}
			}
		}

		private async void DisconnectAfterDelay(float seconds)
		{
			float num = default(float);
			TaskAwaiter taskAwaiter = Task.Delay((int)(1000f * num)).GetAwaiter();
			TaskAwaiter taskAwaiter2 = default(TaskAwaiter);
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				taskAwaiter = taskAwaiter2;
				taskAwaiter2 = default(TaskAwaiter);
			}
			taskAwaiter.GetResult();
			taskAwaiter = NetworkSystem.Instance.ReturnToSinglePlayer().GetAwaiter();
			if (!taskAwaiter.IsCompleted)
			{
				await taskAwaiter;
				taskAwaiter = taskAwaiter2;
			}
			taskAwaiter.GetResult();
		}
	}
}
namespace GorillaTagScripts
{
}
