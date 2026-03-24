using System;
using System.Collections.Generic;
using Gravity;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.UI;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class NewMovement : MonoSingleton<NewMovement>, ITarget, IPortalTraveller
{
	public enum PreserveLengthMode
	{
		DontPreserve = 0,
		PreserveHorizontal = 1,
		PreserveAll = 2
	}

	public float walkSpeed;

	public float airAcceleration;

	public float jumpPower;

	public float wallJumpPower;

	public Vector3 pushForce;

	private LayerMask frictionlessSurfaceMask;

	public CameraController cc;

	private InputManager inman;

	private AssistController asscon;

	private StyleHUD shud;

	private StyleCalculator scalc;

	private GunControl gunc;

	private FistControl punch;

	private int difficulty;

	[HideInInspector]
	public bool levelOver;

	[HideInInspector]
	public float longestSlide;

	[HideInInspector]
	public int sameCheckpointRestarts;

	public bool endlessMode;

	public bool quakeJump;

	public int gamepadFreezeCount;

	public bool activated;

	public int hp;

	public float antiHp;

	[HideInInspector]
	public float hurtInvincibility;

	public bool dead;

	private Vector3 inputDir;

	private Vector3 targetVel;

	private Vector3 airDirection;

	private Vector3 groundCheckPos;

	private bool onGasoline;

	public bool walking;

	private bool enemyStepping;

	[HideInInspector]
	public bool falling;

	private bool jumpCooldown;

	public int currentWallJumps;

	private Vector3 wallJumpPos;

	private float clingFade;

	private float antiHpCooldown;

	private bool cantInstaHeal;

	public Action<PortalTravelDetails> onPortalTraversed;

	[NonSerialized]
	public int lastTraversalFrame;

	public bool boost;

	public float boostCharge;

	private float boostLeft;

	private float dashStorage;

	public Vector3 dodgeDirection;

	public bool jumping;

	private float fallSpeed;

	private float fallTime;

	public bool stillHolding;

	public float slamForce;

	private bool slamStorage;

	[HideInInspector]
	public float slamCooldown;

	[HideInInspector]
	public bool exploded;

	[HideInInspector]
	public float safeExplosionLaunchCooldown;

	public bool sliding;

	private float slideSafety;

	private bool slideEnding;

	private float slideLength;

	private bool crouching;

	public bool standing;

	[HideInInspector]
	public int rocketJumps;

	[HideInInspector]
	public int hammerJumps;

	[HideInInspector]
	public float explosionLaunchResistance;

	[HideInInspector]
	public Grenade ridingRocket;

	[HideInInspector]
	public int rocketRides;

	private float preSlideSpeed;

	private float preSlideDelay;

	public bool slowMode;

	public CustomGroundProperties groundProperties;

	private float friction;

	public Image hurtScreen;

	public DeathSequence deathSequence;

	public FlashImage hpFlash;

	public FlashImage antiHpFlash;

	public GameObject screenHud;

	private Canvas fullHud;

	private Vector3 hudOriginalPos;

	public GameObject scrnBlood;

	public GameObject hudCam;

	private Vector3 camOriginalPos;

	private Color hurtColor;

	private Color currentColor;

	[HideInInspector]
	public Rigidbody rb;

	[HideInInspector]
	public CapsuleCollider playerCollider;

	public GroundCheckGroup gc;

	public GroundCheckGroup slopeCheck;

	private WallCheck wc;

	private WallCheckGroup wcGroup;

	private AudioSource aud;

	private AudioSource audGround;

	private AudioSource audWoosh;

	private AudioSource hurtAud;

	private AudioSource greenHpAud;

	public AudioSource oilSlideEffect;

	public AudioClip jumpSound;

	public AudioClip landingSound;

	public AudioClip finalWallJump;

	public AudioClip dodgeSound;

	public GameObject staminaFailSound;

	public GameObject slideStopSound;

	private AudioSource[] fricSlideAuds;

	private float[] fricSlideAudVols;

	private float[] fricSlideAudPitches;

	public GameObject dashJumpSound;

	public GameObject quakeJumpSound;

	public GameObject dodgeParticle;

	public GameObject impactDust;

	public GameObject fallParticle;

	private GameObject currentFallParticle;

	public GameObject slideParticle;

	private GameObject currentSlideParticle;

	private SurfaceType currentSlideSurfaceType;

	private GameObject slideScrape;

	private ParticleSystem.TrailModule slideTrail;

	private ParticleSystem.MinMaxGradient normalSlideGradient;

	public ParticleSystem.MinMaxGradient invincibleSlideGradient;

	private GameObject wallScrape;

	private SurfaceType currentScrapeSurfaceType;

	private GameObject currentFrictionlessSlideParticle;

	private SurfaceType currentFricSlideSurfaceType;

	[HideInInspector]
	public bool modNoDashSlide;

	[HideInInspector]
	public bool modNoJump;

	[HideInInspector]
	public float modForcedFrictionMultip;

	private PortalAwarePlayerCollider portalAwareCollider;

	private RigidbodyConstraints defaultRBConstraints;

	private float ssjMaxFrames;

	[HideInInspector]
	public HashSet<Water> touchingWaters;

	[HideInInspector]
	public int fakeFallRequests;

	[HideInInspector]
	public List<FakeFallZone> fakeFallZones;

	[HideInInspector]
	public List<GravityVolume> gravityVolumes;

	private Vector3Int? lastCheckedGasolineVoxel;

	private int framesSinceSlide;

	private Vector3 velocityAfterSlide;

	private Vector3? postTeleportForward;

	private Vector3? postTeleportRight;

	private Vector3 cachedPos;

	private Vector3 cachedHeadPos;

	private Quaternion cachedRot;

	private Vector3 cachedVel;

	private int remainingTeleportFrames;

	public Vector3 portalTravelPoint => default(Vector3);

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	public bool TeleportFixedFramesPending => false;

	public int id => 0;

	public int? targetId => null;

	public Vector3 travellerPosition => default(Vector3);

	public Vector3 travellerVelocity => default(Vector3);

	public PortalTravellerType travellerType => default(PortalTravellerType);

	protected void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPrefChanged(string key, object value)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public AudioSource DuplicateDetachWhoosh()
	{
		return null;
	}

	public AudioSource RestoreWhoosh()
	{
		return null;
	}

	private void FrictionlessSlideParticle()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Move()
	{
	}

	public Vector3 MakeHorizontal(Vector3 direction, PreserveLengthMode preserveLength = PreserveLengthMode.PreserveHorizontal, bool relativeToCamera = true)
	{
		return default(Vector3);
	}

	private void Dodge()
	{
	}

	public void Jump()
	{
	}

	private void TrySSJ(Vector3 direction, float speedMultiplier, Func<int, float> speedLossFormula)
	{
	}

	private void WallJump(WallCheck wcInstance)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	public void LaunchUp(float multiplier)
	{
	}

	public void Launch(Vector3 direction, float multiplier = 8f, bool ignoreMass = false)
	{
	}

	public void LaunchFromPoint(Vector3 position, float strength, float maxDistance = 1f)
	{
	}

	public void LaunchFromPointAtSpeed(Vector3 position, float speed)
	{
	}

	public void Slamdown(float strength)
	{
	}

	private void JumpReady()
	{
	}

	public void FakeHurt(bool silent = false)
	{
	}

	public void GetHurt(int damage, bool invincible, float scoreLossMultiplier = 1f, bool explosion = false, bool instablack = false, float hardDamageMultiplier = 0.35f, bool ignoreInvincibility = false)
	{
	}

	public void ForceAntiHP(float amount, bool silent = false, bool dontOverwriteHp = false, bool addToCooldown = true, bool stopInstaHeal = false)
	{
	}

	public void ForceAddAntiHP(float amount, bool silent = false, bool dontOverwriteHp = false, bool addToCooldown = true, bool stopInstaHeal = false)
	{
	}

	public void GetHealth(int health, bool silent, bool fromExplosion = false, bool bloodsplatter = true)
	{
	}

	public void FullHeal(bool silent = false)
	{
	}

	public void Parry(EnemyIdentifier eid = null, string customParryText = "")
	{
	}

	public void SuperCharge()
	{
	}

	public void Respawn()
	{
	}

	public void ResetHardDamage()
	{
	}

	private void NotJumping()
	{
	}

	public void EnemyStepResets()
	{
	}

	public void LandingImpact()
	{
	}

	private void StartSlide()
	{
	}

	private void CreateSlideScrape(bool ignorePrevious = false, bool frictionlessVersion = false)
	{
	}

	private void SetFrictionlessSlideValues()
	{
	}

	private void CreateWallScrape(Vector3 position, bool ignorePrevious = false)
	{
	}

	private void CheckForGasoline()
	{
	}

	public void StopSlide()
	{
	}

	private void DetachSlideScrape()
	{
	}

	private void DetachWallScrape()
	{
	}

	private void DetachScrape(GameObject scrape)
	{
	}

	public void EmptyStamina()
	{
	}

	public void FullStamina()
	{
	}

	public void DeactivatePlayer()
	{
	}

	public void ActivatePlayer()
	{
	}

	public void StopMovement()
	{
	}

	public void DeactivateMovement()
	{
	}

	public void ReactivateMovement()
	{
	}

	public void LockMovementAxes()
	{
	}

	public void UnlockMovementAxes()
	{
	}

	public void SwitchGravity(Vector3 direction, bool instant = false, bool transformCamera = true)
	{
	}

	public void ResetGravity(bool instant = false)
	{
	}

	public void CheckGravityVolumes(bool resetIfNone = false)
	{
	}

	private static Quaternion GetSimulatedCameraWorldRotation(Quaternion inputRotation, Transform playerTransform, Vector3 gravityDir)
	{
		return default(Quaternion);
	}

	public bool? OnTravel(PortalTravelDetails details)
	{
		return null;
	}

	public void OnTeleportBlocked(PortalTravelDetails details)
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
