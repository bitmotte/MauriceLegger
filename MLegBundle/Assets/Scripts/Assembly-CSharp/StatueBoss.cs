using Sandbox;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;

public class StatueBoss : EnemyScript, IEnrage, IAlter, IAlterOptions<bool>
{
	private Animator anim;

	private NavMeshAgent nma;

	private NavMeshPath nmp;

	private CameraController cc;

	private Rigidbody rb;

	[HideInInspector]
	public bool inAction;

	public bool stationary;

	public Transform stompPos;

	public AssetReference stompWave;

	private bool tracking;

	private bool dashing;

	private float dashPower;

	private GameObject currentStompWave;

	private float meleeRecharge;

	private float playerInCloseRange;

	private bool dontFall;

	[HideInInspector]
	public bool damaging;

	[HideInInspector]
	public bool launching;

	[HideInInspector]
	public int damage;

	private int tackleChance;

	private int extraTackles;

	private float rangedRecharge;

	private int throwChance;

	public float attackCheckCooldown;

	private TargetHandle targetHandle;

	private TargetData lastTargetData;

	private VisionQuery targetQuery;

	private Vector3 targetPlanePos;

	private Vector3 predictedRealTargetPosition;

	private Vector3 predictedTargetPosition;

	private Vector3 lastDimensionalTarget;

	public AssetReference orbProjectile;

	private Light orbLight;

	private bool orbGrowing;

	public GameObject stepSound;

	private ParticleSystem part;

	private AudioSource partAud;

	private Enemy mach;

	public GameObject statueChargeSound;

	public GameObject statueChargeSound2;

	public GameObject statueChargeSound3;

	public bool enraged;

	public GameObject enrageEffect;

	public GameObject currentEnrageEffect;

	private EnemySimplifier[] ensims;

	private int difficulty;

	private SwingCheck2 swingCheck;

	private GroundCheckEnemy gc;

	private EnemyIdentifier eid;

	private Collider enemyCollider;

	private float originalLightRange;

	private float originalNmaRange;

	private float originalNmaSpeed;

	private float originalNmaAcceleration;

	private float originalNmaAngularSpeed;

	private float realSpeedModifier;

	private static readonly int WalkSpeed;

	private EnemyTarget target => null;

	private Vision vision => null;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasAttackTarget => false;

	private bool hasDimensionalTarget => false;

	public bool isEnraged => false;

	public string alterKey => null;

	public string alterCategoryName => null;

	public AlterOption<bool>[] options => null;

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SlowUpdate()
	{
	}

	private void Update()
	{
	}

	private void UpdateVision()
	{
	}

	private void UpdateAttackVision()
	{
	}

	private void AttackCheck()
	{
	}

	private bool CheckAndSetAttackVision()
	{
		return false;
	}

	private bool IsEarlyMeleeOk()
	{
		return false;
	}

	private void AttackCooldowns()
	{
	}

	private void FixedUpdate()
	{
	}

	private void AttackPrep()
	{
	}

	private void Stomp()
	{
	}

	private void Tackle()
	{
	}

	private void Throw()
	{
	}

	public void StompHit()
	{
	}

	public void OrbSpawn()
	{
	}

	public void OrbRespawn()
	{
	}

	public void StopAction()
	{
	}

	public void StopTracking()
	{
	}

	private static Vector3 TransformAcrossPortals(Vector3 point, PortalHandleSequence portals)
	{
		return default(Vector3);
	}

	public void Dash()
	{
	}

	public void StopDash()
	{
	}

	private void DelayedTackle()
	{
	}

	public void ForceStopDashSound()
	{
	}

	public void StartDamage()
	{
	}

	public void StopDamage()
	{
	}

	public void Step()
	{
	}

	public void EnrageDelayed()
	{
	}

	public void UnEnrage()
	{
	}

	public void Enrage()
	{
	}
}
