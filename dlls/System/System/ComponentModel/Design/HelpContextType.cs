namespace System.ComponentModel.Design
{
	/// <summary>Defines identifiers that indicate information about the context in which a request for Help information originated.</summary>
	public enum HelpContextType
	{
		/// <summary>A general context.</summary>
		Ambient,
		/// <summary>A window.</summary>
		Window,
		/// <summary>A selection.</summary>
		Selection,
		/// <summary>A tool window selection.</summary>
		ToolWindowSelection
	}
}
namespace System.ComponentModel.Design
{
	/// <summary>Represents the method that will handle a <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" /> event.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.ComponentModel.Design.ComponentChangedEventArgs" /> that contains the event data.</param>
	public delegate void ComponentChangedEventHandler(object sender, ComponentChangedEventArgs e);
}
