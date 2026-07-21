using System.ComponentModel.Design;

namespace System.Drawing.Imaging
{
	/// <summary>Specifies the unit of measurement for the rectangle used to size and position a metafile. This is specified during the creation of the <see cref="T:System.Drawing.Imaging.Metafile" /> object.</summary>
	/// <summary>Specifies the unit of measurement for the rectangle used to size and position a metafile. This is specified during the creation of the <see cref="T:System.Drawing.Imaging.Metafile" /> object.</summary>
	public enum MetafileFrameUnit
	{
		/// <summary>The unit of measurement is 1 pixel.</summary>
		/// <summary>The unit of measurement is 1 pixel.</summary>
		Pixel = 2,
		/// <summary>The unit of measurement is 1 printer's point.</summary>
		/// <summary>The unit of measurement is 1 printer's point.</summary>
		Point,
		/// <summary>The unit of measurement is 1 inch.</summary>
		/// <summary>The unit of measurement is 1 inch.</summary>
		Inch,
		/// <summary>The unit of measurement is 1/300 of an inch.</summary>
		/// <summary>The unit of measurement is 1/300 of an inch.</summary>
		Document,
		/// <summary>The unit of measurement is 1 millimeter.</summary>
		/// <summary>The unit of measurement is 1 millimeter.</summary>
		Millimeter,
		/// <summary>The unit of measurement is 0.01 millimeter. Provided for compatibility with GDI.</summary>
		/// <summary>The unit of measurement is 0.01 millimeter. Provided for compatibility with GDI.</summary>
		GdiCompatible
	}
}
namespace System.Drawing.Design
{
	/// <summary>Provides data for the <see cref="E:System.Drawing.Design.ToolboxItem.ComponentsCreating" /> event that occurs when components are added to the toolbox.</summary>
	public class ToolboxComponentsCreatingEventArgs : EventArgs
	{
		private readonly IDesignerHost host;

		/// <summary>Gets or sets an instance of the <see cref="T:System.ComponentModel.Design.IDesignerHost" /> that made the request to create toolbox components.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.IDesignerHost" /> that made the request to create toolbox components, or <see langword="null" /> if no designer host was provided to the toolbox item.</returns>
		public IDesignerHost DesignerHost => host;

		/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Design.ToolboxComponentsCreatingEventArgs" /> class.</summary>
		/// <param name="host">The designer host that is making the request.</param>
		public ToolboxComponentsCreatingEventArgs(IDesignerHost host)
		{
			this.host = host;
		}
	}
}
namespace System.Drawing
{
}
namespace System.Drawing.Printing
{
	public enum PrinterUnit
	{
		Display,
		ThousandthsOfAnInch,
		HundredthsOfAMillimeter,
		TenthsOfAMillimeter
	}
}
