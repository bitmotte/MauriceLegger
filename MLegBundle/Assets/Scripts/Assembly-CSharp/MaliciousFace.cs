using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;
using plog;

public class MaliciousFace : EnemyScript
{
	private static readonly plog.Logger Log;

	[Header("Enemy Reference")]
	public Enemy spider;

	private EnemyIdentifier eid;

	private NavMeshAgent nma;

	private Animator anim;

	private Rigidbody rb;

	private AudioSource aud;

	private BloodsplatterManager bsm;

	private GoreZone gz;

	[Header("Combat")]
	public GameObject proj;

	public GameObject spark;

	public GameObject spiderBeam;

	public AssetReference beamExplosion;

	public AssetReference shockwave;

	[Header("Effects")]
	public GameObject breakParticle;

	public GameObject impactParticle;

	public GameObject impactSprite;

	public GameObject dripBlood;

	public GameObject chargeEffect;

	public GameObject enrageEffect;

	public AudioClip hurtSound;

	[Header("Configuration")]
	public bool spiderStationary;

	public float spiderTargetHeight;

	public Transform mouth;

	public Vector3 sparkRotationOffset;

	[SerializeField]
	private Transform headModel;

	[SerializeField]
	private Collider headCollider;

	public Renderer mainMesh;

	public GameObject legController;

	public GameObject[] legs;

	[Header("Materials")]
	private Material origMaterial;

	public Material woundedMaterial;

	public Material woundedEnrageMaterial;

	public GameObject woundedParticle;

	private bool readyToShoot;

	private float burstCharge;

	private int maxBurst;

	private int currentBurst;

	private float maxHealth;

	private float beamCharge;

	private bool chargeEnded;

	private float beamProbability;

	private int beamsAmount;

	private float coolDownMultiplier;

	private NavMeshPath tempPath;

	private bool spiderFalling;

	private bool spiderCorpseBroken;

	private float defaultSpiderHeight;

	private bool beamFiring;

	private bool isBeamPortalBlocked;

	private Quaternion predictedRot;

	private Quaternion followPlayerRot;

	private GameObject currentProj;

	private GameObject currentBeam;

	private GameObject currentExplosion;

	private GameObject currentCE;

	private GameObject currentDrip;

	private GameObject currentEnrageEffect;

	private AlwaysLookAtCamera currentEnrageAlac;

	private AudioSource ceAud;

	private Light ceLight;

	private Vector3 spritePos;

	private Quaternion spriteRot;

	private List<EnemyIdentifier> fallEnemiesHit;

	private TargetHandle targetHandle;

	private TargetHandle beamHandle;

	private TargetData lastTargetData;

	private VisionQuery visionQuery;

	private TargetData beamTargetData;

	private Vector3 beamMouthPos;

	private Quaternion beamMouthRot;

	private Vector3 lastDimensionalTarget;

	private MusicManager muman;

	private bool spiderRequestedMusic;

	private EnemySimplifier[] spiderEnsims;

	private int difficulty;

	private bool spiderParryable;

	private Vision vision => null;

	private PortalManagerV2 portalManager => null;

	private bool charging => false;

	private bool hasVision => false;

	private bool hasDimensionalTarget => false;

	public bool isEnraged { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	public override void OnParry(ref DamageData data, bool isShotgun)
	{
	}

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	private void VisionUpdate()
	{
	}

	private void SetBeamHeadRotation(TargetData targetData)
	{
	}

	private void SetFollowHeadRotation(Vector3 targetPosition)
	{
	}

	private void MovementUpdate()
	{
	}

	private void AttackCheck(TargetData targetData)
	{
	}

	private void BeamChargeUpdate()
	{
	}

	private void ShootProj(TargetData targetData)
	{
	}

	private void ChargeBeam(TargetData targetData)
	{
	}

	private void BeamChargeEnd()
	{
	}

	private void UpdateBeamMouth()
	{
	}

	private void BeamFire()
	{
	}

	private void StopWaiting()
	{
	}

	private void ReadyToShoot()
	{
	}

	public void Die(bool ignoreAlreadyDead = false)
	{
	}

	public void ProcessDeath()
	{
	}

	public void BreakCorpse()
	{
	}

	private void ResolveStuckness()
	{
	}

	public void TriggerHit(Collider other)
	{
	}

	private void FallKillEnemy(EnemyIdentifier targetEid)
	{
	}

	private void HandleCollision(Collision other)
	{
	}

	private void HandleSpiderDamage(ref DamageData data)
	{
	}

	public void Enrage()
	{
	}

	public void UnEnrage()
	{
	}

	public override bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}
}
