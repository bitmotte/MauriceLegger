using Interop.math;
using Interop.mecanim.hand;
using UnityEngine;

namespace Interop.mecanim.human
{
	public struct HumanPose
	{
		public trsX m_RootX;

		[NativeTypeName("math::float3")]
		public Vector4 m_LookAtPosition;

		[NativeTypeName("math::float4")]
		public Vector4 m_LookAtWeight;

		public InlineArray4<HumanGoal> m_GoalArray;

		public HandPose m_LeftHandPose;

		public HandPose m_RightHandPose;

		public unsafe fixed float m_DoFArray[55];

		public float __pad;

		[NativeTypeName("math::float3[21]")]
		public InlineArray21<Vector4> m_TDoFArray;
	}
}
