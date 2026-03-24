using Sandbox;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class Gutterman : EnemyScript, IEnrage, IAlter, IAlterOptions<bool>
{
	private bool gotValues;

	private EnemyIdentifier eid;

	private NavMeshAgent nma;

	private Enemy mach;

	private Rigidbody rb;

	private Animator anim;

	private int difficulty;

	private float defaultMovementSpeed;

	[HideInInspector]
	public bool dead;

	[HideInInspector]
	public bool fallen;

	[HideInInspector]
	public bool exploded;

	public bool hasShield;

	public bool stationary;

	[SerializeField]
	private GameObject[] shield;

	public Transform torsoAimBone;

	public Transform gunAimBone;

	private Quaternion torsoDefaultRotation;

	[SerializeField]
	private SwingCheck2 sc;

	[SerializeField]
	private SwingCheck2 shieldlessSwingcheck;

	private bool inAction;

	private bool attacking;

	private bool moveForward;

	private bool trackInAction;

	public Transform shootPoint;

	public GameObject beam;

	private float windup;

	private float windupSpeed;

	[SerializeField]
	private AudioSource windupAud;

	[SerializeField]
	private Transform windupBarrel;

	private Quaternion barrelRotation;

	private bool slowMode;

	private float slowModeLerp;

	private bool firing;

	private float bulletCooldown;

	private float lineOfSightTimer;

	private float trackingSpeed;

	private float trackingSpeedMultiplier;

	private float defaultTrackingSpeed;

	private Vector3 trackingPosition;

	private Vector3 lastKnownPosition;

	private TimeSince lastParried;

	[SerializeField]
	private GameObject playerUnstucker;

	[SerializeField]
	private GameObject fallingKillTrigger;

	[SerializeField]
	private GameObject fallEffect;

	[SerializeField]
	private GameObject corpseExplosion;

	[SerializeField]
	private GameObject shieldBreakEffect;

	[SerializeField]
	private AudioSource bonkSound;

	[SerializeField]
	private AudioSource releaseSound;

	[SerializeField]
	private AudioSource deathSound;

	private bool enraged;

	public bool eternalRage;

	[SerializeField]
	private AudioSource enrageEffect;

	private AudioSource currentEnrageEffect;

	private float rageLeft;

	private EnemySimplifier[] ensims;

	private TargetHandle targetHandle;

	private TargetData lastTargetData;

	private TargetHandle lastTargetHandle;

	private bool fallbackVision;

	private VisionQuery sightQuery;

	private Vision vision => null;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasVision => false;

	private float targetDistance => 0f;

	public bool isEnraged => false;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<bool>[] options => null;

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void OnTargetTeleport(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	private void Start()
	{
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	private void GetValues()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void CheckIfInstaCorpse()
	{
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	private void Update()
	{
	}

	private void AttackUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void VisionUpdate()
	{
	}

	private void SlowUpdate()
	{
	}

	private void NavigationUpdate()
	{
	}

	private void SetFiring()
	{
	}

	private bool FiringEnemyCheck(PhysicsCastResult hit)
	{
		return false;
	}

	private void Death()
	{
	}

	public void ShieldBreak(bool player = true, bool flash = true)
	{
	}

	private void ShieldBash()
	{
	}

	private void ShieldBashActive()
	{
	}

	private void ShieldBashStop()
	{
	}

	private void StopAction()
	{
	}

	public void GotParried()
	{
	}

	private void FallStart()
	{
	}

	private void FallOver()
	{
	}

	public void Explode()
	{
	}

	private void DoneDying()
	{
	}

	public void SetStationary(bool status)
	{
	}

	public void Enrage()
	{
	}

	public void UnEnrage()
	{
	}
}
