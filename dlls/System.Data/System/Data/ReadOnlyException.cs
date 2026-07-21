namespace System.Data.Odbc
{
	internal sealed class OdbcEnvironmentHandle : OdbcHandle
	{
		internal OdbcEnvironmentHandle()
		{
			base..ctor(SQL_HANDLE.ENV, null);
			retCode = Odbc.SQLSetEnvAttr(this, SQL_ATTR.ODBC_VERSION, ODBC32.SQL_OV_ODBC3, SQL_IS.INTEGER);
			retCode = Odbc.SQLSetEnvAttr(this, SQL_ATTR.CONNECTION_POOLING, ODBC32.SQL_CP_ONE_PER_HENV, SQL_IS.INTEGER);
			if ((uint)retCode > 1u)
			{
				Dispose();
				throw ODBC.CantEnableConnectionpooling(retCode);
			}
		}
	}
}
namespace System.Data.ProviderBase
{
}
namespace System.Data
{
}
