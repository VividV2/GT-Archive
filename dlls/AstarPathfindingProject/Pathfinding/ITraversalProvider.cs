namespace Pathfinding
{
	public interface ITraversalProvider
	{
		bool CanTraverse(Path path, GraphNode node);

		uint GetTraversalCost(Path path, GraphNode node);
	}
}
namespace Pathfinding
{
	public interface IUpdatableGraph
	{
		void UpdateArea(GraphUpdateObject o);

		void UpdateAreaInit(GraphUpdateObject o);

		void UpdateAreaPost(GraphUpdateObject o);

		GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o);
	}
}
