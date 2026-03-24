using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
[DefaultExecutionOrder(600)]
public class MusicManager : MonoSingleton<MusicManager>
{
	public bool off;

	public bool dontMatch;

	public bool useBossTheme;

	public AudioSource battleTheme;

	public AudioSource cleanTheme;

	public AudioSource bossTheme;

	public AudioSource targetTheme;

	private AudioSource[] allThemes;

	public float volume;

	public float requestedThemes;

	private bool arenaMode;

	private float defaultVolume;

	public float fadeSpeed;

	private float fadeOutSpeed;

	public bool forcedOff;

	private bool filtering;

	private bool falseStartToken;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void ForceStartBattleMusic()
	{
	}

	public void ForceStartMusic()
	{
	}

	public void StartMusic()
	{
	}

	public void PlayBattleMusic()
	{
	}

	public void PlayCleanMusic()
	{
	}

	public void PlayBossMusic()
	{
	}

	public void ArenaMusicStart(bool goIntoArenaMode = true)
	{
	}

	public void ArenaMusicEnd()
	{
	}

	public void ForceStopMusic()
	{
	}

	public void StopMusic()
	{
	}

	public void FadeOut(float newFadeoutSpeed)
	{
	}

	public void FilterMusic()
	{
	}

	public void UnfilterMusic()
	{
	}

	private void RemoveHighPass()
	{
	}

	public bool IsInBattle()
	{
		return false;
	}

	public void ChangeFadeSpeed(float speed)
	{
	}
}
