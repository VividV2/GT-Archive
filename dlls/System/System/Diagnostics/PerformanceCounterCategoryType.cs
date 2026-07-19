namespace System.Diagnostics
{
	/// <summary>Indicates whether the performance counter category can have multiple instances.</summary>
	/// <summary>Indicates whether the performance counter category can have multiple instances.</summary>
	public enum PerformanceCounterCategoryType
	{
		/// <summary>The performance counter category can have only a single instance.</summary>
		/// <summary>The performance counter category can have only a single instance.</summary>
		SingleInstance = 0,
		/// <summary>The performance counter category can have multiple instances.</summary>
		MultiInstance = 1,
		/// <summary>The instance functionality for the performance counter category is unknown.</summary>
		Unknown = -1
	}
}
namespace System.Diagnostics
{
	/// <summary>Defines access levels used by <see cref="T:System.Diagnostics.PerformanceCounter" /> permission classes.</summary>
	[Flags]
	public enum PerformanceCounterPermissionAccess
	{
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> has no permissions.</summary>
		None = 0,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read categories.</summary>
		[Obsolete]
		Browse = 1,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read categories.</summary>
		Read = 1,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can write categories.</summary>
		Write = 2,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read and write categories.</summary>
		[Obsolete]
		Instrument = 3,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read, write, and create categories.</summary>
		Administer = 7
	}
}
namespace System
{
}
