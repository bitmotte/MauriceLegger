using System.Collections.Generic;
using ULTRAKILL.Enemy;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations.Rigging;

public class MirrorReaper : EnemyScript
{
	public bool stationary;

	public float speed;

	private NavMeshAgent nma;

	private EnemyIdentifier eid;

	private Animator anim;

	private Enemy mach;

	private Vector3 lastDimensionalTarget;

	public FootController fC;

	public Rig rig;

	[SerializeField]
	private SwingCheck2 highSwingCheck;

	[SerializeField]
	private SwingCheck2 lowSwingCheck;

	[SerializeField]
	private SwingCheck2 verticalSwingCheck;

	private MirrorReaperMelee previousMeleeAttack;

	[SerializeField]
	private TrailRenderer scytheTrail;

	[SerializeField]
	private GameObject teleportEffect;

	[SerializeField]
	private GroundWave groundWave;

	private List<GroundWave> currentGroundWaves;

	private int maxGroundWaves;

	[SerializeField]
	private Projectile projectile;

	[SerializeField]
	private GameObject decorativeProjectile;

	[SerializeField]
	private Transform[] projectileSpawnPoints;

	private bool teleportedToEscape;

	private int recentGroundWaves;

	[SerializeField]
	private AudioClip tripleWindup;

	[SerializeField]
	private AudioClip verticalWindup;

	[SerializeField]
	private AudioClip spreeWindup;

	[SerializeField]
	private AudioClip projectileWindup;

	[SerializeField]
	private AudioClip groundwaveWindup;

	[SerializeField]
	private AudioClip reverseTeleportSound;

	[SerializeField]
	private AudioClip[] movementSounds;

	private float cooldown;

	private bool attacking;

	private bool meleeAttacking;

	private bool targetOverride;

	private Vector3 targetOverridePosition;

	private bool lockRotation;

	private bool inAction;

	private bool canRetreat;

	private bool inMeleeMode;

	private float attacksSinceModeChange;

	private TimeSince sinceLastAttack;

	private TimeSince sinceLastTeleport;

	private Vector3 teleportTarget;

	private TimeSince sincePathable;

	private TimeSince sinceVisible;

	private TimeSince sinceOverGround;

	private bool isTargetPathable;

	private bool isTargetVisible;

	private bool isTargetOverGround;

	private TimeSince sinceMeleeRange;

	private float cowardPlayerTimer;

	[Header("Special Behaviour")]
	public bool spawnAnimation;

	public bool startHidden;

	public bool dontSpamProjectiles;

	private float hiddenVisibilityTimer;

	public bool useMirrorPhase;

	public float mirrorPhaseHealth;

	public GameObject objectToMirrorPhase;

	[HideInInspector]
	public bool inMirrorPhase;

	public bool useEscapePoints;

	public Transform[] escapePoints;

	private List<Transform> usedEscapePoints;

	private int difficulty;

	private TargetData lastTargetData;

	private VisionQuery targetQuery;

	private EnemyTarget target => null;

	private bool hasDimensionalTarget => false;

	private Vision vision => null;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private void Start()
	{
	}

	private void UpdateDifficulty()
	{
	}

	public void TrackTick()
	{
	}

	private Vector3 GetApproachPosition(Vector3 targetPos)
	{
		return default(Vector3);
	}

	private Vector3 GetEscapePosition(float desiredDistance = 30f)
	{
		return default(Vector3);
	}

	private bool CheckEscapePosition(Vector3 direction, float desiredDistance, out Vector3 point, out float distance)
	{
		point = default(Vector3);
		distance = default(float);
		return false;
	}

	private void TeleportCheck()
	{
	}

	private void TeleportToEscapePoint()
	{
	}

	private void Update()
	{
	}

	private void AttackCheck()
	{
	}

	private void CheckMode()
	{
	}

	private void PickMeleeAttack()
	{
	}

	private void PickRangedAttack()
	{
	}

	private void PrepAttack(bool ranged = false)
	{
	}

	private void SwingTriple()
	{
	}

	private void SwingVertical()
	{
	}

	private void SwingSpree()
	{
	}

	private void GroundWave()
	{
	}

	private void ProjectileBarrage()
	{
	}

	private void Teleport()
	{
	}

	private void Teleport(Vector3 point)
	{
	}

	public void TeleportNow()
	{
	}

	private void UpdateCurrentGroundWaves()
	{
	}

	public void SpawnGroundWave()
	{
	}

	public void SpawnDecorativeProjectiles()
	{
	}

	public void SpawnProjectiles()
	{
	}

	public void Death()
	{
	}

	public void LowDamageStart()
	{
	}

	public void VerticalDamageStart()
	{
	}

	public void HighDamageStart()
	{
	}

	private void DamageStart()
	{
	}

	public void DamageStop()
	{
	}

	public void StartMoving()
	{
	}

	public void StopAction()
	{
	}

	public void PredictTarget()
	{
	}

	private bool IsTargetVisible(bool getNewValue = false)
	{
		return false;
	}

	private bool IsTargetOverGround(bool getNewValue = false)
	{
		return false;
	}

	private bool IsTargetPathable(bool getNewValue = false)
	{
		return false;
	}

	private bool IsPathable(Vector3 point)
	{
		return false;
	}

	private void PlayMovementSound()
	{
	}

	private void PlaySound(AudioClip clip, float pitchRange = 0.1f)
	{
	}

	private void CanRetreat()
	{
	}
}
