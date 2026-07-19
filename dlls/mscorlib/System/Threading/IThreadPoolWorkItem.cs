using System.Security;

namespace System.Threading
{
}
namespace System.Threading
{
	internal interface IThreadPoolWorkItem
	{
		[SecurityCritical]
		void ExecuteWorkItem();

		[SecurityCritical]
		void MarkAborted(ThreadAbortException tae);
	}
}
