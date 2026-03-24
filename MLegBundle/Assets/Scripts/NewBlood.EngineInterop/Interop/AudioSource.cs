using Interop.Unity;
using Interop.core;
using Microsoft.CodeAnalysis;
using UnityEngine;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct AudioSource : AudioSource.Interface, IUpCastable<AudioSource>, AudioBehaviour.Interface, IUpCastable<AudioBehaviour>, Behaviour.Interface, IUpCastable<Behaviour>, Interop.Unity.Component.Interface, IUpCastable<Interop.Unity.Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
	{
		[SupportsInheritance]
		public struct OneShot : OneShot.Interface, IUpCastable<OneShot>, ListNode<OneShot>.Interface, IUpCastable<ListNode<OneShot>>, ListElement.Interface, IUpCastable<ListElement>
		{
			public interface Interface : IUpCastable<OneShot>, ListNode<OneShot>.Interface, IUpCastable<ListNode<OneShot>>, ListElement.Interface, IUpCastable<ListElement>
			{
			}

			[BaseField]
			private ListNode<OneShot> __ListNode;

			public SoundChannel channel;

			public PPtr<AudioClip> audioClip;

			unsafe ref OneShot IUpCastable<OneShot>.Cast()
			{
				return ref *(OneShot*)null;
			}

			unsafe ref ListNode<OneShot> IUpCastable<ListNode<OneShot>>.Cast()
			{
				return ref *(ListNode<OneShot>*)null;
			}

			unsafe ref ListElement IUpCastable<ListElement>.Cast()
			{
				return ref *(ListElement*)null;
			}
		}

		public struct ParameterCache
		{
			[NativeTypeName("Vector3f")]
			public Vector3 position;

			[NativeTypeName("Vector3f")]
			public Vector3 velocity;

			public float distance;

			[NativeTypeName("Vector3f")]
			public Vector3 relativeListenerVelocity;

			[NativeTypeName("Vector3f")]
			public Vector3 relativeSoundDirection;

			public float spatialBlendLevel;

			public float spread;

			public float stereoPan;

			public float minDistance;

			public float maxDistance;

			public float reverbZoneMix;

			public int reverbZoneRoom;

			public float dopplerPitch;

			public float dopplerLevel;

			[NativeTypeName("Matrix4x4f")]
			public Matrix4x4 sourceMatrix;

			[NativeTypeName("Matrix4x4f")]
			public Matrix4x4 listenerMatrix;

			public int speakerCount;

			public float distanceAttenuation;

			public float volume;

			[NativeTypeName("bool")]
			public byte mute;

			public int priority;
		}

		public interface Interface : IUpCastable<AudioSource>, AudioBehaviour.Interface, IUpCastable<AudioBehaviour>, Behaviour.Interface, IUpCastable<Behaviour>, Interop.Unity.Component.Interface, IUpCastable<Interop.Unity.Component>, EditorExtension.Interface, IUpCastable<EditorExtension>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private AudioBehaviour __AudioBehaviour;

		public AudioParameters m_AudioParameters;

		public ParameterCache m_ParameterCache;

		public vector<SoundChannel> m_CachedSoundChannels;

		public List<OneShot> m_OneShots;

		[NativeTypeName("bool")]
		public byte m_FiltersDirty;

		[NativeTypeName("FMOD::DSPConnection *")]
		public unsafe void* m_DspCon;

		public PPtr<AudioClip> m_AudioClip;

		public PPtr<AudioMixerGroup> m_OutputAudioMixerGroup;

		public ListNode<AudioSource> m_Node;

		public SoundChannel m_Channel;

		public AudioManager.AudioScheduledSource m_ScheduledSource;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_dryGroup;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_wetGroup;

		[NativeTypeName("bool")]
		public byte m_IgnoreListenerVolume;

		[NativeTypeName("bool")]
		public byte m_PlayOnAwake;

		[NativeTypeName("bool")]
		public byte m_HasDeferredPlayOnAwake;

		[NativeTypeName("bool")]
		public byte m_HasScheduledStartDelay;

		[NativeTypeName("bool")]
		public byte m_HasScheduledEndDelay;

		[NativeTypeName("bool")]
		public byte m_PlayingViaExternal;

		public int m_VelocityUpdateMode;

		public ulong m_PauseStartClock;

		public uint m_samplePosition;

		[NativeTypeName("bool")]
		public byte m_pause;

		[NativeTypeName("bool")]
		public byte m_LastVirtualState;

		public unsafe AudioCustomFilter* m_PlayingCustomFilter;

		[NativeTypeName("FMOD::DSP *")]
		public unsafe void* m_SpatializerDSP;

		public unsafe UnityAudioSpatializerData* m_SpatializerData;

		public unsafe UnityAudioAmbisonicDataInternal* m_AmbisonicData;

		[NativeTypeName("core::vector<FMOD::DSP *>")]
		public vector<Pointer> m_FilterCache;

		public vector<SoundChannel> m_ProviderChannels;

		[NativeTypeName("bool")]
		public byte m_DoLegacy3DTransfer;

		unsafe ref AudioSource IUpCastable<AudioSource>.Cast()
		{
			return ref *(AudioSource*)null;
		}

		unsafe ref AudioBehaviour IUpCastable<AudioBehaviour>.Cast()
		{
			return ref *(AudioBehaviour*)null;
		}

		unsafe ref Behaviour IUpCastable<Behaviour>.Cast()
		{
			return ref *(Behaviour*)null;
		}

		unsafe ref Interop.Unity.Component IUpCastable<Interop.Unity.Component>.Cast()
		{
			return ref *(Interop.Unity.Component*)null;
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
