using UnityEngine;

namespace Interop
{
	public struct AudioParameters
	{
		public AnimationCurveTpl<float> spatialBlendCustomCurve;

		public AnimationCurveTpl<float> reverbZoneMixCustomCurve;

		public AnimationCurveTpl<float> spreadCustomCurve;

		public AnimationCurveTpl<float> rolloffCustomCurve;

		public int priority;

		public float dopplerLevel;

		public float minDistance;

		public float maxDistance;

		public float pan;

		public float pitch;

		public float volume;

		[NativeTypeName("RolloffMode")]
		public AudioRolloffMode rolloffMode;

		[NativeTypeName("bool")]
		public byte loop;

		[NativeTypeName("bool")]
		public byte mute;

		[NativeTypeName("bool")]
		public byte spatialize;

		[NativeTypeName("bool")]
		public byte spatializePostEffects;

		[NativeTypeName("bool")]
		public byte bypassEffects;

		[NativeTypeName("bool")]
		public byte bypassListenerEffects;

		[NativeTypeName("bool")]
		public byte bypassReverbZones;

		[NativeTypeName("bool")]
		public byte ignoreListenerPause;
	}
}
