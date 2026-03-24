using System;
using ULTRAKILL.Enemy;
using UnityEngine;

public class EnemyShotgun : MonoBehaviour, IEnemyWeapon
{
	[Obsolete]
	private EnemyTarget target;

	private TargetData? targetData;

	public EnemyType safeEnemyType;

	private AudioSource gunAud;

	public AudioClip shootSound;

	public AudioClip clickSound;

	public AudioClip smackSound;

	private AudioSource heatSinkAud;

	public int variation;

	public GameObject bullet;

	public GameObject grenade;

	public float spread;

	private Animator anim;

	public bool gunReady;

	public Transform shootPoint;

	public GameObject muzzleFlash;

	private ParticleSystem[] parts;

	private bool charging;

	private AudioSource chargeSound;

	private float chargeAmount;

	public GameObject warningFlash;

	private int difficulty;

	private EnemyIdentifier eid;

	private float speedMultiplier;

	private float damageMultiplier;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[Obsolete]
	public void UpdateTarget(EnemyTarget target)
	{
	}

	public void UpdateTarget(TargetData? target)
	{
	}

	public void Fire(bool instantExplode = false)
	{
	}

	public void AltFire(bool instantExplode = false)
	{
	}

	public void PrepareFire()
	{
	}

	public void PrepareAltFire()
	{
	}

	public void CancelAltCharge()
	{
	}

	public void ReleaseHeat()
	{
	}

	public void ClickSound()
	{
	}

	public void ReadyGun()
	{
	}

	public void Smack()
	{
	}

	public void UpdateBuffs(EnemyIdentifier eid)
	{
	}
}
