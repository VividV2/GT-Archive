namespace System.ComponentModel.Composition.Hosting
{
	/// <summary>Defines options for export providers.</summary>
	/// <summary>Defines options for export providers.</summary>
	[Flags]
	public enum CompositionOptions
	{
		/// <summary>No options are defined.</summary>
		/// <summary>No options are defined.</summary>
		Default = 0,
		/// <summary>Silent rejection is disabled, so all rejections will result in errors.</summary>
		/// <summary>Silent rejection is disabled, so all rejections will result in errors.</summary>
		DisableSilentRejection = 1,
		/// <summary>This provider should be thread-safe.</summary>
		/// <summary>This provider should be thread-safe.</summary>
		IsThreadSafe = 2,
		/// <summary>This provider is an export composition service.</summary>
		/// <summary>This provider is an export composition service.</summary>
		ExportCompositionService = 4
	}
}
namespace System.ComponentModel.Composition.Hosting
{
}
namespace System.ComponentModel.Composition.ReflectionModel
{
}
