namespace System.Data.SqlClient;

internal struct SNIErrorDetails
{
	public string errorMessage;

	public uint nativeError;

	public uint sniErrorNumber;

	public int provider;

	public uint lineNumber;

	public string function;

	public Exception exception;
}
namespace System.Data.SqlClient
{
	internal class SessionStateRecord
	{
		internal bool _recoverable;

		internal uint _version;

		internal int _dataLength;

		internal byte[] _data;
	}
}
namespace System.Data
{
}
namespace System.Data.SqlClient
{
}
namespace System.Data
{
}
