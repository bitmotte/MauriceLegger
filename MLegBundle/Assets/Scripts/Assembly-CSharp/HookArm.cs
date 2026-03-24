using System.Collections.Generic;
using ULTRAKILL.Portal;
using UnityEngine;

[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
public class HookArm : MonoSingleton<HookArm>
{
	public bool equipped;

	private LineRenderer lr;

	private Animator anim;

	private Vector3 hookPoint;

	private Vector3 previousHookPoint;

	[HideInInspector]
	public HookState state;

	private bool returning;

	[SerializeField]
	private GameObject model;

	private CapsuleCollider playerCollider;

	public Transform hand;

	public Transform hook;

	public GameObject hookModel;

	private Vector3 throwDirection;

	private float returnDistance;

	private LayerMask throwMask;

	private LayerMask enviroMask;

	private LayerMask enemyMask;

	private float throwWarp;

	private Transform caughtTransform;

	private Vector3 caughtPoint;

	private Collider caughtCollider;

	private EnemyIdentifier caughtEid;

	private List<EnemyType> deadIgnoreTypes;

	private List<EnemyType> lightEnemies;

	private GroundCheckEnemy enemyGroundCheck;

	private Rigidbody enemyRigidbody;

	private HookPoint caughtHook;

	private bool lightTarget;

	[SerializeField]
	private LineRenderer inspectLr;

	private bool forcingGroundCheck;

	private bool forcingFistControl;

	private AudioSource aud;

	[Header("Sounds")]
	public GameObject throwSound;

	public GameObject hitSound;

	public GameObject pullSound;

	public GameObject pullDoneSound;

	public GameObject catchSound;

	public GameObject errorSound;

	public AudioClip throwLoop;

	public AudioClip pullLoop;

	public GameObject wooshSound;

	private GameObject currentWoosh;

	public GameObject clinkSparks;

	public GameObject clinkObjectSparks;

	private float cooldown;

	private CameraFrustumTargeter targeter;

	[HideInInspector]
	public bool beingPulled;

	private List<Rigidbody> caughtObjects;

	private float semiBlocked;

	private Grenade caughtGrenade;

	private Cannonball caughtCannonball;

	private readonly List<PortalTraversalV2> portalTraversals;

	private LineRendererPortalHelper lineRendererPortalHelper;

	[Header("Portal Hook Settings")]
	[SerializeField]
	private float maxPortalBendAngle;

	[SerializeField]
	private float portalEdgeMargin;

	private Vector3 currentForward => default(Vector3);

	private void Start()
	{
	}

	public void Inspect()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPortalTraversed(PortalTravelDetails details)
	{
	}

	private void UpdateLineRendererPositions()
	{
	}

	private Vector3 GetNextCaughtPoint()
	{
		return default(Vector3);
	}

	private bool TryMigrateToAdjacentPortal(int traversalIndex, Vector3 segmentStart, Vector3 direction, float portalPlaneDistance)
	{
		return false;
	}

	private void RecalculateThrowingIntersections(bool allowMigration = true)
	{
	}

	private bool RecalculatePortalIntersections(bool allowMigration = true)
	{
		return false;
	}

	private Vector3 ClampToPortalBounds(Portal portal, PortalSide side, Vector3 worldPoint, out bool wasClamped)
	{
		wasClamped = default(bool);
		return default(Vector3);
	}

	private Vector3 ClampToPortalBounds(Portal portal, PortalSide side, Vector3 worldPoint)
	{
		return default(Vector3);
	}

	private bool CheckPortalBendAngle(Vector3 playerPos, Vector3 entrancePoint, Vector3 exitPoint, Vector3 targetPos, Matrix4x4 travelMatrix)
	{
		return false;
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void TraversePortal(PortalTraversalV2 traversal)
	{
	}

	private void ResetTraversals()
	{
	}

	private float GetTotalLineDistance()
	{
		return 0f;
	}

	private void FixedUpdate()
	{
	}

	private void SolveDeadIgnore()
	{
	}

	private void ItemGrabError(RaycastHit rhit)
	{
	}

	public void StopThrow(float animationTime = 0f, bool sparks = false)
	{
	}

	public void Cancel()
	{
	}

	public void CatchOver()
	{
	}

	private void ForceGroundCheck()
	{
	}

	private void StopForceGroundCheck()
	{
	}

	private void SemiBlockCheck()
	{
	}
}
