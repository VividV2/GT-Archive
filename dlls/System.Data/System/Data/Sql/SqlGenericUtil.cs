using System.Data.Common;

namespace System.Data.Sql
{
	internal sealed class SqlGenericUtil
	{
		private SqlGenericUtil()
		{
		}

		internal static Exception NullCommandText()
		{
			return ADP.Argument(Res.GetString("Command parameter must have a non null and non empty command text."));
		}

		internal static Exception MismatchedMetaDataDirectionArrayLengths()
		{
			return ADP.Argument(Res.GetString("MetaData parameter array must have length equivalent to ParameterDirection array argument."));
		}
	}
}
namespace System.Data
{
	/// <summary>Represents the method that will handle the <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowDeleting" />, and <see cref="E:System.Data.DataTable.RowDeleted" /> events of a <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	/// <summary>Represents the method that will handle the <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowDeleting" />, and <see cref="E:System.Data.DataTable.RowDeleted" /> events of a <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.Data.DataRowChangeEventArgs" /> that contains the event data.</param>
	public delegate void DataRowChangeEventHandler(object sender, DataRowChangeEventArgs e);
}
namespace System.Data
{
}
namespace System.Data
{
}
