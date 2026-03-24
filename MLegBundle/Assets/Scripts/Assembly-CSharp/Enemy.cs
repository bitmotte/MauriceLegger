using System.Collections.Generic;
using System.Threading;
using Sandbox;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Enemy : MonoBehaviour, IAlter, IAlterOptions<float>, ITarget, IPortalTraveller
{
	public struct EnemyPortalLinkTraversalData
	{
		public OffMeshLinkData data;

		public PortalHandle portalHandle;

		public bool wasOnLink;

		public float waitTimer;

		public bool hasCrossed;

		public bool startUpdateRotation;

		public bool startUpdatePosition;

		public bool startAutoTraverseOffMeshLink;

		public bool startUseGravity;

		public Vector3 startNavDestination;

		public Vector3 endSpiderOffset;

		public Vector3 portalPos;

		public Vector3 portalTargetPos;

		public Matrix4x4 startEnterToExitMatrix;

		public Vector3 startPortalTargetExitPos;

		public Vector3 startPortalTargetEnterLocalPos;

		public bool hasWarped;

		public Vector3 linkEndPos;

		public readonly bool isWaitExceeded => false;

		public readonly bool isTraversing => false;

		public void Reset()
		{
		}

		public readonly float GetExitPosDisplacement(PortalTransform currentTransform, Matrix4x4 currentEnterToExit)
		{
			return 0f;
		}

		public readonly float GetEntryPosDisplacement(PortalTransform currentTransform)
		{
			return 0f;
		}
	}

	private static readonly int RunSpeed;

	private static readonly RaycastHit[] ReusableRaycastHits;

	[Header("Enemy Type")]
	public bool isZombie;

	public bool isStatue;

	public bool isMachine;

	public bool isSpider;

	public bool isDrone;

	[Header("Combat")]
	public float health;

	public bool noFallDamage;

	public bool dontDie;

	public bool specialDeath;

	public bool simpleDeath;

	public bool dismemberment;

	[HideInInspector]
	public float originalHealth;

	public bool limp;

	public bool grounded;

	public bool knockedBack;

	public bool falling;

	public float fallTime;

	public float brakes;

	public float juggleWeight;

	public int parryFramesLeft;

	public bool parryable;

	public bool partiallyParryable;

	[HideInInspector]
	public List<Transform> parryables;

	protected bool parryFramesOnPartial;

	public bool isMassDeath;

	public bool isMassDieing;

	[Header("Audio")]
	public AudioClip hurtSound;

	public AudioClip[] hurtSounds;

	public float hurtSoundVol;

	public AudioClip deathSound;

	public float deathSoundVol;

	public AudioClip scream;

	protected AudioSource aud;

	[Header("References")]
	public GameObject chest;

	public Transform bodyCenter;

	public Transform rotationTransform;

	public SkinnedMeshRenderer smr;

	public GoreZone gz;

	public Transform hitJiggleRoot;

	public Enemy symbiote;

	protected EnemyScript script;

	protected EnemyIdentifier eid;

	public BloodsplatterManager bsm;

	[HideInInspector]
	public NavMeshAgent nma;

	protected Rigidbody rb;

	protected Rigidbody[] rbs;

	[HideInInspector]
	public Animator anim;

	[HideInInspector]
	public GroundCheckEnemy gc;

	[HideInInspector]
	public StyleCalculator scalc;

	private ActivateNextWave anw;

	[Header("Materials")]
	public Material deadMaterial;

	public Material woundedMaterial;

	public Material woundedEnrageMaterial;

	protected Material originalMaterial;

	[Header("Effects")]
	public GameObject woundedParticle;

	public GameObject woundedModel;

	public GameObject enrageEffect;

	[HideInInspector]
	public GameObject currentEnrageEffect;

	public GameObject[] destroyOnDeath;

	[Header("Enemy Settings")]
	public bool bigKill;

	public bool thickLimbs;

	public bool overrideFalling;

	protected bool symbiotic;

	protected bool healing;

	protected Vector3 jiggleRootPosition;

	public List<GameObject> extraDamageZones;

	public float extraDamageMultiplier;

	public bool bigBlood;

	public readonly List<Transform> transforms;

	protected bool affectedByGravity;

	public bool variableSpeed;

	public bool stopped;

	public bool isOnOffNavmeshLink;

	public bool chestExploding;

	protected bool chestExploded;

	protected bool attacking;

	protected float defaultSpeed;

	protected float speedMultiplier;

	private float maxFallSpeed;

	private float terminalVelocityTimer;

	[HideInInspector]
	public GameObject currentTerminalVelocityEffect;

	protected float chestHP;

	protected bool noheal;

	protected float fallSpeed;

	protected float knockBackCharge;

	protected int difficulty;

	public LayerMask lmask;

	public LayerMask lmaskEnv;

	public LayerMask lmaskWater;

	protected float reduceFallTime;

	[Header("Events")]
	public UnityEvent onDeath;

	[HideInInspector]
	public ParryChallenge parryChallenge;

	public Vision vision;

	public TimeSince lastTargetTick;

	[HideInInspector]
	public bool musicRequested;

	public CancellationTokenSource deathTokenSource;

	private Vector3 origPos;

	private Vector3 cachedPos;

	private Vector3 cachedHeadPos;

	private Quaternion cachedRot;

	private Vector3 cachedVel;

	private EnemyPortalLinkTraversalData portalLinkData;

	public Quaternion postPortalOffsetRot;

	private float postPortalDuration;

	private float postPortalTimer;

	private bool postPortalRotationByCenter;

	protected SwordsMachine sm => null;

	public Streetcleaner sc => null;

	protected V2 v2 => null;

	protected Mindflayer mf => null;

	protected Sisyphus sisy => null;

	protected Turret tur => null;

	protected Mannequin man => null;

	protected Minotaur min => null;

	protected Mass mass => null;

	protected Drone drone => null;

	protected Ferryman fm => null;

	protected Power pwr => null;

	public bool isEnraged { get; private set; }

	private PortalManagerV2 portalManager => null;

	private TargetTracker targetTracker => null;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<float>[] options => null;

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	public int id => 0;

	public int? targetId => null;

	public Vector3 lastPos { get; set; }

	public Vector3 travellerPosition => default(Vector3);

	public Vector3 travellerVelocity => default(Vector3);

	public PortalTravellerType travellerType => default(PortalTravellerType);

	public bool isTraversingPortalLink => false;

	public bool IsZombie()
	{
		return false;
	}

	public bool IsStatue()
	{
		return false;
	}

	public bool IsMachine()
	{
		return false;
	}

	public bool IsSpider()
	{
		return false;
	}

	public bool IsDrone()
	{
		return false;
	}

	public float GetSplatVelocity()
	{
		return 0f;
	}

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	protected void OnEnable()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void FixedUpdate()
	{
	}

	protected void OnDestroy()
	{
	}

	public void SyncVision()
	{
	}

	public Vector3 GetVisionPos()
	{
		return default(Vector3);
	}

	public VisionTypeFilter GetVisionFilter()
	{
		return default(VisionTypeFilter);
	}

	private void ValidateNavState()
	{
	}

	public bool TryGetDimensionalTarget(Vector3 targetPosition, out Vector3 dimensionalTargetPosition)
	{
		dimensionalTargetPosition = default(Vector3);
		return false;
	}

	public bool DefaultVisionCheck(TargetData data)
	{
		return false;
	}

	private void UpdateGroundedState(bool hasGc, bool hasNma, bool hasAnim)
	{
	}

	private bool CanFall()
	{
		return false;
	}

	private void StartFalling()
	{
	}

	private void UpdateFalling()
	{
	}

	private void UpdateFallingState(bool hasGc, bool hasNma, bool hasRb, bool hasAnim)
	{
	}

	private void ResetFallingState()
	{
	}

	private void HandleFallingSound()
	{
	}

	private void HandleLanding()
	{
	}

	private bool ShouldSplat()
	{
		return false;
	}

	private void HandleMassDeath()
	{
	}

	public void BloodExplosion()
	{
	}

	protected void DeathEnd()
	{
	}

	public void SetDestination(Vector3 position)
	{
	}

	protected virtual void SetSpeed()
	{
	}

	private void ConfigureSpeed()
	{
	}

	private void ApplySpeedModifiers()
	{
	}

	protected void UpdateBuff()
	{
	}

	public void Jump(Vector3 vector)
	{
	}

	public void Jumped()
	{
	}

	private bool CanBeKnockedBack()
	{
		return false;
	}

	public void KnockBack(Vector3 force)
	{
	}

	private void UpdateKnockback()
	{
	}

	public void StopKnockBack()
	{
	}

	private void HandleBraking()
	{
	}

	public virtual void GetHurt(GameObject target, Vector3 force, float multiplier, float critMultiplier, Vector3 hurtPos = default(Vector3), GameObject sourceWeapon = null, bool fromExplosion = false)
	{
	}

	private float CalculateDamage(float multiplier, float limbMultiplier, float critMultiplier, GameObject target, ref bool extraDamageZone)
	{
		return 0f;
	}

	private float CalculateLimbMultiplier(GameObject target)
	{
		return 0f;
	}

	private string DetermineLimbType(GameObject target)
	{
		return null;
	}

	private void PlayHurtSound()
	{
	}

	public void ReadyGib(GameObject tempGib, GameObject target)
	{
	}

	private GameObject HandleBloodSelection(GameObject target, float damage, bool fromExplosion, bool extraDamageZone)
	{
		return null;
	}

	private void ProcessBloodEffects(GameObject blood, GameObject target, Vector3 hurtPos)
	{
	}

	private void ApplyWoundedEffect(float healthBeforeDamage)
	{
	}

	private void DismemberLimb(GameObject target)
	{
	}

	private void HandleDismemberment(GameObject target, float damage, bool fromExplosion)
	{
	}

	private void HandleChestExplosionDismemberment(EnemyIdentifierIdentifier eii, float damage, bool fromExplosion)
	{
	}

	public void GoLimp()
	{
	}

	public void GoLimp(bool fromExplosion)
	{
	}

	private void HideDestroyOnDeathObjects()
	{
	}

	public void CountDeath()
	{
	}

	private void SimplifyEnemyModels()
	{
	}

	private void ApplyDeadMaterial()
	{
	}

	private void NotifyDeathToComponents()
	{
	}

	private void CreateDeathExplosion()
	{
	}

	private void HandleDeath(GameObject target, Vector3 force, bool fromExplosion, float damage)
	{
	}

	private void HandleStandardDeath()
	{
	}

	private void HandleSymbioteDeath(bool fromExplosion)
	{
	}

	private void SpawnGibsOnDeath(GameObject target, bool fromExplosion)
	{
	}

	private void PlayDeathSound()
	{
	}

	protected void StartHealing()
	{
	}

	protected void StopHealing()
	{
	}

	private void SendStyleInformation(string hitLimb, bool killed, GameObject sourceWeapon)
	{
	}

	private string DetermineEnemyTypeForStyleCalculation()
	{
		return null;
	}

	private void HandleParrying(ref DamageData data)
	{
	}

	public virtual void ParryableCheck(bool partial = false)
	{
	}

	private void HandleMachineSpecialCases(GameObject target, Vector3 force, bool fromExplosion, ref DamageData data)
	{
	}

	private void UpdateMachineHealing()
	{
	}

	private void UpdateJiggleBone()
	{
	}

	public virtual void Cut(GameObject target)
	{
	}

	public virtual void ChestExplosion(bool cut = false, bool fromExplosion = false)
	{
	}

	public virtual void ChestExplodeEnd()
	{
	}

	private void HandleMassSpear(GameObject target, float damage, bool fromExplosion)
	{
	}

	public static int InitializeDifficulty(EnemyIdentifier eid)
	{
		return 0;
	}

	private void SetupLayerMasks()
	{
	}

	public GoreZone GetGoreZone()
	{
		return null;
	}

	public bool IsLedgeSafe()
	{
		return false;
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}

	public bool? OnTravel(PortalTravelDetails details)
	{
		return null;
	}

	public void OnTeleportBlocked(PortalTravelDetails details)
	{
	}

	private void HandlePortalLinkTraversal(bool hasNma)
	{
	}

	private bool CheckLinkTraversalEntryPos(Portal portal, PortalSide side, Vector3 worldIntersect, float margin, float distToPlane)
	{
		return false;
	}

	private void AbortLinkTraversal(bool warpPosition = true)
	{
	}

	private void CompleteLinkTraversal(bool warpPosition = false, bool resetPath = false)
	{
	}

	private void DelayedGroundCheckReenable()
	{
	}

	private void ApplyOffsetRotation()
	{
	}

	private void UpdatePostPortalRotation()
	{
	}

	private void ResetPortalOffsetRotation()
	{
	}
}
