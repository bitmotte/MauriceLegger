using System.Collections.Generic;

public class EnemyCooldowns : MonoSingleton<EnemyCooldowns>
{
	public float virtueCooldown;

	public float ferrymanCooldown;

	public Power attackingPower;

	public int previousPowerMove;

	public List<Enemy> currentVirtues;

	public List<Ferryman> ferrymen;

	public List<Power> powers;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SlowUpdate()
	{
	}

	public void PowerAttacking(Power pwr)
	{
	}

	public void PowerAttackEnd()
	{
	}

	public void RefreshPowers()
	{
	}

	public void PrioritizePower(Power pwr)
	{
	}

	public void DeprioritizePower(Power pwr)
	{
	}

	private void ChangePowerPriority(int index, Power pwr)
	{
	}

	public void AddVirtue(Enemy vrt)
	{
	}

	public void RemoveVirtue(Enemy vrt)
	{
	}

	public void AddFerryman(Ferryman fm)
	{
	}

	public void RemoveFerryman(Ferryman fm)
	{
	}

	public void AddPower(Power pwr)
	{
	}

	public void RemovePower(Power pwr)
	{
	}
}
