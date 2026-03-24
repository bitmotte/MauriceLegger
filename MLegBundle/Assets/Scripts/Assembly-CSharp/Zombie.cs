using UnityEngine;

public class Zombie : Enemy
{
	protected ZombieMelee zm => null;

	public ZombieProjectiles zp => null;

	protected override void SetSpeed()
	{
	}

	protected override void Update()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void GetHurt(GameObject target, Vector3 force, float multiplier, float critMultiplier, Vector3 hurtPos = default(Vector3), GameObject sourceWeapon = null, bool fromExplosion = false)
	{
	}

	public override void ChestExplodeEnd()
	{
	}

	public override void ChestExplosion(bool cut = false, bool fromExplosion = false)
	{
	}

	public override void Cut(GameObject target)
	{
	}

	public override void ParryableCheck(bool partial = false)
	{
	}
}
