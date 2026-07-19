namespace System.Data;

/// <summary>Provides a description of the results of the query and its effect on the database.</summary>
[Flags]
public enum CommandBehavior
{
	Default = 0,
	SingleResult = 1,
	SchemaOnly = 2,
	KeyInfo = 4,
	SingleRow = 8,
	SequentialAccess = 0x10,
	CloseConnection = 0x20
}
