using System.Collections.Generic;
using ULTRAKILL.Portal;
using UnityEngine;

public class ContinuousBeam : MonoBehaviour
{
	public EnemyTarget target;

	private LineRenderer lr;

	private LayerMask environmentMask;

	private LayerMask hitMask;

	public bool canHitPlayer;

	public bool canHitEnemy;

	public bool ignoreInvincibility;

	public float beamWidth;

	public bool enemy;

	public EnemyType safeEnemyType;

	public float damage;

	public float parryMultiplier;

	private float playerCooldown;

	private List<EnemyIdentifier> hitEnemies;

	private List<float> enemyCooldowns;

	public GameObject impactEffect;

	public GameObject trackOnBeamToPlayer;

	[HideInInspector]
	public float originalWidth;

	[HideInInspector]
	public bool dying;

	[HideInInspector]
	public bool off;

	[Header("Startup")]
	public bool startup;

	public float startUpSpeed;

	[HideInInspector]
	public float maxDistance;

	[Header("End Point")]
	public bool useProjectileRef;

	public Projectile projectile;

	public Projectile endProjectile;

	public Transform endPoint;

	private bool hasHadEndPoint;

	public bool cancelIfEndPointBlocked;

	public bool destroyIfEndPointDestroyed;

	private Vector3 lastEndPointPosition;

	public PortalTravellerFlags portalTravelFlags;

	[Header("Hit Interpolation")]
	public bool interpolateHits;

	private (Ray, float)[] lastRays;

	private PortalTraversalV2[] lastTraversals;

	private LineRendererPortalHelper lineRendererPortalHelper;

	public void OnProjectileTraversal(in PortalTravelDetails details)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetPlayerCooldown(float cooldown)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void TurnOff()
	{
	}

	public void DetachAndTurnOff()
	{
	}
}
