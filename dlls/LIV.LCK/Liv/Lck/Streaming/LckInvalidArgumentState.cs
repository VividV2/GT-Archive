using System.Threading;
using System.Threading.Tasks;
using Liv.Lck.Tablet;

namespace Liv.Lck.Streaming;

public class LckInvalidArgumentState : LckStreamingBaseState
{
	public override void EnterState(LckStreamingController controller)
	{
		controller.ShowNotification(NotificationType.InvalidArgument);
		SwitchStateAfterDelay(controller, controller.CancellationTokenSource.Token);
	}

	private async Task SwitchStateAfterDelay(LckStreamingController controller, CancellationToken cancellationToken)
	{
		CancellationToken cancellationToken2 = default(CancellationToken);
		LckStreamingController lckStreamingController = default(LckStreamingController);
		while (!cancellationToken2.IsCancellationRequested)
		{
			await Task.Delay(7000, cancellationToken2);
			lckStreamingController.SwitchState(lckStreamingController.GetCurrentState);
		}
	}
}
