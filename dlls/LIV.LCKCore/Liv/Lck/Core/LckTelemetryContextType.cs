namespace Liv.Lck.Core.Serialization
{
	[Preserve]
	internal class LckMsgPackSerializer : ILckSerializer
	{
		private readonly MessagePackFormatter _formatter;

		public SerializationType SerializationType
		{
			get
			{
				return SerializationType.MsgPack;
			}
		}

		[Preserve]
		public LckMsgPackSerializer()
		{
			_formatter = new MessagePackFormatter();
			base..ctor();
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
}
