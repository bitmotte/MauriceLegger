using ULTRAKILL.Enemy;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.AddressableAssets;

public class Stalker : EnemyScript, IEnemyRelationshipLogic
{
	private EnemyIdentifier eid;

	private Enemy mach;

	private int difficulty;

	private NavMeshAgent nma;

	[HideInInspector]
	public float defaultMovementSpeed;

	private Animator anim;

	private bool inAction;

	private float explosionCharge;

	private float countDownAmount;

	private bool exploding;

	private bool exploded;

	public AssetReference explosion;

	private float maxHp;

	private Light lit;

	private Color currentColor;

	public Color[] lightColors;

	private bool blinking;

	private float blinkTimer;

	private AudioSource lightAud;

	public AudioClip[] lightSounds;

	public SkinnedMeshRenderer canRenderer;

	public GameObject stepSound;

	public GameObject screamSound;

	private float explodeSpeed;

	public float prepareTime;

	public float prepareWarningTime;

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

	private void SetSpeed()
	{
	}

	private void UpdateSpeed()
	{
	}

	private void OnDisable()
	{
	}

	private void NavigationUpdate()
	{
	}

	private void SlowUpdate()
	{
	}

	private void ChangeTarget(EnemyIdentifier targetEid)
	{
	}

	private void RemoveTarget()
	{
	}

	private void Update()
	{
	}

	private void UpdateAnimations()
	{
	}

	private void UpdateLightColor()
	{
	}

	private Vector3 GetPlayerTargetPosition(EnemyTarget target)
	{
		return default(Vector3);
	}

	private Vector3 GetEnemyTargetPosition(EnemyIdentifier targetEID)
	{
		return default(Vector3);
	}

	private bool CheckSameTarget(TargetDataRef data, EnemyIdentifier eid)
	{
		return false;
	}

	public void Countdown()
	{
	}

	public void SandExplode(int onDeath = 1)
	{
	}

	public bool CheckForPath(EnemyIdentifier ed)
	{
		return false;
	}

	public bool CheckForOffsetPath(EnemyIdentifier ed)
	{
		return false;
	}

	public bool CheckForPath(Vector3 position)
	{
		return false;
	}

	public void StopAction()
	{
	}

	public void Step()
	{
	}

	public bool ShouldAttackEnemies()
	{
		return false;
	}

	public bool ShouldIgnorePlayer()
	{
		return false;
	}
}
