namespace System.Transactions;

/// <summary>Specifies how distributed transactions interact with COM+ transactions.</summary>
public enum EnterpriseServicesInteropOption
{
	/// <summary>There is no synchronization between <see cref="P:System.EnterpriseServices.ContextUtil.Transaction" /> and <see cref="P:System.Transactions.Transaction.Current" />.</summary>
	None,
	Automatic,
	Full
}
