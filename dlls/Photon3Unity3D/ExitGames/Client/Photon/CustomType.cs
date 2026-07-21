namespace ExitGames.Client.Photon
{
	public class InvalidDataException : Exception
	{
		public InvalidDataException(string message)
		{
			base..ctor(message);
		}
	}
}
