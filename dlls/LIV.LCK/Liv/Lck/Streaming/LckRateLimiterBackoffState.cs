using System;
using System.Threading;
using System.Threading.Tasks;
using Liv.Lck.Core;
using Liv.Lck.Tablet;

namespace Liv.Lck.Streaming;

public class LckRateLimiterBackoffState : LckStreamingBaseState
{
	public override void EnterState(LckStreamingController controller)
	{
		controller.ShowNotification(NotificationType.RateLimiterBackoff);
		WaitForRateLimiter(controller, controller.CancellationTokenSource.Token);
	}

	private async Task WaitForRateLimiter(LckStreamingController controller, CancellationToken cancellationToken)
	{
		CancellationToken cancellationToken2 = default(CancellationToken);
		if (!cancellationToken2.IsCancellationRequested)
		{
			LckStreamingController lckStreamingController = default(LckStreamingController);
			Result<float> result = await lckStreamingController.LckCore.GetRemainingBackoffTimeSeconds();
			int num = 10000;
			if (result.IsOk)
			{
				num = (int)Math.Truncate(result.Ok) * 1000;
				lckStreamingController.Log("Got remaining backoff time in milliseconds: " + num);
			}
			else
			{
				lckStreamingController.Log("Unable to get remaining backoff time, waiting 10 seconds instead");
			}
			if (num < 1000)
			{
				lckStreamingController.Log("delay was: " + num + " increasing to 3 seconds to avoid looping");
				num = 3000;
			}
			await Task.Delay(num, cancellationToken2);
			lckStreamingController.SwitchState(lckStreamingController.GetCurrentState);
		}
	}
}
