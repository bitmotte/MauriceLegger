using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class Turret : EnemyScript
{
	private PortalScene scene;

	private Vector3 cachedVisionPos;

	private TargetHandle targetHandle;

	private TargetData lastTargetData;

	private TargetHandle lastTargetHandle;

	private VisionQuery sightQuery;

	private Vector3 delayedLastPlayerPosition;

	private Vector3 aimPos;

	private Vector3 aimDirection;

	private readonly float aimDistance;

	private Vector3 barrelPos;

	private float barrelOffSetDist;

	private Quaternion shootRotation;

	private PortalTraversalV2[] aimTraversals;

	private bool isBarrelPortalBlocked;

	private bool isBarrelPortalCrossed;

	private NavMeshPath tempPath;

	public bool stationary;

	public bool quickStart;

	private Vector3 stationaryPosition;

	[HideInInspector]
	public bool lodged;

	[HideInInspector]
	public bool aiming;

	private PortalLineRenderer aimLines;

	private int numAimLine;

	private float outOfSightTimer;

	private float aimTime;

	private float maxAimTime;

	private float flashTime;

	private float nextBeepTime;

	private bool whiteLine;

	private readonly Color defaultColor;

	private int shotsInARow;

	private TimeSince sinceLastBeep;

	private int difficulty;

	private float cooldown;

	private float kickCooldown;

	[HideInInspector]
	public bool inAction;

	private bool bodyRotate;

	private bool bodyTrackPlayer;

	private bool bodyReset;

	private Quaternion currentBodyRotation;

	private bool wandering;

	public Color defaultLightsColor;

	public Color attackingLightsColor;

	private float lightsIntensityTarget;

	private float currentLightsIntensity;

	[Header("Defaults")]
	[SerializeField]
	private Transform torso;

	[SerializeField]
	private Transform turret;

	[SerializeField]
	private Transform barrelTip;

	[SerializeField]
	private LineRenderer aimLine;

	[SerializeField]
	private RevolverBeam beam;

	[SerializeField]
	private GameObject warningFlash;

	[SerializeField]
	private ParticleSystem antennaFlash;

	[SerializeField]
	private Light antennaLight;

	[SerializeField]
	private AudioSource antennaSound;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private Enemy mach;

	[SerializeField]
	private EnemyIdentifier eid;

	[SerializeField]
	private GameObject head;

	[SerializeField]
	private NavMeshAgent nma;

	public GameObject antenna;

	public List<Transform> interruptables;

	[SerializeField]
	private AudioSource interruptSound;

	[SerializeField]
	private AudioSource cancelSound;

	[SerializeField]
	private AudioSource footStep;

	[SerializeField]
	private AudioSource extendSound;

	[SerializeField]
	private AudioSource thunkSound;

	[SerializeField]
	private AudioSource kickWarningSound;

	[SerializeField]
	private AudioSource aimWarningSound;

	private AudioSource currentSound;

	[SerializeField]
	private GameObject rubble;

	[SerializeField]
	private GameObject rubbleLeft;

	[SerializeField]
	private GameObject rubbleRight;

	private bool leftLodged;

	private bool rightLodged;

	[SerializeField]
	private SkinnedMeshRenderer smr;

	[SerializeField]
	private GameObject unparryableFlash;

	[SerializeField]
	private SwingCheck2 sc;

	[SerializeField]
	private TrailRenderer tr;

	private Vector3 lastDimensionalTarget;

	public override Vector3 VisionSourcePosition => default(Vector3);

	private bool hasVision => false;

	private bool isAimFlashing => false;

	private bool hasDimensionalTarget => false;

	public override bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnFall()
	{
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	private void UpdateBuff()
	{
	}

	private void SetAnimatorSpeed()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	private void VisionUpdate()
	{
	}

	private void UpdateVisionPosition()
	{
	}

	private void NavigationUpdate()
	{
	}

	private bool GetWanderPosition(out Vector3 pos)
	{
		pos = default(Vector3);
		return false;
	}

	private void Update()
	{
	}

	public bool IsWindUpObstructed()
	{
		return false;
	}

	public bool IsTargetObstructed(float radius = 0f)
	{
		return false;
	}

	private void Aiming()
	{
	}

	private void LateUpdate()
	{
	}

	private void StartWindup()
	{
	}

	private void BodyTrack()
	{
	}

	private void BodyFreeze()
	{
	}

	private void BodyReset()
	{
	}

	private void StartAiming()
	{
	}

	private void Kick()
	{
	}

	private void StopAction()
	{
	}

	private void AimAt(Vector3 position, Vector3 direction, float distance, PortalTraversalV2[] traversals)
	{
	}

	private void Shoot()
	{
	}

	private void PreReAim()
	{
	}

	private void ReAim()
	{
	}

	private void ChangeLineColor(Color clr)
	{
	}

	public void CancelAim(bool instant = false)
	{
	}

	public void LodgeFoot(int type)
	{
	}

	public void UnlodgeFoot(int type)
	{
	}

	public void Unlodge()
	{
	}

	public void Interrupt()
	{
	}

	public void OnDeath()
	{
	}

	private void FootStep(float targetPitch)
	{
	}

	private void Thunk()
	{
	}

	private void ExtendBarrel()
	{
	}

	private void GotParried()
	{
	}

	public void UnparryableFlash()
	{
	}

	public void DamageStart()
	{
	}

	public void DamageStop()
	{
	}

	public void ChangeLightsColor(Color target)
	{
	}

	public void ChangeLightsIntensity(float amount)
	{
	}
}
