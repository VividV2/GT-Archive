namespace System.Net.NetworkInformation;

/// <summary>The scope level for an IPv6 address.</summary>
public enum ScopeLevel
{
	/// <summary>The scope level is not specified.</summary>
	None = 0,
	Interface = 1,
	Link = 2,
	Subnet = 3,
	Admin = 4,
	Site = 5,
	Organization = 8,
	Global = 14
}
