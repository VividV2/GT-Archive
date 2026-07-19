namespace Liv.Lck.Core
{
	public struct GameInfo
	{
		public string GameName;

		public string GameVersion;

		public string ProjectName;

		public string CompanyName;

		public string EngineVersion;

		public string RenderPipeline;

		public string GraphicsAPI;

		public string Platform;

		public string PersistentDataPath;

		public string InteractionSystems;
	}
}
namespace Liv.Lck.Core
{
	public enum SerializationType : uint
	{
		MsgPack,
		JsonUTF8
	}
}
