using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace System.Configuration.Internal
{
	/// <summary>Defines interfaces used by internal .NET structures to support creation of new configuration records.</summary>
	/// <summary>Defines interfaces used by internal .NET structures to support creation of new configuration records.</summary>
	[ComVisible(false)]
	public interface IInternalConfigRecord
	{
		/// <summary>Gets a string representing a configuration file path.</summary>
		/// <returns>A string representing a configuration file path.</returns>
		/// <summary>Gets a string representing a configuration file path.</summary>
		/// <returns>A string representing a configuration file path.</returns>
		string ConfigPath { get; }

		/// <summary>Returns a value indicating whether an error occurred during initialization of a configuration object.</summary>
		/// <returns>
		///   <see langword="true" /> if an error occurred during initialization of a configuration object; otherwise, <see langword="false" />.</returns>
		/// <summary>Returns a value indicating whether an error occurred during initialization of a configuration object.</summary>
		/// <returns>
		///   <see langword="true" /> if an error occurred during initialization of a configuration object; otherwise, <see langword="false" />.</returns>
		bool HasInitErrors { get; }

		/// <summary>Returns the name of a <see cref="T:System.IO.Stream" /> object performing I/O tasks on the configuration file.</summary>
		/// <returns>A string representing the name of a <see cref="T:System.IO.Stream" /> object performing I/O tasks on the configuration file.</returns>
		/// <summary>Returns the name of a <see cref="T:System.IO.Stream" /> object performing I/O tasks on the configuration file.</summary>
		/// <returns>A string representing the name of a <see cref="T:System.IO.Stream" /> object performing I/O tasks on the configuration file.</returns>
		string StreamName { get; }

		/// <summary>Returns an object representing a section of a configuration from the last-known-good (LKG) configuration.</summary>
		/// <param name="configKey">A string representing a key to a configuration section.</param>
		/// <returns>An <see cref="T:System.Object" /> instance representing the section of the last-known-good configuration specified by <paramref name="configKey" />.</returns>
		/// <summary>Returns an object representing a section of a configuration from the last-known-good (LKG) configuration.</summary>
		/// <param name="configKey">A string representing a key to a configuration section.</param>
		/// <returns>An <see cref="T:System.Object" /> instance representing the section of the last-known-good configuration specified by <paramref name="configKey" />.</returns>
		object GetLkgSection(string configKey);

		/// <summary>Returns an <see cref="T:System.Object" /> instance representing a section of a configuration file.</summary>
		/// <param name="configKey">A string representing a key to a configuration section.</param>
		/// <returns>An <see cref="T:System.Object" /> instance representing a section of a configuration file.</returns>
		/// <summary>Returns an <see cref="T:System.Object" /> instance representing a section of a configuration file.</summary>
		/// <param name="configKey">A string representing a key to a configuration section.</param>
		/// <returns>An <see cref="T:System.Object" /> instance representing a section of a configuration file.</returns>
		object GetSection(string configKey);

		/// <summary>Causes a specified section of the configuration object to be reinitialized.</summary>
		/// <param name="configKey">A string representing a key to a configuration section that is to be refreshed.</param>
		/// <summary>Causes a specified section of the configuration object to be reinitialized.</summary>
		/// <param name="configKey">A string representing a key to a configuration section that is to be refreshed.</param>
		void RefreshSection(string configKey);

		/// <summary>Removes a configuration record.</summary>
		/// <summary>Removes a configuration record.</summary>
		void Remove();

		/// <summary>Grants the configuration object the permission to throw an exception if an error occurs during initialization.</summary>
		/// <summary>Grants the configuration object the permission to throw an exception if an error occurs during initialization.</summary>
		void ThrowIfInitErrors();
	}
}
namespace System.Configuration
{
	/// <summary>Converts a <see cref="T:System.TimeSpan" /> expressed in seconds or as a standard infinite time span.</summary>
	public sealed class TimeSpanSecondsOrInfiniteConverter : TimeSpanSecondsConverter
	{
		/// <summary>Converts a <see cref="T:System.String" /> to a <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">The <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> object used for type conversions.</param>
		/// <param name="ci">The <see cref="T:System.Globalization.CultureInfo" /> object used during conversion.</param>
		/// <param name="data">The <see cref="T:System.String" /> object to convert.</param>
		/// <returns>The <see cref="F:System.TimeSpan.MaxValue" />, if the <paramref name="data" /> parameter is the <see cref="T:System.String" /> "infinite"; otherwise, the <see cref="T:System.TimeSpan" /> representing the <paramref name="data" /> parameter in seconds.</returns>
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if ((string)data == "Infinite")
			{
				return TimeSpan.MaxValue;
			}
			return base.ConvertFrom(ctx, ci, data);
		}

		/// <summary>Converts a <see cref="T:System.TimeSpan" /> to a. <see cref="T:System.String" />.</summary>
		/// <param name="ctx">The <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> object used for type conversions.</param>
		/// <param name="ci">The <see cref="T:System.Globalization.CultureInfo" /> object used during conversion.</param>
		/// <param name="value">The value to convert.</param>
		/// <param name="type">The conversion type.</param>
		/// <returns>The <see cref="T:System.String" /> "infinite", if the <paramref name="value" /> parameter is <see cref="F:System.TimeSpan.MaxValue" />; otherwise, the <see cref="T:System.String" /> representing the <paramref name="value" /> parameter in seconds.</returns>
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value.GetType() != typeof(TimeSpan))
			{
				throw new ArgumentException();
			}
			if ((TimeSpan)value == TimeSpan.MaxValue)
			{
				return "Infinite";
			}
			return base.ConvertTo(ctx, ci, value, type);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Configuration.TimeSpanSecondsOrInfiniteConverter" /> class.</summary>
		public TimeSpanSecondsOrInfiniteConverter()
		{
		}
	}
}
