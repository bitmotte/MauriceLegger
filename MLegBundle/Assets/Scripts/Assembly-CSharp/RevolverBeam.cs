using System.Collections.Generic;
using UnityEngine;

public class RevolverBeam : MonoBehaviour
{
	private const float ForceBulletPropMulti = 0.005f;

	public EnemyTarget target;

	public BeamType beamType;

	public HitterAttribute[] attributes;

	private LineRenderer lr;

	private AudioSource aud;

	private Light muzzleLight;

	public Vector3 alternateStartPoint;

	public GameObject sourceWeapon;

	[HideInInspector]
	public int bodiesPierced;

	private int enemiesPierced;

	[HideInInspector]
	public List<PhysicsCastResult> hitList;

	private GunControl gc;

	private Vector3 shotHitPoint;

	public CameraController cc;

	private Vector3? lastForward;

	private bool maliciousIgnorePlayer;

	public GameObject hitParticle;

	public int bulletForce;

	public bool quickDraw;

	public int gunVariation;

	public float damage;

	[HideInInspector]
	public float addedDamage;

	public float enemyDamageOverride;

	public float critDamageOverride;

	public float screenshakeMultiplier;

	public int hitAmount;

	public int maxHitsPerTarget;

	private int currentHits;

	public bool noMuzzleflash;

	private bool fadeOut;

	private LayerMask ignoreEnemyTrigger;

	private LayerMask enemyLayerMask;

	private LayerMask pierceLayerMask;

	public int ricochetAmount;

	[HideInInspector]
	public bool hasBeenRicocheter;

	public GameObject ricochetSound;

	public GameObject enemyHitSound;

	public bool fake;

	public EnemyType ignoreEnemyType;

	public bool deflected;

	private bool chargeBacked;

	public bool strongAlt;

	public bool ultraRicocheter;

	public bool splitcoinable;

	public bool canHitProjectiles;

	private bool hasHitProjectile;

	public bool knocksDownInsurrectionists;

	public string hitterOverride;

	public bool isRocketBeam;

	[HideInInspector]
	public List<EnemyIdentifier> hitEids;

	[HideInInspector]
	public Transform previouslyHitTransform;

	[HideInInspector]
	public bool aimAssist;

	[HideInInspector]
	public bool intentionalRicochet;

	private Vector3 actualForward => default(Vector3);

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void FakeShoot(Vector3 target)
	{
	}

	private void Shoot()
	{
	}

	private void UpdateForward(PortalTraversalV2[] portalTraversals, PhysicsCastResult latestHit)
	{
	}

	private void UpdateForward(PortalTraversalV2[] portalTraversals, Vector3 hitPos)
	{
	}

	private void CheckWater(Vector3 origin, Vector3 direction, float distance)
	{
	}

	private void HitSomething(PhysicsCastResult hit)
	{
	}

	private void PiercingShotOrder(bool isPierceHit, PhysicsCastResult[] allHits, PhysicsCastResult rayHit)
	{
	}

	private void PiercingShotCheck()
	{
	}

	public void ExecuteHits(PhysicsCastResult currentHit)
	{
	}

	private void Break(Breakable brk)
	{
	}

	private void RicochetAimAssist(GameObject beam, bool aimAtHead = false)
	{
	}

	private string GetHitterName(bool includeVariation = false)
	{
		return null;
	}
}
