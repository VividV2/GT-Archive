using UnityEngine;
using UnityEngine;

namespace Liv.Lck.Smoothing;

public class KalmanFilterVector3(Vector3 initialEstimate = default(Vector3), float initialCovariance = 1f)
{
	private KalmanFilter _filterX = new KalmanFilter(initialEstimate.x, initialCovariance);

	private KalmanFilter _filterY = new KalmanFilter(initialEstimate.y, initialCovariance);

	private KalmanFilter _filterZ = new KalmanFilter(initialEstimate.z, initialCovariance);

	public Vector3 Update(Vector3 measurement, float deltaTime, float smoothing)
	{
		return new Vector3(_filterX.Update(measurement.x, deltaTime, smoothing), _filterY.Update(measurement.y, deltaTime, smoothing), _filterZ.Update(measurement.z, deltaTime, smoothing));
	}
}
