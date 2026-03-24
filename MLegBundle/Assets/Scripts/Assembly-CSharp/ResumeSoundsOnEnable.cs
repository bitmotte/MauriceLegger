using System.Collections.Generic;
using UnityEngine;

public class ResumeSoundsOnEnable : MonoBehaviour
{
	private sealed class TrackedInfo
	{
		private readonly AudioSource source;

		private AudioClip clip;

		private float time;

		private bool wasActive;

		public TrackedInfo(AudioSource source)
		{
		}

		public void Update(bool trackTime = false)
		{
		}

		private void Store()
		{
		}
	}

	private readonly Dictionary<AudioSource, TrackedInfo> trackedInfos;

	[SerializeField]
	private AudioSource[] audioSources;

	[SerializeField]
	private bool trackTime;

	private void Update()
	{
	}
}
