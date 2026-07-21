using System.Runtime.Serialization;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	internal interface ISerializationRootObject
	{
		void RootSetObjectData(SerializationInfo info, StreamingContext context);
	}
}
namespace System.Security.Cryptography
{
	public enum PbeEncryptionAlgorithm
	{
		Unknown,
		Aes128Cbc,
		Aes192Cbc,
		Aes256Cbc,
		TripleDes3KeyPkcs12
	}
}
