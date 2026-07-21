namespace System.Data;

/// <summary>Specifies the action to take with regard to the current and remaining rows during an <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
public enum UpdateStatus
{
	Continue,
	ErrorsOccurred,
	SkipCurrentRow,
	SkipAllRemainingRows
}
