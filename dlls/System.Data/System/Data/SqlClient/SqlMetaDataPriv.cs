using System.Collections.Generic;
using System.Text;
using Microsoft.SqlServer.Server;

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
	internal class SqlMetaDataPriv
	{
		internal SqlDbType type;

		internal byte tdsType;

		internal byte precision = byte.MaxValue;

		internal byte scale = byte.MaxValue;

		internal int length;

		internal SqlCollation collation;

		internal int codePage;

		internal Encoding encoding;

		internal bool isNullable;

		internal bool isMultiValued;

		internal string udtDatabaseName;

		internal string udtSchemaName;

		internal string udtTypeName;

		internal string udtAssemblyQualifiedName;

		internal Type udtType;

		internal string xmlSchemaCollectionDatabase;

		internal string xmlSchemaCollectionOwningSchema;

		internal string xmlSchemaCollectionName;

		internal MetaType metaType;

		internal string structuredTypeDatabaseName;

		internal string structuredTypeSchemaName;

		internal string structuredTypeName;

		internal IList<SmiMetaData> structuredFields;

		internal SqlMetaDataPriv()
		{
		}

		internal virtual void CopyFrom(SqlMetaDataPriv original)
		{
			type = original.type;
			tdsType = original.tdsType;
			precision = original.precision;
			scale = original.scale;
			length = original.length;
			collation = original.collation;
			codePage = original.codePage;
			encoding = original.encoding;
			isNullable = original.isNullable;
			isMultiValued = original.isMultiValued;
			udtDatabaseName = original.udtDatabaseName;
			udtSchemaName = original.udtSchemaName;
			udtTypeName = original.udtTypeName;
			udtAssemblyQualifiedName = original.udtAssemblyQualifiedName;
			udtType = original.udtType;
			xmlSchemaCollectionDatabase = original.xmlSchemaCollectionDatabase;
			xmlSchemaCollectionOwningSchema = original.xmlSchemaCollectionOwningSchema;
			xmlSchemaCollectionName = original.xmlSchemaCollectionName;
			metaType = original.metaType;
			structuredTypeDatabaseName = original.structuredTypeDatabaseName;
			structuredTypeSchemaName = original.structuredTypeSchemaName;
			structuredTypeName = original.structuredTypeName;
			structuredFields = original.structuredFields;
		}
	}
}
namespace System.Data
{
}
