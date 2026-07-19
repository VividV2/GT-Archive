using System;
using System;

namespace Pathfinding
{
}
namespace Pathfinding
{
	public interface INavmesh
	{
		void GetNodes(Action<GraphNode> del);
	}
}
namespace Pathfinding
{
	public enum HeuristicOptimizationMode
	{
		None,
		Random,
		RandomSpreadOut,
		Custom
	}
}
namespace Pathfinding
{
}
