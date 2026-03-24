using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct TimeManager : TimeManager.Interface, IUpCastable<TimeManager>, GlobalGameManager.Interface, IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
	{
		public struct TimeHolder
		{
			public double m_CurFrameTime;

			public double m_LastFrameTime;

			public double m_CurFrameUnscaledTime;

			public float m_DeltaTime;

			public float m_UnscaledDeltaTime;

			public float m_SmoothDeltaTime;

			public float m_SmoothingWeight;

			public float m_InvDeltaTime;
		}

		public interface Interface : IUpCastable<TimeManager>, GlobalGameManager.Interface, IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private GlobalGameManager __GlobalGameManager;

		public TimeHolder m_FixedTime;

		public TimeHolder m_DynamicTime;

		public TimeHolder m_ActiveTime;

		[NativeTypeName("bool")]
		public byte m_FirstFrameAfterReset;

		[NativeTypeName("bool")]
		public byte m_FirstFrameAfterPause;

		[NativeTypeName("bool")]
		public byte m_FirstFixedFrameAfterReset;

		public long m_FrameCount;

		public int m_RenderFrameCount;

		public int m_CullFrameCount;

		public float m_CaptureDeltaTime;

		public double m_ZeroTime;

		public double m_RealZeroTime;

		public double m_SceneLoadOffset;

		[NativeTypeName("bool")]
		public byte m_SetTimeManually;

		[NativeTypeName("bool")]
		public byte m_UseFixedTimeStep;

		public float m_TimeScale;

		public float m_MaximumTimestep;

		public float m_MaximumParticleTimestep;

		public double m_LastSyncEnd;

		public unsafe fixed double m_FrameSyncEnds[100];

		unsafe ref TimeManager IUpCastable<TimeManager>.Cast()
		{
			return ref *(TimeManager*)null;
		}

		unsafe ref GlobalGameManager IUpCastable<GlobalGameManager>.Cast()
		{
			return ref *(GlobalGameManager*)null;
		}

		unsafe ref GameManager IUpCastable<GameManager>.Cast()
		{
			return ref *(GameManager*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
