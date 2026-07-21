using System;
using System.Collections.Generic;

namespace UnityEngine.Animations.Rigging
{
}
namespace UnityEngine.Animations.Rigging
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Animation Rigging/Multi-Aim Constraint")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.animation.rigging@1.3/manual/constraints/MultiAimConstraint.html")]
	public class MultiAimConstraint : RigConstraint<MultiAimConstraintJob, MultiAimConstraintData, MultiAimConstraintJobBinder<MultiAimConstraintData>>
	{
		protected override void OnValidate()
		{
			base.OnValidate();
			WeightedTransformArray array = m_Data.sourceObjects;
			WeightedTransformArray array;
			WeightedTransformArray array;
			WeightedTransformArray.OnValidate(ref array);
			m_Data.sourceObjects = array;
			Vector2 limits = m_Data.limits;
			Vector2 limits;
			Vector2 limits;
			limits.x = Mathf.Clamp(limits.x, -180f, 180f);
			limits.y = Mathf.Clamp(limits.y, -180f, 180f);
			m_Data.limits = limits;
		}
	}
}
namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct MultiReferentialConstraintData : IAnimationJobData, IMultiReferentialConstraintData
	{
		[SyncSceneToStream]
		[SerializeField]
		private int m_Driver;

		[SyncSceneToStream]
		[SerializeField]
		private List<Transform> m_SourceObjects;

		public int driver
		{
			get
			{
				return m_Driver;
			}
			set
			{
				m_Driver = Mathf.Clamp(value, 0, m_SourceObjects.Count - 1);
			}
		}

		public List<Transform> sourceObjects
		{
			get
			{
				if (m_SourceObjects == null)
				{
					m_SourceObjects = new List<Transform>();
				}
				return m_SourceObjects;
			}
			set
			{
				m_SourceObjects = value;
				m_Driver = Mathf.Clamp(m_Driver, 0, m_SourceObjects.Count - 1);
			}
		}

		Transform[] IMultiReferentialConstraintData.sourceObjects => m_SourceObjects.ToArray();

		int IMultiReferentialConstraintData.driverValue => m_Driver;

		string IMultiReferentialConstraintData.driverIntProperty => ConstraintsUtils.ConstructConstraintDataPropertyName("m_Driver");

		bool IAnimationJobData.IsValid()
		{
			if (m_SourceObjects.Count < 2)
			{
				return false;
			}
			foreach (Transform sourceObject in m_SourceObjects)
			{
				if (sourceObject == null)
				{
					return false;
				}
			}
			return true;
		}

		void IAnimationJobData.SetDefaultValues()
		{
			m_Driver = 0;
			m_SourceObjects = new List<Transform>();
		}

		public void UpdateDriver()
		{
			m_Driver = Mathf.Clamp(m_Driver, 0, (m_SourceObjects != null) ? (m_SourceObjects.Count - 1) : 0);
		}
	}
}
