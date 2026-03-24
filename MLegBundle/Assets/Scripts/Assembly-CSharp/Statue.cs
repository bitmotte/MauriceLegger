using UnityEngine;

public class Statue : Enemy
{
	protected override void FixedUpdate()
	{
	}

	public override void GetHurt(GameObject target, Vector3 force, float multiplier, float critMultiplier, Vector3 hurtPos, GameObject sourceWeapon = null, bool fromExplosion = false)
	{
	}

	public override void ParryableCheck(bool partial = false)
	{
	}
}
