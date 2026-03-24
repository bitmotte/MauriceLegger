using UnityEngine;

public static class AudioSourceExtensions
{
	public static void Play(this AudioSource @this, bool tracked)
	{
	}

	public static void PlayOneShot(this AudioSource @this, AudioClip clip, bool tracked)
	{
	}

	public static void PlayOneShot(this AudioSource @this, AudioClip clip, float volumeScale, bool tracked)
	{
	}

	public static void PlayScheduled(this AudioSource @this, double time, bool tracked)
	{
	}

	public static void PlayDelayed(this AudioSource @this, float delay, bool tracked)
	{
	}

	public static bool IsPaused(this AudioSource @this)
	{
		return false;
	}

	public static void SetPitch(this AudioSource @this, float pitch)
	{
	}

	public static float GetPitch(this AudioSource @this)
	{
		return 0f;
	}

	public static void SetPlayOnAwake(this AudioSource @this, bool playOnAwake)
	{
	}

	public static void SetSpatialBlend(this AudioSource @this, float spatialBlend)
	{
	}

	public static float GetSpatialBlend(this AudioSource @this)
	{
		return 0f;
	}
}
