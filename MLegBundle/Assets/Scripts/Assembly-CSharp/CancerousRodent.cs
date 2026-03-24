using System.Collections.Generic;
using UnityEngine;

public class CancerousRodent : EnemyScript
{
	private Rigidbody rb;

	private Enemy enemy;

	private EnemyIdentifier eid;

	public bool harmless;

	public GameObject[] activateOnDeath;

	public Transform shootPoint;

	public GameObject projectile;

	private float coolDown;

	public int projectileAmount;

	private int currentProjectiles;

	private Vector3 origPos;

	private List<Transform> transforms => null;

	private GoreZone gz => null;

	private BloodsplatterManager bsm => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	private void FireBurst()
	{
	}

	private void HandleDeath()
	{
	}

	private void BloodExplosion()
	{
	}

	protected void OnDestroy()
	{
	}

	protected void DeathEnd()
	{
	}
}
