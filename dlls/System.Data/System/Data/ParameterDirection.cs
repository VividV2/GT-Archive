namespace System.Data
{
	/// <summary>Represents the method that will handle the <see cref="E:System.Data.DataTable.ColumnChanging" /> event.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data.</param>
	/// <summary>Represents the method that will handle the <see cref="E:System.Data.DataTable.ColumnChanging" /> event.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.Data.DataColumnChangeEventArgs" /> that contains the event data.</param>
	public delegate void DataColumnChangeEventHandler(object sender, DataColumnChangeEventArgs e);
}
namespace System.Data
{
	/// <summary>Specifies the type of a parameter within a query relative to the <see cref="T:System.Data.DataSet" />.</summary>
	/// <summary>Specifies the type of a parameter within a query relative to the <see cref="T:System.Data.DataSet" />.</summary>
	public enum ParameterDirection
	{
		/// <summary>The parameter is an input parameter.</summary>
		/// <summary>The parameter is an input parameter.</summary>
		Input = 1,
		/// <summary>The parameter is an output parameter.</summary>
		/// <summary>The parameter is an output parameter.</summary>
		Output = 2,
		/// <summary>The parameter is capable of both input and output.</summary>
		/// <summary>The parameter is capable of both input and output.</summary>
		InputOutput = 3,
		/// <summary>The parameter represents a return value from an operation such as a stored procedure, built-in function, or user-defined function.</summary>
		/// <summary>The parameter represents a return value from an operation such as a stored procedure, built-in function, or user-defined function.</summary>
		ReturnValue = 6
	}
}
