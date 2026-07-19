using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[CompilerGenerated]
[Microsoft.CodeAnalysis.Embedded]
internal sealed class IsUnmanagedAttribute : Attribute
{
}
namespace UnityEngine.Animations.Rigging
{
	public interface IAnimatableProperty<T>
	{
		T Get(AnimationStream stream);

		void Set(AnimationStream stream, T value);
	}
}
