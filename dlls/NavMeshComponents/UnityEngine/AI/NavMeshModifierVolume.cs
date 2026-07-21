using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnityEngine.AI
{
}
namespace UnityEngine.AI
{
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[SerializeField]
		private Vector3 m_Size = new Vector3(4f, 3f, 4f);

		[SerializeField]
		private Vector3 m_Center = new Vector3(0f, 1f, 0f);

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private List<int> m_AffectedAgents = new List<int>(new int[1] { -1 });

		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers = new List<NavMeshModifierVolume>();

		public Vector3 size
		{
			get
			{
				return m_Size;
			}
			set
			{
				m_Size = value;
			}
		}

		public Vector3 center
		{
			get
			{
				return m_Center;
			}
			set
			{
				m_Center = value;
			}
		}

		public int area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
			}
		}

		public static List<NavMeshModifierVolume> activeModifiers => s_NavMeshModifiers;

		private void OnEnable()
		{
			if (!s_NavMeshModifiers.Contains(this))
			{
				s_NavMeshModifiers.Add(this);
			}
		}

		private void OnDisable()
		{
			s_NavMeshModifiers.Remove(this);
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			if (m_AffectedAgents.Count == 0)
			{
				return false;
			}
			if (m_AffectedAgents[0] == -1)
			{
				return true;
			}
			return m_AffectedAgents.IndexOf(agentTypeID) != -1;
		}
	}
}
namespace UnityEngine.AI
{
	public enum CollectObjects
	{
		All,
		Volume,
		Children
	}
}
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	private struct MonoScriptData
	{
		public byte[] FilePathsData;

		public byte[] TypesData;

		public int TotalTypes;

		public int TotalFiles;

		public bool IsEditorOnly;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static MonoScriptData Get()
	{
		return new MonoScriptData
		{
			FilePathsData = new byte[241]
			{
				0, 0, 0, 1, 0, 0, 0, 48, 92, 65,
				115, 115, 101, 116, 115, 92, 78, 97, 118, 77,
				101, 115, 104, 67, 111, 109, 112, 111, 110, 101,
				110, 116, 115, 92, 83, 99, 114, 105, 112, 116,
				115, 92, 78, 97, 118, 77, 101, 115, 104, 76,
				105, 110, 107, 46, 99, 115, 0, 0, 0, 1,
				0, 0, 0, 52, 92, 65, 115, 115, 101, 116,
				115, 92, 78, 97, 118, 77, 101, 115, 104, 67,
				111, 109, 112, 111, 110, 101, 110, 116, 115, 92,
				83, 99, 114, 105, 112, 116, 115, 92, 78, 97,
				118, 77, 101, 115, 104, 77, 111, 100, 105, 102,
				105, 101, 114, 46, 99, 115, 0, 0, 0, 1,
				0, 0, 0, 58, 92, 65, 115, 115, 101, 116,
				115, 92, 78, 97, 118, 77, 101, 115, 104, 67,
				111, 109, 112, 111, 110, 101, 110, 116, 115, 92,
				83, 99, 114, 105, 112, 116, 115, 92, 78, 97,
				118, 77, 101, 115, 104, 77, 111, 100, 105, 102,
				105, 101, 114, 86, 111, 108, 117, 109, 101, 46,
				99, 115, 0, 0, 0, 1, 0, 0, 0, 51,
				92, 65, 115, 115, 101, 116, 115, 92, 78, 97,
				118, 77, 101, 115, 104, 67, 111, 109, 112, 111,
				110, 101, 110, 116, 115, 92, 83, 99, 114, 105,
				112, 116, 115, 92, 78, 97, 118, 77, 101, 115,
				104, 83, 117, 114, 102, 97, 99, 101, 46, 99,
				115
			},
			TypesData = new byte[141]
			{
				0, 0, 0, 0, 26, 85, 110, 105, 116, 121,
				69, 110, 103, 105, 110, 101, 46, 65, 73, 124,
				78, 97, 118, 77, 101, 115, 104, 76, 105, 110,
				107, 0, 0, 0, 0, 30, 85, 110, 105, 116,
				121, 69, 110, 103, 105, 110, 101, 46, 65, 73,
				124, 78, 97, 118, 77, 101, 115, 104, 77, 111,
				100, 105, 102, 105, 101, 114, 0, 0, 0, 0,
				36, 85, 110, 105, 116, 121, 69, 110, 103, 105,
				110, 101, 46, 65, 73, 124, 78, 97, 118, 77,
				101, 115, 104, 77, 111, 100, 105, 102, 105, 101,
				114, 86, 111, 108, 117, 109, 101, 0, 0, 0,
				0, 29, 85, 110, 105, 116, 121, 69, 110, 103,
				105, 110, 101, 46, 65, 73, 124, 78, 97, 118,
				77, 101, 115, 104, 83, 117, 114, 102, 97, 99,
				101
			},
			TotalFiles = 4,
			TotalTypes = 4,
			IsEditorOnly = false
		};
	}
}
