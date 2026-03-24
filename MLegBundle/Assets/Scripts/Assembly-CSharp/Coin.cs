using System.Threading;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class Coin : MonoBehaviour, ITarget
{
	private Vision vision;

	private VisionQuery playerQuery;

	private VisionQuery enemyQuery;

	private VisionQuery coinQuery;

	private Vector3 cachedPlayerPos;

	private VisionQuery explosiveQuery;

	private VisionQuery glassQuery;

	private LayerMask env_lm;

	private LayerMask empty_lm;

	public EnemyTarget customTarget;

	public GameObject sourceWeapon;

	public Rigidbody rb;

	private bool checkingSpeed;

	private float timeToDelete;

	public GameObject refBeam;

	public Vector3 hitPoint;

	private Collider[] cols;

	private SphereCollider scol;

	private CancellationTokenSource untrackCoinTokenSource;

	public bool shot;

	[HideInInspector]
	public bool shotByEnemy;

	private bool wasShotByEnemy;

	public GameObject coinBreak;

	public float power;

	private EnemyIdentifier eid;

	public bool quickDraw;

	public Material uselessMaterial;

	private GameObject altBeam;

	public GameObject coinHitSound;

	[HideInInspector]
	public int hitTimes;

	public bool doubled;

	public GameObject flash;

	public GameObject enemyFlash;

	public GameObject chargeEffect;

	private GameObject currentCharge;

	private StyleHUD shud;

	public CoinChainCache ccc;

	public int ricochets;

	[HideInInspector]
	public int difficulty;

	public bool dontDestroyOnPlayerRespawn;

	public bool ignoreBlessedEnemies;

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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool CheckEnemyObstruction(TargetDataRef t)
	{
		return false;
	}

	public bool IsOverrideTarget(TargetDataRef t)
	{
		return false;
	}

	public void UntrackCoin()
	{
	}

	private bool CoinReflectCheck(TargetDataRef data)
	{
		return false;
	}

	private bool ExplosiveReflectCheck(TargetDataRef data)
	{
		return false;
	}

	private bool GlassHitCheck(TargetDataRef data, PhysicsCastResult hit)
	{
		return false;
	}

	private void Update()
	{
	}

	private void TripleTime()
	{
	}

	private void TripleTimeEnd()
	{
	}

	private void DoubleTime()
	{
	}

	public void DelayedReflectRevolver(Vector3 hitp, GameObject beam = null)
	{
	}

	public void ReflectRevolver()
	{
	}

	public bool GetGeryonTarget(TargetDataRef data, out Vector3 pos)
	{
		pos = default(Vector3);
		return false;
	}

	public void DelayedPunchflection()
	{
	}

	public void Punchflection()
	{
	}

	public void Bounce()
	{
	}

	public void DelayedEnemyReflect()
	{
	}

	public void EnemyReflect()
	{
	}

	private void ShootAtPlayer()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public void GetDeleted()
	{
	}

	private void StartCheckingSpeed()
	{
	}

	private GameObject SpawnBeam()
	{
		return null;
	}

	public void RicoshotPointsCheck()
	{
	}

	public void SetData(ref TargetData data)
	{
	}

	public void UpdateCachedTransformData()
	{
	}
}
