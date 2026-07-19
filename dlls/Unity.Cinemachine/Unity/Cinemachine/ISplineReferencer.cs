using System;
using System;

namespace Unity.Cinemachine;

public interface IInputAxisResetSource
{
	bool HasResetHandler { get; }

	void RegisterResetHandler(Action handler);

	void UnregisterResetHandler(Action handler);
}
namespace Unity.Cinemachine
{
	public interface ISplineReferencer
	{
		ref SplineSettings SplineSettings { get; }
	}
}
namespace Unity.Cinemachine
{
}
