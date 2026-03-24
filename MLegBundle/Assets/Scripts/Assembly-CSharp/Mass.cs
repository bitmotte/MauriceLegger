using System.Collections.Generic;
using ULTRAKILL.Enemy;
using UnityEngine;

public class Mass : EnemyScript
{
	private Animator anim;

	private bool battleMode;

	private Vector3 targetPos;

	private Quaternion targetRot;

	private float transformCooldown;

	private bool walking;

	private float walkWeight;

	public bool inAction;

	private bool inSemiAction;

	public Transform[] shootPoints;

	public GameObject homingProjectile;

	private float homingAttackChance;

	public float explosiveCooldown;

	public GameObject explosiveProjectile;

	public float explosiveProjectileLaunchVelocity;

	public GameObject slamExplosion;

	private SwingCheck2[] swingChecks;

	private float swingCooldown;

	private bool attackedOnce;

	private float playerDistanceCooldown;

	public Transform tailEnd;

	private GameObject tailSpear;

	private float spearCooldown;

	public GameObject spear;

	public bool spearShot;

	public GameObject spearFlash;

	public GameObject tempSpear;

	public List<GameObject> tailHitboxes;

	public GameObject regurgitateSound;

	public GameObject bigPainSound;

	public GameObject windupSound;

	public bool dead;

	public bool crazyMode;

	public float crazyModeHealth;

	private Enemy stat;

	public EnemyIdentifier eid;

	private int crazyPoint;

	public GameObject enrageEffect;

	public GameObject currentEnrageEffect;

	public Material enrageMaterial;

	public GameObject[] activateOnEnrage;

	private int difficulty;

	private VisionQuery targetQuery;

	private TargetHandle targetHandle;

	private TargetData lastTargetData;

	public bool isDead;

	private bool hasVision => false;

	private List<Transform> transforms => null;

	private GoreZone gz => null;

	private BloodsplatterManager bsm => null;

	public override bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateBuff()
	{
	}

	private void SetSpeed()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void UpdateVision()
	{
	}

	private void RotateToTarget()
	{
	}

	private void UpdateCooldowns()
	{
	}

	private void ChooseAction()
	{
	}

	private bool SpearCanBeActive()
	{
		return false;
	}

	private bool ShouldBattleSlam()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	public void HomingAttack()
	{
	}

	public void ExplosiveAttack()
	{
	}

	public void SwingAttack()
	{
	}

	public void ToScout()
	{
	}

	public void ToBattle()
	{
	}

	private void SlamWindup()
	{
	}

	public void SlamImpact()
	{
	}

	public void ShootHoming(int arm)
	{
	}

	public void ShootExplosive(int arm)
	{
	}

	private void ShootProjectile(int arm, GameObject projectile, float velocity)
	{
	}

	private void ReadySpear()
	{
	}

	public void ShootSpear()
	{
	}

	public void SpearParried()
	{
	}

	public void SpearReturned()
	{
	}

	public void StopAction()
	{
	}

	public void BattleSlam()
	{
	}

	public void SwingStart()
	{
	}

	public void SwingEnd()
	{
	}

	public void Enrage()
	{
	}

	public void CrazyReady()
	{
	}

	public void CrazyShoot()
	{
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}
}
