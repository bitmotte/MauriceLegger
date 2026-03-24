using System;
using System.Collections.Generic;
using ULTRAKILL.Enemy;
using UnityEngine;

public class ProjectileSpread : MonoBehaviour
{
	private GameObject projectile;

	public float spreadAmount;

	public int projectileAmount;

	public float timeUntilDestroy;

	public bool parried;

	public bool dontSpawn;

	[Obsolete("This field is obsolete. Use targetHandle instead.")]
	public EnemyTarget target;

	public TargetHandle targetHandle;

	[HideInInspector]
	public List<EnemyIdentifier> hitEnemies;

	private void Start()
	{
	}

	public void ParriedProjectile()
	{
	}

	private void NoLongerParried()
	{
	}

	private void Remove()
	{
	}
}
