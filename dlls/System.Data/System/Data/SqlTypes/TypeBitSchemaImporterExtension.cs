namespace System.Data
{
}
namespace System.Data
{
	/// <summary>Allows an object to implement a DataAdapter, and represents a set of methods and mapping action-related properties that are used to fill and update a <see cref="T:System.Data.DataSet" /> and update a data source.  
	///  <see cref="T:System.Data.IDbDataAdapter" /> instances are for data sources that are (or resemble) relational databases with textual commands (like Transact-SQL), while <see cref="T:System.Data.IDataAdapter" /> instances could can use any type of data source.</summary>
	public interface IDataAdapter
	{
		MissingMappingAction MissingMappingAction { get; set; }

		MissingSchemaAction MissingSchemaAction { get; set; }

		ITableMappingCollection TableMappings { get; }

		DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType);

		int Fill(DataSet dataSet);

		IDataParameter[] GetFillParameters();

		int Update(DataSet dataSet);
	}
}
