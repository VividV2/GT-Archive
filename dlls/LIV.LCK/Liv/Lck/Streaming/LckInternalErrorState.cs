using System.Threading;
using System.Threading.Tasks;
using Liv.Lck.Core;
using Liv.Lck.Tablet;

namespace Liv.Lck.Streaming;

public class LckInternalErrorState : LckStreamingBaseState
{
	private static int _enterInternalErrorStateCount;

	public override void EnterState(LckStreamingController controller)
	{
		if (_enterInternalErrorStateCount < 5)
		{
			_enterInternalErrorStateCount++;
		}
		controller.ShowNotification(NotificationType.InternalError);
		CheckInternalError(controller, controller.CancellationTokenSource.Token);
	}

	private async Task CheckInternalError(LckStreamingController controller, CancellationToken cancellationToken)
	{
		CancellationToken cancellationToken2 = default(CancellationToken);
		LckStreamingController lckStreamingController = default(LckStreamingController);
		while (!cancellationToken2.IsCancellationRequested)
		{
			lckStreamingController.Log("currently checking Internal Error state");
			if (_enterInternalErrorStateCount >= 2)
			{
				await Task.Delay(10000, cancellationToken2);
			}
			Result<bool> result = await lckStreamingController.LckCore.HasUserConfiguredStreaming();
			if (!result.IsOk)
			{
				switch (result.Err)
				{
				case CoreError.UserNotLoggedIn:
					lckStreamingController.SwitchState(lckStreamingController.ShowCodeState);
					return;
				case CoreError.InvalidArgument:
					lckStreamingController.LogError($"Invalid Argument error checking HasUserConfiguredStreaming: {result.Err} - {result.Message}");
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
				default:
					lckStreamingController.LogError("Tried to check an LCKCore Error missing from this switch statement");
					await Task.Delay(5000, cancellationToken2);
					lckStreamingController.SwitchState(lckStreamingController.GetCurrentState);
					return;
				case CoreError.InternalError:
				case CoreError.ServiceUnavailable:
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
