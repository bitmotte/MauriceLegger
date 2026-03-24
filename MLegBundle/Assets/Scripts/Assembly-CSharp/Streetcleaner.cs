using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;

public class Streetcleaner : EnemyScript
{
	private Animator anim;

	private NavMeshAgent nma;

	private Rigidbody rb;

	public bool dead;

	private TrailRenderer handTrail;

	private LayerMask enviroMask;

	public bool dodging;

	private float dodgeSpeed;

	private float dodgeCooldown;

	public GameObject dodgeSound;

	public Transform hose;

	public Transform hoseTarget;

	public GameObject canister;

	public AssetReference explosion;

	public bool canisterHit;

	public GameObject firePoint;

	private Transform warningFlame;

	private ParticleSystem firePart;

	private Light fireLight;

	private AudioSource fireAud;

	public GameObject fireStopSound;

	public bool damaging;

	private bool attacking;

	public GameObject warningFlash;

	[SerializeField]
	private Transform aimBone;

	private Quaternion torsoDefaultRotation;

	[SerializeField]
	private Transform flameThrowerBone;

	private int difficulty;

	private float cooldown;

	private RaycastHit rhit;

	[HideInInspector]
	public EnemyIdentifier eid;

	private GroundCheckEnemy gc;

	private Enemy mach;

	private VisionQuery targetQuery;

	private TargetHandle targetHandle;

	private TargetData targetData;

	private Vector3 lastDimensionalTarget;

	private EnemyTarget target => null;

	private Vision vision => null;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasVision => false;

	private bool hasDimensionalTarget => false;

	public override void OnTeleport(PortalTravelDetails details)
	{
	}

	public override bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	private void HandleCanisterHit(GameObject sourceWeapon)
	{
	}

	public virtual void CanisterExplosion()
	{
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

	private void Start()
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

	private void SetRunAnimation(bool running, bool walking)
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void StartFire()
	{
	}

	public void StartDamaging()
	{
	}

	public void StopFire()
	{
	}

	public void Dodge()
	{
	}

	public void StopMoving()
	{
	}

	public void DeflectShot()
	{
	}

	public void SlapOver()
	{
	}

	public void OverrideOver()
	{
	}

	private void TryIgniteStains()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}
}
