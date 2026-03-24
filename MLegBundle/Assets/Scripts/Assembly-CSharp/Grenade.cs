using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class Grenade : MonoBehaviour, ITarget
{
	public string hitterWeapon;

	public GameObject sourceWeapon;

	public GameObject explosion;

	public GameObject harmlessExplosion;

	public GameObject superExplosion;

	[SerializeField]
	private RevolverBeam grenadeBeam;

	private bool exploded;

	public bool enemy;

	[HideInInspector]
	public EnemyIdentifier originEnemy;

	public float totalDamageMultiplier;

	public bool rocket;

	[HideInInspector]
	public Rigidbody rb;

	[HideInInspector]
	public List<Magnet> magnets;

	[HideInInspector]
	public Magnet latestEnemyMagnet;

	public float rocketSpeed;

	[SerializeField]
	private GameObject freezeEffect;

	private CapsuleCollider col;

	[SerializeField]
	private GameObject interruptSphere;

	public bool playerRiding;

	private bool playerInRidingRange;

	private float downpull;

	public GameObject playerRideSound;

	[HideInInspector]
	public bool rideable;

	[HideInInspector]
	public bool hooked;

	private bool hasBeenRidden;

	private LayerMask rocketRideMask;

	public TargetHandle proximityTargetHandle;

	public GameObject proximityWindup;

	private bool selfExploding;

	[HideInInspector]
	public bool levelledUp;

	[HideInInspector]
	public float timeFrozen;

	[SerializeField]
	private GameObject levelUpEffect;

	public List<EnemyType> ignoreEnemyType;

	private SimplePortalTraveler portalTraveler;

	private Vector3 cachedPos;

	private Quaternion cachedRot;

	private Vector3 cachedVel;

	public bool frozen => false;

	public int Id => 0;

	public TargetType Type => default(TargetType);

	public EnemyIdentifier EID => null;

	public GameObject GameObject => null;

	public Rigidbody Rigidbody => null;

	public Transform Transform => null;

	public Vector3 Position => default(Vector3);

	public Vector3 HeadPosition => default(Vector3);

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Collision(Collider other)
	{
	}

	public void Collision(Collider other, Vector3 velocity)
	{
	}

	private void ProximityExplosion()
	{
	}

	public void Explode(bool big = false, bool harmless = false, bool super = false, float sizeMultiplier = 1f, bool ultrabooster = false, GameObject exploderWeapon = null, bool fup = false)
	{
	}

	public void PlayerRideStart()
	{
	}

	public void PlayerRideEnd()
	{
	}

	public void CanCollideWithPlayer(bool can = true)
	{
	}

	public bool? OnPortalTraversal(PortalTravelDetails details)
	{
		return null;
	}

	public void OnRiderTraversal(PortalTravelDetails riderTravelDetails)
	{
	}

	public void OnPortalBlocked(in PortalTravelDetails details)
	{
	}

	public void GrenadeBeam(Vector3 targetPoint, GameObject newSourceWeapon = null)
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
