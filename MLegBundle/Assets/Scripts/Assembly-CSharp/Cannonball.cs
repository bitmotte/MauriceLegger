using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class Cannonball : MonoBehaviour, ITarget
{
	public bool launchable;

	[SerializeField]
	public bool launched;

	private Rigidbody rb;

	private Collider col;

	[SerializeField]
	private GameObject breakEffect;

	private bool checkingForBreak;

	private bool broken;

	public float damage;

	public float speed;

	public bool parry;

	[HideInInspector]
	public Sisyphus sisy;

	public bool ghostCollider;

	public bool canBreakBeforeLaunched;

	[Header("Physics Cannonball Settings")]
	public bool physicsCannonball;

	public AudioSource bounceSound;

	[HideInInspector]
	public List<EnemyIdentifier> hitEnemies;

	public int maxBounces;

	private int currentBounces;

	[HideInInspector]
	public bool hasBounced;

	[HideInInspector]
	public bool forceMaxSpeed;

	public int durability;

	[SerializeField]
	private GameObject interruptionExplosion;

	[SerializeField]
	private GameObject groundHitShockwave;

	[HideInInspector]
	public GameObject sourceWeapon;

	private TimeSince instaBreakDefence;

	private Vector3 cachedPos;

	private Quaternion cachedRot;

	private Vector3 cachedVel;

	private SimplePortalTraveler portalTraveler;

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Launch()
	{
	}

	public void Unlaunch(bool relaunchable = true)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Collide(Collider other)
	{
	}

	public void Break()
	{
	}

	private void Bounce()
	{
	}

	public void Explode()
	{
	}

	public void InstaBreakDefenceCancel()
	{
	}

	public void OnPortalBlocked(in PortalTravelDetails details)
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
