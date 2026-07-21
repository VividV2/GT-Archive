namespace System.EnterpriseServices
{
	[System.Runtime.InteropServices.ComImport]
	[System.Runtime.InteropServices.Guid("0FB15084-AF41-11CE-BD2B-204C4F4F5020")]
	[System.Runtime.InteropServices.InterfaceType(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	public interface ITransaction
	{
		void Abort(ref BOID pboidReason, int fRetaining, int fAsync);

		void Commit(int fRetaining, int grfTC, int grfRM);

		void GetTransactionInfo(out XACTTRANSINFO pinfo);
	}
}
namespace System.EnterpriseServices
{
}
namespace System.EnterpriseServices
{
	internal interface ISecurityCallContext
	{
		int Count { get; }

		void GetEnumerator(ref IEnumerator enumerator);

		object GetItem(string user);

		bool IsCallerInRole(string role);

		bool IsSecurityEnabled();

		bool IsUserInRole(ref object user, string role);
	}
}
