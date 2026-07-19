using System.Runtime.InteropServices;

namespace System.Drawing.Imaging
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct MonoMetafileHeader
	{
		[FieldOffset(0)]
		public MetafileType type;

		[FieldOffset(4)]
		public int size;

		[FieldOffset(8)]
		public int version;

		[FieldOffset(12)]
		public int emf_plus_flags;

		[FieldOffset(16)]
		public float dpi_x;

		[FieldOffset(20)]
		public float dpi_y;

		[FieldOffset(24)]
		public int x;

		[FieldOffset(28)]
		public int y;

		[FieldOffset(32)]
		public int width;

		[FieldOffset(36)]
		public int height;

		[FieldOffset(40)]
		public WmfMetaHeader wmf_header;

		[FieldOffset(40)]
		public EnhMetafileHeader emf_header;

		[FieldOffset(128)]
		public int emfplus_header_size;

		[FieldOffset(132)]
		public int logical_dpi_x;

		[FieldOffset(136)]
		public int logical_dpi_y;
	}
}
namespace System.Drawing.Drawing2D
{
}
namespace System.Drawing.Design
{
	[ComImport]
	[Guid("4BACD258-DE64-4048-BC4E-FEDBEF9ACB76")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IToolboxService
	{
		CategoryNameCollection CategoryNames { get; }

		string SelectedCategory { get; set; }

		void AddCreator(ToolboxItemCreatorCallback creator, string format);

		void AddCreator(ToolboxItemCreatorCallback creator, string format, System.ComponentModel.Design.IDesignerHost host);

		void AddLinkedToolboxItem(ToolboxItem toolboxItem, System.ComponentModel.Design.IDesignerHost host);

		void AddLinkedToolboxItem(ToolboxItem toolboxItem, string category, System.ComponentModel.Design.IDesignerHost host);

		void AddToolboxItem(ToolboxItem toolboxItem);

		void AddToolboxItem(ToolboxItem toolboxItem, string category);

		ToolboxItem DeserializeToolboxItem(object serializedObject);

		ToolboxItem DeserializeToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host);

		ToolboxItem GetSelectedToolboxItem();

		ToolboxItem GetSelectedToolboxItem(System.ComponentModel.Design.IDesignerHost host);

		ToolboxItemCollection GetToolboxItems();

		ToolboxItemCollection GetToolboxItems(System.ComponentModel.Design.IDesignerHost host);

		ToolboxItemCollection GetToolboxItems(string category);

		ToolboxItemCollection GetToolboxItems(string category, System.ComponentModel.Design.IDesignerHost host);

		bool IsSupported(object serializedObject, System.ComponentModel.Design.IDesignerHost host);

		bool IsSupported(object serializedObject, System.Collections.ICollection filterAttributes);

		bool IsToolboxItem(object serializedObject);

		bool IsToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host);

		void Refresh();

		void RemoveCreator(string format);

		void RemoveCreator(string format, System.ComponentModel.Design.IDesignerHost host);

		void RemoveToolboxItem(ToolboxItem toolboxItem);

		void RemoveToolboxItem(ToolboxItem toolboxItem, string category);

		void SelectedToolboxItemUsed();

		object SerializeToolboxItem(ToolboxItem toolboxItem);

		bool SetCursor();

		void SetSelectedToolboxItem(ToolboxItem toolboxItem);
	}
}
