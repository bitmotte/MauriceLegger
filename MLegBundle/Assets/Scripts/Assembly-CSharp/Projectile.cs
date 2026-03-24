using System;
using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	public GameObject sourceWeapon;

	private Rigidbody rb;

	public float speed;

	public float turnSpeed;

	public float speedRandomizer;

	private AudioSource aud;

	public GameObject explosionEffect;

	public float damage;

	public float enemyDamageMultiplier;

	public bool friendly;

	public bool playerBullet;

	public string bulletType;

	public string weaponType;

	public bool decorative;

	private Vector3 origScale;

	private bool active;

	public EnemyType safeEnemyType;

	public bool explosive;

	public bool bigExplosion;

	public List<EnemyIdentifier> alreadyHitEnemies;

	public HomingType homingType;

	public float turningSpeedMultiplier;

	[Obsolete("This field is obsolete. Use targetHandle instead.")]
	public EnemyTarget target;

	public TargetHandle targetHandle;

	public bool isTargetPlayer;

	private float maxSpeed;

	private Quaternion targetRotation;

	public float predictiveHomingMultiplier;

	public float stopTrackingAfterSeconds;

	[HideInInspector]
	public float secondsSinceSpawn;

	public bool hittingPlayer;

	private NewMovement nmov;

	public bool boosted;

	[HideInInspector]
	public bool parried;

	private Collider col;

	private float radius;

	public bool undeflectable;

	public bool unparryable;

	public bool breakable;

	public bool keepTrail;

	public bool strong;

	public bool spreaded;

	private int difficulty;

	public bool precheckForCollisions;

	public bool canHitCoin;

	public bool ignoreExplosions;

	public bool ignoreEnvironment;

	private List<Collider> alreadyDeflectedBy;

	private List<float> alreadyDeflectedCooldown;

	public List<ContinuousBeam> connectedBeams;

	public SimplePortalTraveler portalTraveler;

	public PortalHandleSequence traversals;

	[HideInInspector]
	public ParryChallenge parryChallenge;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public static float GetProjectileSpeedMulti(int difficulty)
	{
		return 0f;
	}

	private bool GetTargetData(out Vector3 targetPosition, out Vector3 targetVelocity)
	{
		targetPosition = default(Vector3);
		targetVelocity = default(Vector3);
		return false;
	}

	private bool GetTargetPosition(out Vector3 targetPosition)
	{
		targetPosition = default(Vector3);
		return false;
	}

	private bool IsTargetPlayer()
	{
		return false;
	}

	public void SetPortalTravellerType(PortalTravellerType type)
	{
	}

	public void OnPortalTraversal(in PortalTravelDetails details)
	{
	}

	private void OnTargetTravelled(IPortalTraveller traveller, PortalTravelDetails details)
	{
	}

	public void OnPortalBlocked(in PortalTravelDetails portalTravelDetails)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void CollidedWithPortal()
	{
	}

	private void Collided(Collider other)
	{
	}

	private void CreateExplosionEffect()
	{
	}

	public void Explode()
	{
	}

	private void RecheckPlayerHit()
	{
	}

	private void TimeToDie()
	{
	}

	private void KeepTrail()
	{
	}
}
