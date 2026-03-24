using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class VirtualAudioListener : MonoBehaviour
{
	[SerializeField]
	private AudioListenerMode m_ListenerMode;

	[SerializeField]
	private Vector3 m_LastPosition;

	[SerializeField]
	private Vector3 m_Velocity;

	[SerializeField]
	private AudioVelocityUpdateMode m_VelocityUpdateMode;

	private int m_UpdateIndex;

	private readonly HashSet<VirtualAudioOutput> m_Outputs;

	internal int trackedIndex { get; set; }

	public IReadOnlyCollection<VirtualAudioOutput> outputs => null;

	public AudioListenerMode listenerMode
	{
		get
		{
			return default(AudioListenerMode);
		}
		set
		{
		}
	}

	public AudioVelocityUpdateMode velocityUpdateMode
	{
		get
		{
			return default(AudioVelocityUpdateMode);
		}
		set
		{
		}
	}

	public Vector3 lastPosition => default(Vector3);

	public Vector3 velocity => default(Vector3);

	public void AddOutput(VirtualAudioOutput output)
	{
	}

	public void UpdateCachedValues(int updateIndex)
	{
	}

	protected virtual void UpdateCachedValuesCore()
	{
	}

	public bool RemoveOutput(VirtualAudioOutput output)
	{
		return false;
	}

	public virtual Vector3 GetInputPosition(Vector3 position)
	{
		return default(Vector3);
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void DoUpdate()
	{
	}

	private void OnEnable()
	{
	}
}
