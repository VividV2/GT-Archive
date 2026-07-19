using System;
using System.ComponentModel;
using System;

namespace System.Data
{
	/// <summary>Marks a property, event, or extender with a description. Visual designers can display this description when referencing the member.</summary>
	[Obsolete("DataSysDescriptionAttribute has been deprecated.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
	[AttributeUsage(AttributeTargets.All)]
	public class DataSysDescriptionAttribute : DescriptionAttribute
	{
		private bool _replaced;

		/// <summary>Gets the text for the description.</summary>
		/// <returns>The description string.</returns>
		public override string Description
		{
			get
			{
				if (!_replaced)
				{
					_replaced = true;
					base.DescriptionValue = base.Description;
				}
				return base.Description;
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataSysDescriptionAttribute" /> class using the specified description string.</summary>
		/// <param name="description">The description string.</param>
		[Obsolete("DataSysDescriptionAttribute has been deprecated.  https://go.microsoft.com/fwlink/?linkid=14202", false)]
		public DataSysDescriptionAttribute(string description)
			: base(description)
		{
		}
	}
}
namespace Microsoft.SqlServer.Server
{
}
namespace Microsoft.SqlServer.Server
{
	/// <summary>Describes the type of access to user data for a user-defined method or function.</summary>
	/// <summary>Describes the type of access to user data for a user-defined method or function.</summary>
	[Serializable]
	public enum DataAccessKind
	{
		/// <summary>The method or function does not access user data.</summary>
		/// <summary>The method or function does not access user data.</summary>
		None,
		/// <summary>The method or function reads user data.</summary>
		/// <summary>The method or function reads user data.</summary>
		Read
	}
}
namespace System.Data
{
}
