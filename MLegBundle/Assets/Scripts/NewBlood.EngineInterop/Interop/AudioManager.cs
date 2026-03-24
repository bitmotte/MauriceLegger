using System;
using Interop.audio.memory;
using Interop.audio.mixer;
using Interop.core;
using Interop.std;
using Microsoft.CodeAnalysis;

namespace Interop
{
	[NonCopyable]
	[SupportsInheritance]
	public struct AudioManager : AudioManager.Interface, IUpCastable<AudioManager>, GlobalGameManager.Interface, IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
	{
		[SupportsInheritance]
		public struct AudioScheduledSource : AudioScheduledSource.Interface, IUpCastable<AudioScheduledSource>, ListElement.Interface, IUpCastable<ListElement>
		{
			public interface Interface : IUpCastable<AudioScheduledSource>, ListElement.Interface, IUpCastable<ListElement>
			{
			}

			[BaseField]
			private ListElement __ListElement;

			public unsafe AudioSource* source;

			public double time;

			unsafe ref AudioScheduledSource IUpCastable<AudioScheduledSource>.Cast()
			{
				return ref *(AudioScheduledSource*)null;
			}

			unsafe ref ListElement IUpCastable<ListElement>.Cast()
			{
				return ref *(ListElement*)null;
			}
		}

		public struct DisposedMixerMemory
		{
			public unsafe AudioMixerMemory* m_Memory;

			public float m_TimeToDeletion;
		}

		[SupportsInheritance]
		public struct PlatformHook : PlatformHook.Interface, IUpCastable<PlatformHook>
		{
			public interface Interface : IUpCastable<PlatformHook>
			{
			}

			public unsafe void** __vftable;

			unsafe ref PlatformHook IUpCastable<PlatformHook>.Cast()
			{
				return ref *(PlatformHook*)null;
			}
		}

		public interface Interface : IUpCastable<AudioManager>, GlobalGameManager.Interface, IUpCastable<GlobalGameManager>, GameManager.Interface, IUpCastable<GameManager>, Object.Interface, IUpCastable<Object>
		{
		}

		[BaseField]
		private GlobalGameManager __GlobalGameManager;

		public Interop.core.vector<PlatformHook> m_PlatformHooks;

		public float m_DefaultVolume;

		public float m_Volume;

		public float m_Rolloffscale;

		[NativeTypeName("bool")]
		public byte m_IsPaused;

		[NativeTypeName("bool")]
		public byte m_IsApplicationPaused;

		[NativeTypeName("bool")]
		public byte m_ProfilingEnabled;

		[NativeTypeName("bool")]
		public byte m_HasPendingSetActiveOutputDriver;

		[NativeTypeName("FMOD_GUID *")]
		public unsafe Guid* m_PendingSetActiveOutputDriverGUID;

		public basic_string m_PendingSetActiveOutputDriverName;

		public List<ListNode<AudioSource>> m_Sources;

		public List<ListNode<AudioListener>> m_Listeners;

		public List<AudioScheduledSource> m_ScheduledSources;

		public List<ListNode<AudioMixer>> m_Mixers;

		public List<ListNode<AudioPlayableOutput>> m_AudioPlayableOutputs;

		[NativeTypeName("bool")]
		public byte m_AudioOutputStarted;

		public Mutex m_AudioOutputStartedMutex;

		public map<basic_string, int> m_MicrophoneNameToIDMap;

		public set<int> m_ActiveMicrophones;

		public float m_DopplerFactor;

		public List<ListNode<AudioReverbZone>> m_ReverbZones;

		[NativeTypeName("FMOD::System *")]
		public unsafe void* m_FMODSystem;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_ChannelGroup_FMODMaster;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_ChannelGroup_FX_IgnoreVolume;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_ChannelGroup_FX_UseVolume;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_ChannelGroup_NoFX_IgnoreVolume;

		[NativeTypeName("FMOD::ChannelGroup *")]
		public unsafe void* m_ChannelGroup_NoFX_UseVolume;

		[NativeTypeName("FMOD_CAPS")]
		public uint m_driverCaps;

		public FMOD_SPEAKERMODE m_speakerModeCaps;

		public FMOD_SPEAKERMODE m_speakerMode;

		public int m_SampleRate;

		public int m_DSPBufferSize;

		public int m_RequestedDSPBufferSize;

		public int m_PreviousRequestedDSPBufferSize;

		public int m_VirtualVoiceCount;

		public int m_RealVoiceCount;

		public basic_string m_SpatializerPlugin;

		public basic_string m_SpatializerPluginVerified;

		public basic_string m_AmbisonicDecoderPlugin;

		public basic_string m_AmbisonicDecoderPluginVerified;

		public UnityAudioSpatializerData m_SpatializerData;

		public FMOD_SPEAKERMODE m_activeSpeakerMode;

		public int m_activeSampleRate;

		public int m_activeDSPBufferSize;

		public int m_activeVirtualVoiceCount;

		public int m_activeRealVoiceCount;

		public basic_string m_LastErrorString;

		public FMOD_RESULT m_LastFMODErrorResult;

		public ulong m_accPausedTicks;

		public ulong m_pauseStartTicks;

		public int m_DefaultDSPBufferSize;

		public unsafe SoundManager* m_SoundManager;

		[NativeTypeName("bool")]
		public byte m_DisableFMOD;

		[NativeTypeName("bool")]
		public byte m_DisableAudio;

		[NativeTypeName("bool")]
		public byte m_VirtualizeEffects;

		[NativeTypeName("bool")]
		public byte m_PendingAudioConfigurationCallback;

		[NativeTypeName("bool")]
		public byte m_DeviceChanged;

		[NativeTypeName("bool")]
		public byte m_DeviceChangeNeedsReset;

		public int m_InvokeOnAudioConfigurationChangedRecursionDepth;

		[NativeTypeName("FMOD::DSP *")]
		public unsafe void* m_MasterDSP;

		public Interop.core.vector<Pointer<AudioEffectInternalDefinition>> m_AudioEffectInternalDefs;

		[NativeTypeName("FMOD_GUID")]
		public Guid m_DefaultRecordingDriver;

		[NativeTypeName("FMOD_GUID")]
		public Guid m_DefaultOutputDriver;

		[NativeTypeName("bool")]
		public byte m_AudioRenderer_Active;

		public double m_AudioRenderer_SamplesPending;

		public uint m_AudioRenderer_Handle;

		public uint m_AudioRenderer_PrevHandle;

		[NativeTypeName("FMOD::Output *")]
		public unsafe void* m_AudioRenderer_Output;

		[NativeTypeName("FMOD::Output *")]
		public unsafe void* m_AudioRenderer_PrevOutput;

		public FMOD_OUTPUTTYPE m_AudioRenderer_Type;

		public FMOD_OUTPUTTYPE m_AudioRenderer_PrevType;

		public HeapAllocator m_MixerAlloc;

		public Interop.core.vector<DisposedMixerMemory> m_DisposedMixerMemory;

		[NativeTypeName("AudioScriptBufferManager *")]
		public unsafe void* m_ScriptBufferManager;

		[NativeTypeName("bool")]
		public byte m_SentBeginMix;

		unsafe ref AudioManager IUpCastable<AudioManager>.Cast()
		{
			return ref *(AudioManager*)null;
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
