public struct SnapData
{
	public int attachIndex;

	public SnapBounds snapBounds;
}
public interface SIGadgetProjectileType
{
	void LocalProjectileHit(SIPlayer player = null);

	void NetworkedProjectileHit(object[] data);
}
