using System;
using Liv.NGFX;

namespace Liv.Lck
{
	public enum LckError
	{
		ServiceNotCreated = 1,
		ServiceDisposed,
		InvalidDescriptor,
		CameraIdNotFound,
		MonitorIdNotFound,
		MicrophonePermissionDenied,
		CaptureAlreadyStarted,
		NotCurrentlyRecording,
		NotPaused,
		RecordingError,
		PhotoCaptureError,
		CantEditSettingsWhileCapturing,
		NotEnoughStorageSpace,
		FailedToCopyRecordingToGallery,
		FailedToCopyPhotoToGallery,
		UnsupportedGraphicsApi,
		UnsupportedPlatform,
		MicrophoneError,
		StreamerNotImplemented,
		StreamingError,
		EncodingError,
		EchoError,
		UnknownError
	}
}
namespace Liv.Lck.Streaming
{
	internal interface ILckStreamer : ILckCaptureStateProvider, IDisposable
	{
		bool IsStreaming { get; }

		LckResult StartStreaming();

		LckResult StopStreaming(LckService.StopReason stopReason);

		LckResult<TimeSpan> GetStreamDuration();

		void SetLogLevel(Liv.NGFX.LogLevel logLevel);
	}
}
