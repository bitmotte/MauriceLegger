using UnityEngine;

public class Machine : Enemy
{
	public Gutterman gm;

	protected override void Update()
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void GetHurt(GameObject target, Vector3 force, float multiplier, float critMultiplier, Vector3 hurtPos = default(Vector3), GameObject sourceWeapon = null, bool fromExplosion = false)
	{
	}

	public override void ParryableCheck(bool partial = false)
	{
	}
}
