using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Drone : EnemyScript
{
	private Enemy enemy;

	private EnemyIdentifier eid;

	private Rigidbody rb;

	private Animator anim;

	private AudioSource aud;

	private BloodsplatterManager bsm;

	private GoreZone gz;

	private KeepInBounds kib;

	[Header("Movement")]
	public bool stationary;

	public bool lockRotation;

	public bool lockPosition;

	public float preferredDistanceToTarget;

	[Header("Combat")]
	public AssetReference projectile;

	public Material shootMaterial;

	public AssetReference explosion;

	public AssetReference gib;

	public ParticleSystem chargeParticle;

	public AudioClip windUpSound;

	public AudioClip spotSound;

	public AudioClip loseSound;

	public AudioClip hurtSound;

	public AudioClip deathSound;

	public AudioClip dodgeSound;

	public AudioClip[] windUpSounds;

	public bool cantInstaExplode;

	public bool dontStartAware;

	public bool fleshDrone;

	public GameObject ghost;

	public GameObject enrageEffect;

	[HideInInspector]
	public GameObject currentEnrageEffect;

	[Header("Providence")]
	public bool instaready;

	public bool semiStationary;

	public float secondaryChance;

	public AssetReference secondaryProjectile;

	public AudioClip secondaryWindupSound;

	public AssetReference[] spawnOnDeath;

	[SerializeField]
	private Transform[] rotatorWings;

	[HideInInspector]
	public List<VirtueInsignia> childVi;

	[HideInInspector]
	public float currentSecondaryChance;

	private Vector3 crashTarget;

	private bool canInterruptCrash;

	private Transform modelTransform;

	private bool toLastKnownPos;

	private Vector3 lastKnownPos;

	private float checkCooldown;

	private float blockCooldown;

	private float dodgeCooldown;

	private float attackCooldown;

	private bool killedByPlayer;

	private bool parried;

	private bool exploded;

	private Vector3 viewTarget;

	private int usedAttacks;

	private EnemyCooldowns vc;

	private bool checkingForCrash;

	private bool canHurtOtherDrones;

	private bool hooked;

	private bool homeRunnable;

	private bool returnToStartPosition;

	private Vector3 startPosition;

	private float droneWingRotationSpeed;

	private float droneCurrentRotation;

	private Quaternion[] rotatorWingsDefaultRotation;

	private Material origMaterial;

	private int difficulty;

	private TimeSince sinceParryable;

	private TargetHandle droneTargetHandle;

	private VisionQuery droneTargetQuery;

	private TargetData droneTargetData;

	private int droneVisionMask;

	private Vector3 lastDimensionalTarget;

	public Enemy Enemy => null;

	private Vision vision => null;

	private PortalManagerV2 portalManager => null;

	public bool crashing { get; private set; }

	public bool targetSpotted { get; private set; }

	public bool isEnraged { get; private set; }

	private bool hasDroneVision => false;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasDimensionalTarget => false;

	private bool hasAnyTarget => false;

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTargetTeleport(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void Update()
	{
	}

	public bool CanBeHooked()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	public void GetHurt(Vector3 force, float multiplier, GameObject sourceWeapon = null, bool fromExplosion = false)
	{
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	private void UpdateRigidbodySettings()
	{
	}

	private int GetSightBlockMask(bool isPlayer)
	{
		return 0;
	}

	private float GetCooldownSpeed()
	{
		return 0f;
	}

	private bool ShouldProcessAttack()
	{
		return false;
	}

	private bool ObstructionCheck(TargetDataRef data)
	{
		return false;
	}

	private bool ObstructionCheck(TargetData data)
	{
		return false;
	}

	private void ProcessAttack()
	{
	}

	private void ProcessCrashing()
	{
	}

	private void ProcessTargeting()
	{
	}

	private void ProcessSearching()
	{
	}

	private void SightCheck()
	{
	}

	private void TargetLost()
	{
	}

	public void RandomDodge(bool force = false)
	{
	}

	public void Dodge()
	{
	}

	public void Dodge(Vector3 direction)
	{
	}

	public void PlaySound(AudioClip clip)
	{
	}

	private void PrepShoot()
	{
	}

	public void Shoot()
	{
	}

	public void ShootSecondary()
	{
	}

	public void PincerFired()
	{
	}

	private void SetProjectileSettings(Projectile proj)
	{
	}

	public void SpawnDroneInsignia()
	{
	}

	private void HandleCollisionWithEnemy(Collider other)
	{
	}

	public void Explode()
	{
	}

	public void Death(bool fromExplosion = false)
	{
	}

	private void CanInterruptCrash()
	{
	}

	public void Hooked()
	{
	}

	public void Unhooked()
	{
	}

	private void DelayedUnhooked()
	{
	}

	private void NoMoreHomeRun()
	{
	}

	public void Enrage()
	{
	}

	public void UnEnrage()
	{
	}

	private void ApproveNewPosition()
	{
	}
}
