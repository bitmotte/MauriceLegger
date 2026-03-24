using ULTRAKILL.Enemy;
using UnityEngine;

public class Power : EnemyScript
{
	private enum SpearAttackState
	{
		None = 0,
		Vertical = 1,
		Horizontal = 2
	}

	private Animator anim;

	private EnemyIdentifier eid;

	private Rigidbody rb;

	private Enemy mach;

	private LayerMask environmentMask;

	private int difficulty;

	private bool active;

	private bool goingLeft;

	[HideInInspector]
	public bool inAction;

	[HideInInspector]
	public bool juggled;

	private bool juggleFalling;

	private float juggleHp;

	private TimeSince sinceJuggleStart;

	[SerializeField]
	private SkinnedMeshRenderer cape;

	[SerializeField]
	private GameObject particles;

	[SerializeField]
	private GameObject particlesEnraged;

	[SerializeField]
	private GameObject juggleEffect;

	private bool goForward;

	private float forwardSpeed;

	[SerializeField]
	private GameObject dashEffect;

	[SerializeField]
	private GameObject sword;

	[SerializeField]
	private GameObject zwei;

	[SerializeField]
	private GameObject zweiProjectiles;

	[SerializeField]
	private GameObject glaive;

	[SerializeField]
	private GameObject spinner;

	[SerializeField]
	private Projectile spinnerThrown;

	[SerializeField]
	private GameObject spear;

	[SerializeField]
	private Projectile spearThrown;

	private float[] moveChanceBonuses;

	private float attackCooldown;

	private int burstLength;

	private SpearAttackState spearing;

	private bool aboutToThrowSpear;

	private bool projectilesOnSwing;

	private bool verticalSwing;

	private TimeSince sinceLastAttacked;

	private bool checkingForSelfDefend;

	private float healthSinceLastAttacked;

	private float preAttackHealth;

	private bool hasAttacked;

	private bool teleportAfterAction;

	[SerializeField]
	private SwingCheck2 swingCheck;

	[SerializeField]
	private SwingCheck2[] zweiChecks;

	[SerializeField]
	private GameObject weaponSpawnEffect;

	[SerializeField]
	private GameObject weaponBreakEffect;

	[SerializeField]
	private GameObject stabEffect;

	private ParticleSystem stabParticle;

	private TrailRenderer stabTrail;

	private AudioSource stabAudio;

	private WeaponTrail currentWeaponTrail;

	private float outOfSightTime;

	private int teleportAttempts;

	private int teleportInterval;

	public GameObject teleportSound;

	public GameObject decoy;

	public bool enraged;

	private EnemySimplifier[] ensims;

	private bool overrideRotation;

	private bool stopRotation;

	private Vector3 overrideTarget;

	private int spearAttacks;

	private GameObject currentSpearFlash;

	private VisionQuery targetQuery;

	private TargetHandle targetHandle;

	private TargetHandle throwStartTargetHandle;

	private TargetData lastTargetData;

	public Collider aggroBounds;

	private bool targetInAggroBounds;

	private AudioSource aud;

	public float voicePitch;

	private bool highPriorityVoice;

	private bool dying;

	private Vector3 deathPosition;

	[SerializeField]
	private Rigidbody[] deathLimbs;

	private TimeSince sincePreviousLimb;

	private int currentLimb;

	[SerializeField]
	private SkinnedMeshRenderer bodyMeshRenderer;

	[SerializeField]
	private Mesh deadMesh;

	[SerializeField]
	private Transform decorativeArm;

	[SerializeField]
	private Transform physicsArm;

	private bool armDetached;

	private Vector3 pullStartPosition;

	private TimeSince sinceArmPullStart;

	private GameObject currentEnrageParticle;

	private EnemyTarget target => null;

	private Vision vision => null;

	private bool hasVision => false;

	private bool isJuggled => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateBuff()
	{
	}

	private void UpdateSpeed()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateVision()
	{
	}

	private void Update()
	{
	}

	private void UpdateRigidbodySettings()
	{
	}

	private void DyingUpdate()
	{
	}

	private void PickAttack()
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Rapier()
	{
	}

	public void Zwei()
	{
	}

	public void Glaive()
	{
	}

	public void Throw(bool cheapShot = false)
	{
	}

	public void Spear()
	{
	}

	public void SpawnWeapon(GameObject weapon)
	{
	}

	public void DespawnWeapon(GameObject weapon, bool breakEffect = true)
	{
	}

	public void ThrowSpinner()
	{
	}

	private void SpearAttack()
	{
	}

	private void SpearFlash()
	{
	}

	private void SpearGoHorizontal()
	{
	}

	private void SpearGo()
	{
	}

	private void ToSpearThrow()
	{
	}

	private void ThrowSpear()
	{
	}

	private void ChangeForwardSpeed(float speed)
	{
	}

	private void StartDamage(bool stab)
	{
	}

	private void StopDamage(bool stab)
	{
	}

	private void Backdash()
	{
	}

	private void Backdash(bool animation)
	{
	}

	private void StopMoving()
	{
	}

	public void Teleport(bool closeRange = false, bool longrange = false, bool firstTime = true, bool horizontal = false, bool vertical = false, bool forceOnScreen = false)
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

	public void GotParried()
	{
	}

	public void JuggleStart()
	{
	}

	private void JuggleStop(bool enrage = false)
	{
	}

	public void StopAction()
	{
	}

	private void AttackEnd()
	{
	}

	private void DespawnAll()
	{
	}

	public void ParryFlash()
	{
	}

	private void Flash(bool parryable)
	{
	}

	public void LookAtTarget(int flash = 0)
	{
	}

	public void FollowTarget()
	{
	}

	public void CapeDisable()
	{
	}

	public void CapeReset()
	{
	}

	public void EnrageNow()
	{
	}

	public bool CanPlaySound(bool highPriority = false)
	{
		return false;
	}

	public void PlaySound(AudioClip clip, bool randomPitch = false, bool loop = false, float volume = 1f)
	{
	}

	private bool IsHitTarget(Collider col)
	{
		return false;
	}

	public void IntroContinuation()
	{
	}

	public void Death()
	{
	}

	public void SpawnSword()
	{
	}

	public void DespawnSword()
	{
	}

	public void SpawnZwei()
	{
	}

	public void DespawnZwei()
	{
	}

	public void SpawnGlaive()
	{
	}

	public void DespawnGlaive()
	{
	}

	public void SpawnSpinner()
	{
	}

	public void DespawnSpinner()
	{
	}

	public void SpawnSpear()
	{
	}

	public void DespawnSpear()
	{
	}

	public void GlaiveToSpinner()
	{
	}

	public void SpinnerToGlaive()
	{
	}

	public void StartSwing()
	{
	}

	public void StopSwing()
	{
	}

	public void StartStab()
	{
	}

	public void StopStab()
	{
	}

	private void VerticalSwing()
	{
	}

	public void ZweiDamage(bool enabled)
	{
	}

	private void RandomizeDirection()
	{
	}
}
