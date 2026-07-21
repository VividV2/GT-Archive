namespace System.Runtime.CompilerServices
{
}
namespace System.Threading
{
	internal interface IDeferredDisposable
	{
		void OnFinalRelease(bool disposed);
	}
}
