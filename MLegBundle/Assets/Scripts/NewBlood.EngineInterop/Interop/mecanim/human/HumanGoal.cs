using Interop.math;
using UnityEngine;

namespace Interop.mecanim.human
{
	public struct HumanGoal
	{
		public trsX m_X;

		public float m_WeightT;

		public float m_WeightR;

		public unsafe fixed float __pad[2];

		[NativeTypeName("math::float3")]
		public Vector4 m_HintT;

		public float m_HintWeightT;

		public unsafe fixed float __pad1[3];
	}
}
