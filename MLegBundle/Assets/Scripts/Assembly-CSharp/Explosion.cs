using System.Collections.Generic;
using ULTRAKILL.Portal;
using UnityEngine;

public class Explosion : MonoBehaviour
{
	public static float globalSizeMulti;

	private static readonly Collider[] PortalOverlapBuffer;

	public HurtCooldownCollection HurtCooldownCollection;

	public GameObject sourceWeapon;

	public bool enemy;

	public bool harmless;

	public bool lowQuality;

	private CameraController cc;

	private Light light;

	private MeshRenderer mr;

	private Color materialColor;

	private Material originalMaterial;

	private TimeSince explosionTime;

	private bool whiteExplosion;

	private bool fading;

	public float speed;

	public float maxSize;

	public float pushForceMultiplier;

	private LayerMask lmask;

	public int damage;

	public float enemyDamageMultiplier;

	[HideInInspector]
	public int playerDamageOverride;

	public GameObject explosionChunk;

	public bool ignite;

	public bool friendlyFire;

	public bool isFup;

	private HashSet<int> hitColliders;

	public string hitterWeapon;

	public bool halved;

	private SphereCollider scol;

	public AffectedSubjects canHit;

	private bool hasHitPlayer;

	[HideInInspector]
	public EnemyIdentifier originEnemy;

	public bool rocketExplosion;

	public List<EnemyType> toIgnore;

	[HideInInspector]
	public EnemyIdentifier interruptedEnemy;

	[HideInInspector]
	public bool ultrabooster;

	public bool unblockable;

	public bool electric;

	private int enviroGibs;

	private void Start()
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

	private void Collide(Collider other, Vector3 origin)
	{
	}

	private void CheckPortalOverlaps(PortalScene scene, float radius)
	{
	}

	private static bool PrecisePortalCheck(PortalScene scene, PortalHandle portalHandle, Vector3 startPosition, Vector3 closestPoint)
	{
		return false;
	}
}
