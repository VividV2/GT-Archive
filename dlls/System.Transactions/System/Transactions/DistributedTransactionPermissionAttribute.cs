using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Transactions
{
	/// <summary>Describes the current status of a distributed transaction.</summary>
	/// <summary>Describes the current status of a distributed transaction.</summary>
	public enum TransactionStatus
	{
		/// <summary>The status of the transaction is unknown, because some participants must still be polled.</summary>
		/// <summary>The status of the transaction is unknown, because some participants must still be polled.</summary>
		Active,
		/// <summary>The transaction has been committed.</summary>
		/// <summary>The transaction has been committed.</summary>
		Committed,
		/// <summary>The transaction has been rolled back.</summary>
		/// <summary>The transaction has been rolled back.</summary>
		Aborted,
		/// <summary>The status of the transaction is unknown.</summary>
		/// <summary>The status of the transaction is unknown.</summary>
		InDoubt
	}
}
namespace System.Transactions
{
	/// <summary>Allows security actions for <see cref="T:System.Transactions.DistributedTransactionPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class DistributedTransactionPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Transactions.DistributedTransactionPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</param>
		public DistributedTransactionPermissionAttribute(SecurityAction action)
		{
		}

		/// <summary>Creates a permission object that can then be serialized into binary form and persistently stored along with the <see cref="T:System.Security.Permissions.SecurityAction" /> in an assembly's metadata.</summary>
		/// <returns>A serializable permission object.</returns>
		public override IPermission CreatePermission()
		{
			Unity.ThrowStub.ThrowNotSupportedException();
			return null;
		}
	}
}
namespace System.Transactions.Configuration
{
}
