using System.Threading;
using System.Threading.Tasks;
using Liv.Lck.Core;

namespace Liv.Lck.Streaming;

public class LckStreamingGetCurrentState : LckStreamingBaseState
{
	public override void EnterState(LckStreamingController controller)
	{
		GetCurrentState(controller, controller.CancellationTokenSource.Token);
	}

	private async Task GetCurrentState(LckStreamingController controller, CancellationToken cancellationToken)
	{
		LckStreamingController lckStreamingController = default(LckStreamingController);
		CancellationToken cancellationToken2 = default(CancellationToken);
		while (!cancellationToken2.IsCancellationRequested)
		{
			lckStreamingController.Log("currently waiting for get current state");
			Result<bool> result = await lckStreamingController.LckCore.HasUserConfiguredStreaming();
			if (!result.IsOk)
			{
				switch (result.Err)
				{
				case CoreError.UserNotLoggedIn:
					lckStreamingController.SwitchState(lckStreamingController.ShowCodeState);
					return;
				case CoreError.InternalError:
					lckStreamingController.LogError($"Internal error checking if user is Configured: {result.Err} - {result.Message}");
					lckStreamingController.SwitchState(lckStreamingController.InternalErrorState);
					return;
				case CoreError.InvalidArgument:
					lckStreamingController.LogError($"Invalid Argument error checking if user is Configured: {result.Err} - {result.Message}");
					lckStreamingController.SwitchState(lckStreamingController.InvalidArgumentState);
					return;
				case CoreError.MissingTrackingId:
					lckStreamingController.LogError($"MissingTrackingId error please make sure Tracking ID is setup correctly in LCK Settings: {result.Err} - {result.Message}");
					lckStreamingController.SwitchState(lckStreamingController.MissingTrackingIdState);
					return;
				case CoreError.RateLimiterBackoff:
					lckStreamingController.LogError($"Too many requests sent to our backend error: {result.Err} - {result.Message}");
					lckStreamingController.SwitchState(lckStreamingController.RateLimiterBackoffState);
					return;
				case CoreError.ServiceUnavailable:
					lckStreamingController.LogError($"Unable to reach our backend error: {result.Err} - {result.Message}");
					lckStreamingController.SwitchState(lckStreamingController.ServiceUnavailableState);
					return;
				default:
					lckStreamingController.LogError("Tried to check an LCKCore Error missing from this switch statement");
					await Task.Delay(5000, cancellationToken2);
					break;
				}
				continue;
			}
			if (result.Ok)
			{
				lckStreamingController.SwitchState(lckStreamingController.ConfiguredCorrectlyState);
			}
			else
			{
				lckStreamingController.SwitchState(lckStreamingController.WaitingForConfigureState);
			}
			break;
		}
	}
}
