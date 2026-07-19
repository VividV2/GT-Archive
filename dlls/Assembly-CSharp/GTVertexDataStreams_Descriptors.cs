using System.IO;

public interface IGameEntitySerialize
{
	void OnGameEntitySerialize(System.IO.BinaryWriter writer);

	void OnGameEntityDeserialize(System.IO.BinaryReader reader);
}
