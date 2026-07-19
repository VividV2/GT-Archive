namespace System.ComponentModel.Design;

/// <summary>Provides an interface for managing designer transactions and components.</summary>
public interface IDesignerHost : IServiceContainer, IServiceProvider
{
	/// <summary>Gets a value indicating whether the designer host is currently loading the document.</summary>
	/// <returns>
	///   <see langword="true" /> if the designer host is currently loading the document; otherwise, <see langword="false" />.</returns>
	bool Loading { get; }

	/// <summary>Gets a value indicating whether the designer host is currently in a transaction.</summary>
	/// <returns>
	///   <see langword="true" /> if a transaction is in progress; otherwise, <see langword="false" />.</returns>
	bool InTransaction { get; }

	/// <summary>Gets the container for this designer host.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.IContainer" /> for this host.</returns>
	IContainer Container { get; }

	/// <summary>Gets the instance of the base class used as the root component for the current design.</summary>
	/// <returns>The instance of the root component class.</returns>
	IComponent RootComponent { get; }

	/// <summary>Gets the fully qualified name of the class being designed.</summary>
	/// <returns>The fully qualified name of the base component class.</returns>
	string RootComponentClassName { get; }

	/// <summary>Gets the description of the current transaction.</summary>
	/// <returns>A description of the current transaction.</returns>
	string TransactionDescription { get; }

	/// <summary>Occurs when this designer is activated.</summary>
	event EventHandler Activated;

	/// <summary>Occurs when this designer is deactivated.</summary>
	event EventHandler Deactivated;

	/// <summary>Occurs when this designer completes loading its document.</summary>
	event EventHandler LoadComplete;

	/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosed" /> event.</summary>
	event DesignerTransactionCloseEventHandler TransactionClosed;

	/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionClosing" /> event.</summary>
	event DesignerTransactionCloseEventHandler TransactionClosing;

	/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpened" /> event.</summary>
	event EventHandler TransactionOpened;

	/// <summary>Adds an event handler for the <see cref="E:System.ComponentModel.Design.IDesignerHost.TransactionOpening" /> event.</summary>
	event EventHandler TransactionOpening;

	/// <summary>Activates the designer that this host is hosting.</summary>
	void Activate();

	/// <summary>Creates a component of the specified type and adds it to the design document.</summary>
	/// <param name="componentClass">The type of the component to create.</param>
	/// <returns>The newly created component.</returns>
	IComponent CreateComponent(Type componentClass);

	/// <summary>Creates a component of the specified type and name, and adds it to the design document.</summary>
	/// <param name="componentClass">The type of the component to create.</param>
	/// <param name="name">The name for the component.</param>
	/// <returns>The newly created component.</returns>
	IComponent CreateComponent(Type componentClass, string name);

	DesignerTransaction CreateTransaction();

	DesignerTransaction CreateTransaction(string description);

	void DestroyComponent(IComponent component);

	IDesigner GetDesigner(IComponent component);

	Type GetType(string typeName);
}
