using System;
using UnityEngine;
using UnityEngine;

namespace Oculus.Interaction;

public interface IPointableCanvas : IPointableElement, IPointable
{
	Canvas Canvas { get; }
}
namespace Oculus.Interaction
{
	public interface MAction<out T>
	{
		event Action<T> Action;
	}
}
