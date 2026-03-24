using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class PowerVoiceController : MonoSingleton<PowerVoiceController>
{
	[SerializeField]
	private AudioClip[] intro;

	private int lastIntro;

	public TimeSince sinceLastIntro;

	[SerializeField]
	private AudioClip[] enrage;

	private int lastEnrage;

	[SerializeField]
	private AudioClip[] taunt;

	private int lastTaunt;

	[SerializeField]
	private AudioClip[] cheapShot;

	private int lastCheapShot;

	[SerializeField]
	private AudioClip[] hurt;

	private int lastHurt;

	[SerializeField]
	private AudioClip[] hurtBig;

	private int lastHurtBig;

	[SerializeField]
	private AudioClip[] death;

	private int lastDeath;

	[SerializeField]
	private AudioClip[] rapier;

	private int lastRapier;

	[SerializeField]
	private AudioClip[] greatsword;

	private int lastGreatsword;

	[SerializeField]
	private AudioClip[] spear;

	private int lastSpear;

	[SerializeField]
	private AudioClip[] spearThrow;

	private int lastSpearThrow;

	[SerializeField]
	private AudioClip[] glaive;

	private int lastGlaive;

	[SerializeField]
	private AudioClip[] glaiveThrow;

	private int lastGlaiveThrow;

	[SerializeField]
	private AudioClip fallScream;

	private void Awake()
	{
	}

	public AudioClip GetSound(AudioClip[] clips, int lastNumber, out int newNumber)
	{
		newNumber = default(int);
		return null;
	}

	public AudioClip Intro()
	{
		return null;
	}

	public AudioClip Enrage()
	{
		return null;
	}

	public AudioClip Taunt()
	{
		return null;
	}

	public AudioClip CheapShot()
	{
		return null;
	}

	public AudioClip Hurt()
	{
		return null;
	}

	public AudioClip HurtBig()
	{
		return null;
	}

	public AudioClip Death()
	{
		return null;
	}

	public AudioClip Rapier()
	{
		return null;
	}

	public AudioClip Greatsword()
	{
		return null;
	}

	public AudioClip Spear()
	{
		return null;
	}

	public AudioClip SpearThrow()
	{
		return null;
	}

	public AudioClip Glaive()
	{
		return null;
	}

	public AudioClip GlaiveThrow()
	{
		return null;
	}

	public AudioClip FallScream()
	{
		return null;
	}
}
