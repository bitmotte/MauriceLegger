using ULTRAKILL.Enemy;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMelee : EnemyScript, IHitTargetCallback
{
	public bool harmless;

	public bool damaging;

	public TrailRenderer biteTrail;

	public TrailRenderer diveTrail;

	public bool track;

	public float coolDown;

	private NavMeshAgent nma;

	private Animator anim;

	private EnemyIdentifier eid;

	private LayerMask envMask;

	private Enemy mach;

	private VisionQuery nearestQuery;

	private TargetData targetData;

	private TargetHandle targetHandle;

	private float swingDistance;

	private Vector3 diveTargetPos;

	private Vector3 lastDimensionalTarget;

	private bool musicRequested;

	private int difficulty;

	private float defaultCoolDown;

	public GameObject swingSound;

	private Rigidbody rb;

	[HideInInspector]
	public SwingCheck2 swingCheck;

	[HideInInspector]
	public SwingCheck2 diveSwingCheck;

	[HideInInspector]
	public bool diving;

	private bool inAction;

	[SerializeField]
	private Transform modelTransform;

	private TimeSince randomJumpChanceCooldown;

	private bool aboutToDive;

	[SerializeField]
	private GameObject hitGroundParticle;

	[SerializeField]
	private GameObject pullOutParticle;

	private EnemySimplifier ensim;

	public Material originalMaterial;

	public Material biteMaterial;

	private EnemyTarget target => null;

	private Vision vision => null;

	private bool hasVision => false;

	private bool hasDimensionalTarget => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateTargetVision()
	{
	}

	private void DiveCheck()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FixedUpdate()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnLand()
	{
	}

	public override void OnFall()
	{
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	public void JumpAttack()
	{
	}

	public void JumpStart()
	{
	}

	private void CheckThatJumpStarted()
	{
	}

	public void JumpEnd()
	{
	}

	public void PullOut()
	{
	}

	public void JumpEndEnd()
	{
	}

	public void Swing()
	{
	}

	public void SwingEnd()
	{
	}

	public void DamageStart()
	{
	}

	public void TargetBeenHit()
	{
	}

	public void DamageEnd()
	{
	}

	public void StopTracking()
	{
	}

	public void CancelAttack()
	{
	}

	public void TrackTick()
	{
	}

	public void MouthClose()
	{
	}

	private void MouthOpen()
	{
	}
}
