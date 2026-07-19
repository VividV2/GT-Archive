using System.Collections.Generic;
using System.Collections.Generic;

namespace System.Data.SqlClient
{
	internal sealed class BulkCopySimpleResultSet
	{
		private readonly List<Result> _results = new List<Result>();

		private Result _resultSet;

		private int[] _indexmap;

		internal Result this[int idx] => _results[idx];

		internal BulkCopySimpleResultSet()
		{
		}

		internal void SetMetaData(_SqlMetaDataSet metadata)
		{
			_resultSet = new Result(metadata);
			_results.Add(_resultSet);
			int i;
			for (_indexmap = new int[_resultSet.MetaData.Length], int i = 0; i < _indexmap.Length; i++)
			{
				_indexmap[i] = i;
			}
		}

		internal int[] CreateIndexMap()
		{
			return _indexmap;
		}

		internal object[] CreateRowBuffer()
		{
			Row row = new Row(_resultSet.MetaData.Length);
			Row row;
			_resultSet.AddRow(row);
			return row.DataFields;
		}
	}
}
namespace System.Data
{
}
