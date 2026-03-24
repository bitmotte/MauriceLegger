using UnityEngine;

public class GabrielBase : EnemyScript
{
	private Gabriel gabe1;

	private GabrielSecond gabe2;

	[HideInInspector]
	public Animator anim;

	private Enemy mach;

	private Rigidbody rb;

	[HideInInspector]
	public EnemyIdentifier eid;

	private SkinnedMeshRenderer smr;

	private GabrielVoice voice;

	private Collider col;

	public GameObject particles;

	public GameObject particlesEnraged;

	private Material origBody;

	private Material origWing;

	public Material enrageBody;

	public Material enrageWing;

	[HideInInspector]
	public int difficulty;

	private bool valuesSet;

	private bool active;

	[HideInInspector]
	public bool inAction;

	private bool goingLeft;

	public bool variableForwardSpeed;

	[HideInInspector]
	public bool goForward;

	[HideInInspector]
	public float forwardSpeed;

	[HideInInspector]
	public float forwardSpeedMinimum;

	[HideInInspector]
	public float forwardSpeedMaximum;

	private float startCooldown;

	[HideInInspector]
	public float attackCooldown;

	[HideInInspector]
	public float combinedSwordsCooldown;

	[HideInInspector]
	public Projectile currentCombinedSwordsThrown;

	[HideInInspector]
	public int burstLength;

	public bool enraged;

	private GameObject currentEnrageEffect;

	public bool secondPhase;

	public float phaseChangeHealth;

	private float preAttackTeleportCooldown;

	private float outOfSightTime;

	private int teleportAttempts;

	private int teleportInterval;

	public GameObject teleportSound;

	public GameObject decoy;

	private bool overrideRotation;

	private bool stopRotation;

	private Vector3 overrideTarget;

	private LayerMask environmentMask;

	[HideInInspector]
	public bool spearing;

	private bool dashing;

	private float forcedDashTime;

	private Vector3 dashTarget;

	public GameObject dashEffect;

	[HideInInspector]
	public bool juggled;

	[HideInInspector]
	public float juggleHp;

	private float juggleEndHp;

	private float juggleLength;

	public GameObject juggleEffect;

	private bool juggleFalling;

	public GameObject summonedSwords;

	private GameObject currentSwords;

	public GameObject summonedSwordsWindup;

	private GameObject currentWindup;

	private float summonedSwordsCooldown;

	public Transform head;

	[HideInInspector]
	public bool readyTaunt;

	private float defaultAnimSpeed;

	private bool bossVersion;

	[SerializeField]
	private GameObject genericOutro;

	private int dashAttempts;

	[Header("Events")]
	public UltrakillEvent onFirstPhaseEnd;

	public UltrakillEvent onSecondPhaseStart;

	public bool attackThroughTarget;

	public bool pitFallChallenge;

	private EnemyTarget target => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void SetValues()
	{
	}

	private void UpdateBuff()
	{
	}

	private void UpdateSpeed()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateRigidbodySettings()
	{
	}

	private void Update()
	{
	}

	private void ChooseAttack()
	{
	}

	private void UpdateCooldowns()
	{
	}

	private void UpdateRotation()
	{
	}

	private void FixedUpdate()
	{
	}

	private void AttackMovement()
	{
	}

	private void DashAttack()
	{
	}

	private bool IsHitTarget(Collider col)
	{
		return false;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Teleport(bool closeRange = false, bool longrange = false, bool firstTime = true, bool horizontal = false, bool vertical = false)
	{
	}

	public void TeleportTo(Vector3 position)
	{
	}

	public void CreateDecoyTrail(Vector3 target)
	{
	}

	public GameObject CreateDecoy(Vector3 position, float transparencyOverride = 1f, Animator animatorOverride = null)
	{
		return null;
	}

	private void Parryable()
	{
	}

	public void Unparryable()
	{
	}

	public void AttackFlash(int unparryable = 0)
	{
	}

	private void StartDash()
	{
	}

	private void JuggleStart()
	{
	}

	private void JuggleUpdate()
	{
	}

	private void JuggleStop(bool enrage = false)
	{
	}

	private void EnrageAnimation()
	{
	}

	public void EnrageNow()
	{
	}

	private void ForceUnEnrage()
	{
	}

	public void UnEnrage()
	{
	}

	private void RandomizeDirection()
	{
	}

	public void SetForwardSpeed(int newSpeed)
	{
	}

	public void EnrageTeleport(int teleportType = 0)
	{
	}

	public void ResetAnimSpeed()
	{
	}

	public void LookAtTarget(int instant = 0)
	{
	}

	public void FollowTarget()
	{
	}

	public void StopAction()
	{
	}

	public void ResetWingMat()
	{
	}

	public void Death()
	{
	}

	private void SpawnSummonedSwordsWindup()
	{
	}

	private void SpawnSummonedSwords()
	{
	}

	public void DecideMovementSpeed()
	{
	}

	private void DamageStopRight(int num = 0)
	{
	}

	private void DamageStopLeft(int num = 0)
	{
	}
}
