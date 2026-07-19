public enum GetSessionResponseType
{
	OK = 200,
	NOT_FOUND = 204,
	LOST = 404,
	ERROR = 0
}
public interface IFXEffectContext<T> where T : IFXEffectContextObject
{
	T effectContext { get; }

	FXSystemSettings settings { get; }
}
