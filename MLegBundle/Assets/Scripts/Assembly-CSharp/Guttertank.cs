using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class Guttertank : EnemyScript, IHitTargetCallback
{
	private bool gotValues;

	private EnemyIdentifier eid;

	private NavMeshAgent nma;

	private Enemy mach;

	private Rigidbody rb;

	private Animator anim;

	private AudioSource aud;

	private Collider col;

	private int difficulty;

	public bool stationary;

	public bool punchOnSpawn;

	private Vector3 stationaryPosition;

	private NavMeshPath path;

	private bool walking;

	private Vector3 walkTarget;

	private bool dead;

	[SerializeField]
	private SwingCheck2 sc;

	private bool inAction;

	private bool moveForward;

	private Vector3 moveTarget;

	private bool trackInAction;

	private bool overrideTarget;

	private bool lookAtTarget;

	private bool punching;

	private Vector3 overrideTargetPosition;

	private float aimRotationLerp;

	private float punchCooldown;

	private bool punchHit;

	public Transform shootPoint;

	public Grenade rocket;

	public GameObject rocketParticle;

	public Transform aimBone;

	private Quaternion torsoDefaultRotation;

	private float shootCooldown;

	private float lineOfSightTimer;

	public Landmine landmine;

	private float mineCooldown;

	private List<Landmine> placedMines;

	private GoreZone gz;

	public AudioSource punchPrepSound;

	public AudioSource rocketPrepSound;

	public AudioSource minePrepSound;

	public AudioSource fallImpactSound;

	[HideInInspector]
	public bool firstPunch;

	public UltrakillEvent onFirstPunch;

	private Vector3 cachedVisionPos;

	private TargetHandle targetHandle;

	private TargetData lastTargetData;

	private VisionQuery targetQuery;

	private Vector3 lastDimensionalTarget;

	private Vision vision => null;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasVision => false;

	private bool hasDimensionalTarget => false;

	private Vector3 targetPosition => default(Vector3);

	private Vector3 targetHeadPosition => default(Vector3);

	private Vector3 targetVelocity => default(Vector3);

	private bool ObstructionCheck(TargetDataRef data)
	{
		return false;
	}

	private bool ObstructionCheck(TargetDataRef data, bool toHead)
	{
		return false;
	}

	private void Start()
	{
	}

	private void GetValues()
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

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	private void Update()
	{
	}

	private void UpdateLineOfSightTimer(bool hasLoS)
	{
	}

	private void LateUpdate()
	{
	}

	private void FixedUpdate()
	{
	}

	private void SlowUpdate()
	{
	}

	private Vector3 PredictTargetPosition(float time)
	{
		return default(Vector3);
	}

	private bool CheckMines()
	{
		return false;
	}

	private void PrepMine()
	{
	}

	private void PlaceMine()
	{
	}

	private void PrepRocket()
	{
	}

	private void PredictTarget()
	{
	}

	private void FireRocket()
	{
	}

	private void Death()
	{
	}

	private void Halt()
	{
	}

	private void Punch()
	{
	}

	private void PunchActive()
	{
	}

	public void TargetBeenHit()
	{
	}

	private void PunchStop()
	{
	}

	private void FallImpact()
	{
	}

	private void GotParried()
	{
	}

	private void StopParryable()
	{
	}

	private void StopAction()
	{
	}
}
