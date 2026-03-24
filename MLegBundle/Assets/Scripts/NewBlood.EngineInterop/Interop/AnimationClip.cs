using System;
using Interop.Unity;
using Interop.UnityEngine.Animation;
using Interop.core;
using Interop.mecanim.animation;
using Interop.mecanim.memory;
using Interop.std;
using Microsoft.CodeAnalysis;
using UnityEngine;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct AnimationClip : AnimationClip.Interface, IUpCastable<AnimationClip>, Motion.Interface, IUpCastable<Motion>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		public struct ChildTrack
		{
			public basic_string path;

			[NativeTypeName("Unity::Type const *")]
			public unsafe Interop.Unity.Type* type;

			public PPtr<BaseAnimationTrack> track;
		}

		[SupportsInheritance]
		public struct FloatCurve : FloatCurve.Interface, IUpCastable<FloatCurve>, EditorCurveBinding.Interface, IUpCastable<EditorCurveBinding>
		{
			public interface Interface : IUpCastable<FloatCurve>, EditorCurveBinding.Interface, IUpCastable<EditorCurveBinding>
			{
			}

			[BaseField]
			private EditorCurveBinding __EditorCurveBinding;

			public AnimationCurveTpl<float> curve;

			public int hash;

			unsafe ref FloatCurve IUpCastable<FloatCurve>.Cast()
			{
				return ref *(FloatCurve*)null;
			}

			unsafe ref EditorCurveBinding IUpCastable<EditorCurveBinding>.Cast()
			{
				return ref *(EditorCurveBinding*)null;
			}
		}

		[SupportsInheritance]
		public struct PPtrCurve : PPtrCurve.Interface, IUpCastable<PPtrCurve>, EditorCurveBinding.Interface, IUpCastable<EditorCurveBinding>
		{
			public interface Interface : IUpCastable<PPtrCurve>, EditorCurveBinding.Interface, IUpCastable<EditorCurveBinding>
			{
			}

			[BaseField]
			private EditorCurveBinding __EditorCurveBinding;

			public Interop.core.vector<PPtrKeyframe> curve;

			unsafe ref PPtrCurve IUpCastable<PPtrCurve>.Cast()
			{
				return ref *(PPtrCurve*)null;
			}

			unsafe ref EditorCurveBinding IUpCastable<EditorCurveBinding>.Cast()
			{
				return ref *(EditorCurveBinding*)null;
			}
		}

		public struct QuaternionCurve
		{
			public basic_string path;

			[NativeTypeName("AnimationCurveTpl<Quaternionf>")]
			public AnimationCurveTpl<Quaternion> curve;

			public int hash;
		}

		public struct Vector3Curve
		{
			public basic_string path;

			[NativeTypeName("AnimationCurveTpl<Vector3f>")]
			public AnimationCurveTpl<Vector3> curve;

			public int hash;
		}

		public interface Interface : IUpCastable<AnimationClip>, Motion.Interface, IUpCastable<Motion>, NamedObject.Interface, IUpCastable<NamedObject>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private Motion __Motion;

		public ChainedAllocator m_ClipAllocator;

		public List<ListNode<AnimationState>> m_AnimationStates;

		public float m_SampleRate;

		[NativeTypeName("bool")]
		public byte m_Compressed;

		[NativeTypeName("bool")]
		public byte m_UseHighQualityCurve;

		public WrapMode m_WrapMode;

		public Interop.core.vector<QuaternionCurve> m_QuaternionCurves;

		public Interop.core.vector<Vector3Curve> m_EulerCurves;

		public Interop.core.vector<Vector3Curve> m_PositionCurves;

		public Interop.core.vector<Vector3Curve> m_ScaleCurves;

		public Interop.core.vector<FloatCurve> m_FloatCurves;

		public Interop.core.vector<PPtrCurve> m_PPtrCurves;

		public Interop.core.vector<AnimationEvent> m_Events;

		[NativeTypeName("bool")]
		public byte m_Legacy;

		[NonSerialized]
		[NativeTypeName("bool")]
		public byte m_HasLowPrecisionIntCurves;

		public AnimationClipSettings m_AnimationClipSettings;

		[NativeTypeName("bool")]
		public byte m_HasGenericRootTransform;

		[NativeTypeName("bool")]
		public byte m_HasMotionFloatCurves;

		public unsafe ClipMuscleConstant* m_MuscleClip;

		public uint m_MuscleClipSize;

		public AnimationClipBindingConstant m_ClipBindingConstant;

		public Interop.std.pair<float, float> m_CachedRange;

		[NativeTypeName("AABB")]
		public Bounds m_Bounds;

		unsafe ref AnimationClip IUpCastable<AnimationClip>.Cast()
		{
			return ref *(AnimationClip*)null;
		}

		unsafe ref Motion IUpCastable<Motion>.Cast()
		{
			return ref *(Motion*)null;
		}

		unsafe ref NamedObject IUpCastable<NamedObject>.Cast()
		{
			return ref *(NamedObject*)null;
		}

		unsafe ref EditorExtension IUpCastable<EditorExtension>.Cast()
		{
			return ref *(EditorExtension*)null;
		}

		unsafe ref Object IUpCastable<Object>.Cast()
		{
			return ref *(Object*)null;
		}
	}
}
