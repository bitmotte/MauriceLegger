namespace Interop
{
	public struct AnimationClipSettings
	{
		public PPtr<AnimationClip> m_AdditiveReferencePoseClip;

		public float m_AdditiveReferencePoseTime;

		public float m_StartTime;

		public float m_StopTime;

		public float m_OrientationOffsetY;

		public float m_Level;

		public float m_CycleOffset;

		[NativeTypeName("bool")]
		public byte m_HasAdditiveReferencePose;

		[NativeTypeName("bool")]
		public byte m_LoopTime;

		[NativeTypeName("bool")]
		public byte m_LoopBlend;

		[NativeTypeName("bool")]
		public byte m_LoopBlendOrientation;

		[NativeTypeName("bool")]
		public byte m_LoopBlendPositionY;

		[NativeTypeName("bool")]
		public byte m_LoopBlendPositionXZ;

		[NativeTypeName("bool")]
		public byte m_KeepOriginalOrientation;

		[NativeTypeName("bool")]
		public byte m_KeepOriginalPositionY;

		[NativeTypeName("bool")]
		public byte m_KeepOriginalPositionXZ;

		[NativeTypeName("bool")]
		public byte m_HeightFromFeet;

		[NativeTypeName("bool")]
		public byte m_Mirror;
	}
}
