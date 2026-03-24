using UnityEngine;

public class AudioCopyVolumeAndTime : MonoBehaviour
{
	public AudioSource target;

	private AudioSource aud;

	public bool copyTime;

	public bool copyVolume;

	public bool copyOnEnable;

	public bool copyOnUpdate;

	private bool volumeIsZero;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Match()
	{
	}
}
