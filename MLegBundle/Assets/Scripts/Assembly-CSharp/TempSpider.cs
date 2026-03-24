public class TempSpider : EnemyScript
{
	private Enemy spiderEnemy;

	public bool knockBack;

	private void Awake()
	{
	}

	public override EnemyMovementData GetSpeed(int difficulty)
	{
		return default(EnemyMovementData);
	}

	public override bool ShouldKnockback(ref DamageData data)
	{
		return false;
	}

	public override void OnDamage(ref DamageData data)
	{
	}

	public override void OnParry(ref DamageData data, bool isShotgun)
	{
	}

	public override void OnGoLimp(bool fromExplosion)
	{
	}

	public override void OnFall()
	{
	}

	public override void OnLand()
	{
	}
}
