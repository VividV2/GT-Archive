using System;
using System;
using UnityEngine;

internal class OVRSampledEventSender(int markerId, float recordRecordChance, Func<OVRTelemetryMarker, OVRTelemetryMarker> addAnnotationsFunc = null)
{
	private OVRTelemetryMarker _marker;

	private bool _shouldSend;

	private readonly float _recordChance = recordRecordChance;

	private readonly int _markerId = markerId;

	private readonly Func<OVRTelemetryMarker, OVRTelemetryMarker> _addAnnotationsFunc = addAnnotationsFunc;

	public void Send()
	{
		if (_shouldSend)
		{
			_marker.Send();
			_shouldSend = false;
		}
	}

	public void Start()
	{
		if (ShouldSendEvent(_recordChance))
		{
			_marker = OVRTelemetry.Start(_markerId, 0, -1L);
			if (_addAnnotationsFunc != null)
			{
				_marker = _addAnnotationsFunc(_marker);
			}
			_shouldSend = true;
		}
	}

	private static bool ShouldSendEvent(float chance)
	{
		return UnityEngine.Random.value < chance;
	}
}
