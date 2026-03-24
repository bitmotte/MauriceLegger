using Interop.core;
using Interop.std;
using UnityEngine;

namespace Interop
{
	[SupportsInheritance]
	public struct AnimationState : AnimationState.Interface, IUpCastable<AnimationState>, TrackedReferenceBase.Interface, IUpCastable<TrackedReferenceBase>
	{
		public interface Interface : IUpCastable<AnimationState>, TrackedReferenceBase.Interface, IUpCastable<TrackedReferenceBase>
		{
		}

		[BaseField]
		private TrackedReferenceBase __TrackedReferenceBase;

		public unsafe AnimationCurveTpl<float>** m_Curves;

		public float m_Weight;

		public float m_WrappedTime;

		public double m_Time;

		public double m_LastGlobalTime;

		public int m_Layer;

		public float m_Speed;

		public float m_SyncedSpeed;

		public float m_StopTime;

		public float m_FadeOutLength;

		public float m_WeightTarget;

		public uint __bits;

		public int m_AnimationEventIndex;

		public uint m_DirtyMask;

		public WrapMode m_WrapMode;

		public int m_BlendMode;

		public float m_WeightDelta;

		public float m_UnstoppedLastWrappedTime;

		public float m_UnstoppedLastWeight;

		public Interop.std.pair<float, float> m_CachedRange;

		public unsafe AnimationClip* m_Clip;

		public ListNode<AnimationState> m_AnimationClipNode;

		public basic_string m_Name;

		public basic_string m_ParentName;

		public unsafe AnimationState* m_ParentState;

		[NativeTypeName("std::map<PPtr<Transform>, bool>")]
		public map<PPtr<Transform>, byte> m_MixingTransforms;

		unsafe ref AnimationState IUpCastable<AnimationState>.Cast()
		{
			return ref *(AnimationState*)null;
		}

		unsafe ref TrackedReferenceBase IUpCastable<TrackedReferenceBase>.Cast()
		{
			return ref *(TrackedReferenceBase*)null;
		}
	}
}
