using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class ZombieProjectiles : EnemyScript
{
	public bool stationary;

	public bool alwaysStationary;

	public bool smallRay;

	public bool wanderer;

	public bool afraid;

	public bool chaser;

	public bool hasMelee;

	public bool quickStart;

	private Enemy zmb;

	private GameObject player;

	private GameObject camObj;

	private NavMeshAgent nma;

	private Animator anim;

	private Rigidbody rb;

	private LayerMask lm;

	private float bodySize;

	private float coolDown;

	private AudioSource aud;

	public TrailRenderer tr;

	public GameObject projectile;

	public ContinuousBeam projectileBeam;

	private GameObject currentProjectile;

	private GameObject previousProjectile;

	public Transform shootPos;

	public GameObject head;

	public bool targetSpotted;

	private RaycastHit rhit;

	private NavMeshPath tempPath;

	private Vector3 wanderTarget;

	private float raySize;

	private bool musicRequested;

	public GameObject decProjectileSpawner;

	public GameObject decProjectile;

	private GameObject currentDecProjectile;

	public bool swinging;

	[HideInInspector]
	public bool blocking;

	private int _difficulty;

	private float coolDownReduce;

	private EnemyIdentifier eid;

	private GameObject origWP;

	public Transform aimer;

	private Quaternion aimerDefaultRotation;

	private bool aiming;

	private Quaternion origRotation;

	private float aimEase;

	private Vector3 predictedPosition;

	private float predictionLerp;

	private bool predictionLerping;

	private bool moveForward;

	private float forwardSpeed;

	private SwingCheck2[] swingChecks;

	private float fleeStopDuration;

	private bool isFleeingPlayer;

	private bool isWandering;

	private Vector3 spawnPos;

	private bool valuesSet;

	public bool shouldSortie;

	public Vector3 sortiePos;

	private VisionQuery visionQuery;

	private TargetData lastTargetData;

	private TargetHandle targetHandle;

	private Vector3 lastDimensionalTarget;

	private Vision vision => null;

	[HideInInspector]
	public int difficulty
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasVision => false;

	private bool isVisionThroughPortal => false;

	private float targetDistance => 0f;

	public float shootRange => 0f;

	public bool inShootRange => false;

	public bool inMeleeRange => false;

	public bool inFleeRange => false;

	private bool hasDimensionalTarget => false;

	public override void SetSortiePos(Vector3 pos)
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnFall()
	{
	}

	private void Awake()
	{
	}

	private void SetValues()
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

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	private void SlowUpdate()
	{
	}

	private void Flee()
	{
	}

	private void AttackCheck(bool isPlayerPathable)
	{
	}

	private void Navigate(bool isPlayerPathable)
	{
	}

	private void Update()
	{
	}

	private void VisionUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private float GetFixedUpdateMaxDistance(TargetHandle handle)
	{
		return 0f;
	}

	public void MoveForward(float speed)
	{
	}

	private void StopMoveForward()
	{
	}

	public void Melee()
	{
	}

	public void MeleePrep()
	{
	}

	public void MeleeDamageStart()
	{
	}

	public void MeleeDamageEnd()
	{
	}

	public void Swing()
	{
	}

	public void SwingEnd()
	{
	}

	public void SpawnProjectile()
	{
	}

	public void DamageStart()
	{
	}

	public void ThrowProjectile()
	{
	}

	public void ShootProjectile(int skipOnEasy)
	{
	}

	public void StopTracking()
	{
	}

	public void DamageEnd()
	{
	}

	public void CancelAttack()
	{
	}

	private void Wander()
	{
	}

	public void Block(Vector3 attackPosition)
	{
	}
}
