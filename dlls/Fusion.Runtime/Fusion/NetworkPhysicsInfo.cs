using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Fusion.LagCompensation
{
	internal interface ILagCompensationBroadphase
	{
		void CopyFrom(ILagCompensationBroadphase other);

		void Traverse(IBoundsTraversalTest hitTest, HashSet<HitboxRoot> candidateRoots, int layerMask);

		void Add(HitboxRoot root);

		bool Remove(HitboxRoot root);

		void Update(HitboxRoot changed, int tick);
	}
}
namespace Fusion
{
	[StructLayout(LayoutKind.Explicit)]
	[NetworkStructWeaved(10)]
	public struct NetworkPhysicsInfo : INetworkStruct
	{
		public const int WORD_COUNT = 10;

		public const int SIZE = 40;

		[FieldOffset(0)]
		public float TimeScale;
	}
}
namespace Fusion
{
	public interface INetworkSceneManager
	{
		bool IsBusy { get; }

		Scene MainRunnerScene { get; }

		void Initialize(NetworkRunner runner);

		void Shutdown();

		bool IsRunnerScene(Scene scene);

		bool TryGetPhysicsScene2D(out PhysicsScene2D scene2D);

		bool TryGetPhysicsScene3D(out PhysicsScene scene3D);

		void MakeDontDestroyOnLoad(GameObject obj);

		bool MoveGameObjectToScene(GameObject gameObject, SceneRef sceneRef);

		NetworkSceneAsyncOp LoadScene(SceneRef sceneRef, NetworkLoadSceneParameters parameters);

		NetworkSceneAsyncOp UnloadScene(SceneRef sceneRef);

		SceneRef GetSceneRef(GameObject gameObject);

		SceneRef GetSceneRef(string sceneNameOrPath);

		bool OnSceneInfoChanged(NetworkSceneInfo sceneInfo, NetworkSceneInfoChangeSource changeSource);
	}
}
namespace Fusion.Statistics
{
}
namespace Fusion
{
}
