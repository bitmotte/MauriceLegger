using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[DisallowMultipleComponent]
[ConfigureSingleton(SingletonFlags.PersistAutoInstance)]
public sealed class VirtualAudioManager : MonoSingleton<VirtualAudioManager>
{
	[SerializeField]
	private AudioListener m_Listener;

	[SerializeField]
	private Vector3 m_LastListenerPosition;

	[SerializeField]
	private Vector3 m_ListenerVelocity;

	[Min(0f)]
	[SerializeField]
	private float m_DopplerFactor;

	private int m_UpdateCount;

	private NewMovement m_Player;

	private readonly List<VirtualAudioFilter> m_Sources;

	private readonly List<VirtualAudioListener> m_Listeners;

	private readonly HashSet<AudioSource> m_PlayOnAwake;

	public float dopplerFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3 lastListenerPosition => default(Vector3);

	public Vector3 listenerVelocity => default(Vector3);

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void DoUpdate(AudioVelocityUpdateMode velocityUpdateMode, int updateIndex)
	{
	}

	private void UpdateAudioListener(AudioListener listener, AudioVelocityUpdateMode velocityUpdateMode)
	{
	}

	private void UpdateListeners(int updateIndex)
	{
	}

	private void UpdateSources(AudioVelocityUpdateMode velocityUpdateMode, int updateIndex, AudioListener audioListener)
	{
	}

	private void UpdatePlayOnAwakeSources()
	{
	}

	public AudioListener GetAudioListener()
	{
		return null;
	}

	public static AudioVelocityUpdateMode GetAutomaticUpdateMode(GameObject gameObject)
	{
		return default(AudioVelocityUpdateMode);
	}

	public static Vector3 GetPositionDelta(Vector3 pos, Vector3 lastPosition)
	{
		return default(Vector3);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal void AddAudioListener(VirtualAudioListener listener)
	{
	}

	internal void AddAudioSource(AudioSource source)
	{
	}

	internal void AddAudioSource(VirtualAudioFilter filter)
	{
	}
}
