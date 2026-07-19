using System.Collections;

namespace System.IO
{
	/// <summary>Represents the method that will handle the <see cref="E:System.IO.FileSystemWatcher.Changed" />, <see cref="E:System.IO.FileSystemWatcher.Created" />, or <see cref="E:System.IO.FileSystemWatcher.Deleted" /> event of a <see cref="T:System.IO.FileSystemWatcher" /> class.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="T:System.IO.FileSystemEventArgs" /> that contains the event data.</param>
	public delegate void FileSystemEventHandler(object sender, FileSystemEventArgs e);
}
namespace System.ComponentModel.Design
{
	/// <summary>Provides support for building a set of related custom designers.</summary>
	public interface ITreeDesigner : IDesigner, IDisposable
	{
		/// <summary>Gets a collection of child designers.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" />, containing the collection of <see cref="T:System.ComponentModel.Design.IDesigner" /> child objects of the current designer.</returns>
		ICollection Children { get; }

		/// <summary>Gets the parent designer.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.Design.IDesigner" /> representing the parent designer, or <see langword="null" /> if there is no parent.</returns>
		IDesigner Parent { get; }
	}
}
namespace System.ComponentModel
{
}
