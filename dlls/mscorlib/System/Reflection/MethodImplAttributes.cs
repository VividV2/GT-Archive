namespace System.Resources;

[Serializable]
public class MissingManifestResourceException : SystemException
{
	public MissingManifestResourceException()
	{
		base..ctor("Unable to find manifest resource.");
		base.HResult = -2146233038;
	}

	public MissingManifestResourceException(string message)
	{
		base..ctor(message);
		base.HResult = -2146233038;
	}

	public MissingManifestResourceException(string message, Exception inner)
	{
		base..ctor(message, inner);
		base.HResult = -2146233038;
	}

	protected MissingManifestResourceException(SerializationInfo info, StreamingContext context)
	{
		base..ctor();
	}
}
