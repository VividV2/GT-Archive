using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;

public class GameEntityZone
{
	public int zoneId;

	public NetPlayer owner;

	public List<GameEntityId> entities;
}
public interface IFXContext
{
	FXSystemSettings settings { get; }

	void OnPlayFX();
}
