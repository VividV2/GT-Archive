using System;

namespace Photon.Voice
{
}
namespace Photon.Voice
{
	public interface ObjectFactory<TType, TInfo> : IDisposable
	{
		TInfo Info { get; }

		TType New();

		TType New(TInfo info);

		void Free(TType obj);

		void Free(TType obj, TInfo info);
	}
}
namespace Photon.Voice
{
}
