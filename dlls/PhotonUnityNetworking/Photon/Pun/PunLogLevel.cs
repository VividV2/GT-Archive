namespace Photon.Pun
{
	public enum PunLogLevel
	{
		ErrorsOnly,
		Informational,
		Full
	}
}
namespace Photon.Pun
{
	public interface IOnPhotonViewPreNetDestroy : IPhotonViewCallback
	{
		void OnPreNetDestroy(PhotonView rootView);
	}
}
