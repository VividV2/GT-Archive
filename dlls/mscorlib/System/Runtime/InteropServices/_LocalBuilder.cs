using System.Runtime.InteropServices;

namespace System.Security.Principal;

/// <summary>Specifies common roles to be used with <see cref="M:System.Security.Principal.WindowsPrincipal.IsInRole(System.String)" />.</summary>
[Serializable]
[ComVisible(true)]
public enum WindowsBuiltInRole
{
	/// <summary>Administrators have complete and unrestricted access to the computer or domain.</summary>
	Administrator = 544,
	/// <summary>Users are prevented from making accidental or intentional system-wide changes. Thus, users can run certified applications, but not most legacy applications.</summary>
	User,
	/// <summary>Guests are more restricted than users.</summary>
	Guest,
	/// <summary>Power users possess most administrative permissions with some restrictions. Thus, power users can run legacy applications, in addition to certified applications.</summary>
	PowerUser,
	/// <summary>Account operators manage the user accounts on a computer or domain.</summary>
	AccountOperator,
	SystemOperator,
	PrintOperator,
	BackupOperator,
	Replicator
}
