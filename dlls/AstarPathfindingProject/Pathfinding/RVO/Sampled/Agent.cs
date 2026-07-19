using Pathfinding.RVO;
using UnityEngine;
using Pathfinding.RVO;
using UnityEngine;
using UnityEngine;

namespace Pathfinding.RVO
{
	public class ObstacleVertex
	{
		public bool ignore;

		public Vector3 position;

		public Vector2 dir;

		public float height;

		public RVOLayer layer = RVOLayer.DefaultObstacle;

		public ObstacleVertex next;

		public ObstacleVertex prev;
	}
}
namespace Pathfinding.Examples
{
	[RequireComponent(typeof(RVOController))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_manual_r_v_o_agent.php")]
	public class ManualRVOAgent : MonoBehaviour
	{
		private RVOController rvo;

		public float speed = 1f;

		private void Awake()
		{
			rvo = GetComponent<RVOController>();
		}

		private void Update()
		{
			float axis = Input.GetAxis("Horizontal");
			float axis2 = Input.GetAxis("Vertical");
			float axis;
			float axis2;
			Vector3 vector = new Vector3(axis, 0f, axis2) * speed;
			Vector3 vector;
			rvo.velocity = vector;
			base.transform.position += vector * Time.deltaTime;
		}
	}
}
