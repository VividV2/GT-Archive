using SouthPointe.Serialization.MessagePack;
using UnityEngine.Scripting;

namespace Liv.Lck.Core.Serialization
{
	[Preserve]
	internal class LckMsgPackSerializer : ILckSerializer
	{
		private readonly MessagePackFormatter _formatter = new MessagePackFormatter();

		public SerializationType SerializationType => SerializationType.MsgPack;

		[Preserve]
		public LckMsgPackSerializer()
		{
		}

		public byte[] Serialize(object data)
		{
			return _formatter.Serialize(data);
		}

		public T Deserialize<T>(byte[] data)
		{
			return _formatter.Deserialize<T>(data);
		}
	}
}
namespace Liv.Lck.Core.Cosmetics
{
}
namespace Liv.Lck.Core.Serialization
{
	public interface ILckSerializer
	{
		SerializationType SerializationType { get; }

		byte[] Serialize(object data);

		T Deserialize<T>(byte[] data);
	}
}
