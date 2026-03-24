using Interop.math;
using Interop.mecanim.human;
using UnityEngine;

namespace Interop.mecanim.animation
{
	public struct ClipMuscleConstant
	{
		public Interop.mecanim.human.HumanPose m_DeltaPose;

		public trsX m_StartX;

		public trsX m_StopX;

		public trsX m_LeftFootStartX;

		public trsX m_RightFootStartX;

		[NativeTypeName("math::float3")]
		public Vector4 m_AverageSpeed;

		public OffsetPtr<Clip> m_Clip;

		public float m_StartTime;

		public float m_StopTime;

		public float m_OrientationOffsetY;

		public float m_Level;

		public float m_CycleOffset;

		public float m_AverageAngularSpeed;

		public unsafe fixed int m_IndexArray[200];

		public uint m_IndexArrayCount;

		public OffsetPtr<ValueDelta> m_ValueArrayDelta;

		public uint m_ValueArrayReferencePoseCount;

		public OffsetPtr<float> m_ValueArrayReferencePose;

		public byte m_Mirror;

		public byte m_LoopTime;

		public byte m_LoopBlend;

		public byte m_LoopBlendOrientation;

		public byte m_LoopBlendPositionY;

		public byte m_LoopBlendPositionXZ;

		public byte m_StartAtOrigin;

		public byte m_KeepOriginalOrientation;

		public byte m_KeepOriginalPositionY;

		public byte m_KeepOriginalPositionXZ;

		public byte m_HeightFromFeet;
	}
}
