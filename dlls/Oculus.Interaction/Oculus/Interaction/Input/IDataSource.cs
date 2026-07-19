using System;

namespace Oculus.Interaction.Input
{
	public interface IDataSource
	{
		int CurrentDataVersion { get; }

		event Action InputDataAvailable;

		void MarkInputDataRequiresUpdate();
	}
}
namespace Oculus.Interaction.PoseDetection
{
}
