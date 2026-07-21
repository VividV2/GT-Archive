namespace System.Security.Permissions
{
}
namespace System.Text.RegularExpressions
{
}
namespace System.ComponentModel
{
	public interface IChangeTracking
	{
		bool IsChanged { get; }

		void AcceptChanges();
	}
}
