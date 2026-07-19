using System.Configuration;
using System.Security;
using System.Security.Permissions;
using System.Security;
using System.Security.Permissions;
using Unity;

namespace System.Transactions
{
	/// <summary>Describes the current status of a distributed transaction.</summary>
	/// <summary>Describes the current status of a distributed transaction.</summary>
	/// <summary>Describes the current status of a distributed transaction.</summary>
	public enum TransactionStatus
	{
		/// <summary>The status of the transaction is unknown, because some participants must still be polled.</summary>
		/// <summary>The status of the transaction is unknown, because some participants must still be polled.</summary>
		/// <summary>The status of the transaction is unknown, because some participants must still be polled.</summary>
		Active,
		/// <summary>The transaction has been committed.</summary>
		/// <summary>The transaction has been committed.</summary>
		/// <summary>The transaction has been committed.</summary>
		Committed,
		/// <summary>The transaction has been rolled back.</summary>
		/// <summary>The transaction has been rolled back.</summary>
		/// <summary>The transaction has been rolled back.</summary>
		Aborted,
		/// <summary>The status of the transaction is unknown.</summary>
		/// <summary>The status of the transaction is unknown.</summary>
		/// <summary>The status of the transaction is unknown.</summary>
		InDoubt
	}
}
namespace System.Transactions
{
	/// <summary>Allows security actions for <see cref="T:System.Transactions.DistributedTransactionPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
	/// <summary>Allows security actions for <see cref="T:System.Transactions.DistributedTransactionPermission" /> to be applied to code using declarative security. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public sealed class DistributedTransactionPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Transactions.DistributedTransactionPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</param>
		/// <summary>Initializes a new instance of the <see cref="T:System.Transactions.DistributedTransactionPermissionAttribute" /> class with the specified <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">One of the <see cref="T:System.Security.Permissions.SecurityAction" /> values.</param>
		public DistributedTransactionPermissionAttribute(SecurityAction action)
		{
		}

		/// <summary>Creates a permission object that can then be serialized into binary form and persistently stored along with the <see cref="T:System.Security.Permissions.SecurityAction" /> in an assembly's metadata.</summary>
		/// <returns>A serializable permission object.</returns>
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
	/// <summary>Represents an XML section in a configuration file that contains default values of a transaction. This class cannot be inherited.</summary>
	public class DefaultSettingsSection : ConfigurationSection
	{
		/// <summary>Gets or sets a default time after which a transaction times out.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> object. The default property is 00:01:00.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">An attempt to set this property to negative values.</exception>
		[TimeSpanValidator(MinValueString = "00:00:00", MaxValueString = "10675199.02:48:05.4775807")]
		[ConfigurationProperty("timeout", DefaultValue = "00:01:00")]
		public TimeSpan Timeout
		{
			get
			{
				return (TimeSpan)base["timeout"];
			}
			set
			{
				base["timeout"] = value;
			}
		}

		/// <summary>Gets the name of the transaction manager.</summary>
		/// <returns>The name of the transaction manager. The default value is an empty string.</returns>
		/// <exception cref="T:System.NotSupportedException">An attempt to set this property to fully qualified domain names or IP addresses.</exception>
		/// <exception cref="T:System.Transactions.TransactionAbortedException">An attempt to set this property to localhost.</exception>
		[ConfigurationProperty("distributedTransactionManagerName", DefaultValue = "")]
		public string DistributedTransactionManagerName
		{
			get
			{
				return base["distributedTransactionManagerName"] as string;
			}
			set
			{
				base["distributedTransactionManagerName"] = value;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Transactions.Configuration.DefaultSettingsSection" /> class.</summary>
		public DefaultSettingsSection()
		{
		}
	}
}
namespace System.Transactions
{
}
namespace System.Transactions
{
}
