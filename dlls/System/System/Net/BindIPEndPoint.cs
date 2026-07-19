namespace System.Net
{
	/// <summary>Represents the method that specifies a local Internet Protocol address and port number for a <see cref="T:System.Net.ServicePoint" />.</summary>
	/// <param name="servicePoint">The <see cref="T:System.Net.ServicePoint" /> associated with the connection to be created.</param>
	/// <param name="remoteEndPoint">The remote <see cref="T:System.Net.IPEndPoint" /> that specifies the remote host.</param>
	/// <param name="retryCount">The number of times this delegate was called for a specified connection.</param>
	/// <returns>The local <see cref="T:System.Net.IPEndPoint" /> to which the <see cref="T:System.Net.ServicePoint" /> is bound.</returns>
	/// <summary>Represents the method that specifies a local Internet Protocol address and port number for a <see cref="T:System.Net.ServicePoint" />.</summary>
	/// <param name="servicePoint">The <see cref="T:System.Net.ServicePoint" /> associated with the connection to be created.</param>
	/// <param name="remoteEndPoint">The remote <see cref="T:System.Net.IPEndPoint" /> that specifies the remote host.</param>
	/// <param name="retryCount">The number of times this delegate was called for a specified connection.</param>
	/// <returns>The local <see cref="T:System.Net.IPEndPoint" /> to which the <see cref="T:System.Net.ServicePoint" /> is bound.</returns>
	public delegate IPEndPoint BindIPEndPoint(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount);
}
namespace System.Security.Permissions
{
	/// <summary>Specifies the permitted access to X.509 certificate stores.</summary>
	/// <summary>Specifies the permitted access to X.509 certificate stores.</summary>
	[Serializable]
	[Flags]
	public enum StorePermissionFlags
	{
		/// <summary>Permission is not given to perform any certificate or store operations.</summary>
		/// <summary>Permission is not given to perform any certificate or store operations.</summary>
		NoFlags = 0,
		/// <summary>The ability to create a new store.</summary>
		CreateStore = 1,
		/// <summary>The ability to delete a store.</summary>
		DeleteStore = 2,
		/// <summary>The ability to enumerate the stores on a computer.</summary>
		EnumerateStores = 4,
		/// <summary>The ability to open a store.</summary>
		OpenStore = 0x10,
		/// <summary>The ability to add a certificate to a store.</summary>
		AddToStore = 0x20,
		/// <summary>The ability to remove a certificate from a store.</summary>
		RemoveFromStore = 0x40,
		/// <summary>The ability to enumerate the certificates in a store.</summary>
		EnumerateCertificates = 0x80,
		/// <summary>The ability to perform all certificate and store operations.</summary>
		AllFlags = 0xF7
	}
}
