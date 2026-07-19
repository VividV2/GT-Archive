namespace System.Data.Common;

public abstract class DbDataSourceEnumerator
{
	protected DbDataSourceEnumerator()
	{
	}

	public abstract DataTable GetDataSources();
}
