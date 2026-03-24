using System;
using System.Collections.Generic;

[ConfigureSingleton(SingletonFlags.None)]
public class EnemyTracker : MonoSingleton<EnemyTracker>
{
	public List<EnemyIdentifier> enemies;

	public List<int> enemyRanks;

	public List<Drone> drones;

	public int deathcatcherCount;

	public readonly Dictionary<int, SavedEnemy> spawnedEnemies;

	public static Action<EnemyIdentifier> onEnemyAdded;

	public static Action<EnemyIdentifier> onEnemyRemoved;

	private void Update()
	{
	}

	public List<EnemyIdentifier> GetCurrentEnemies()
	{
		return null;
	}

	public bool TryGetEnemy(int eidInstanceID, out EnemyIdentifier eid, bool includePuppetRespawned = false)
	{
		eid = null;
		return false;
	}

	public bool IsEnemySpawnRecorded(int eidInstanceID)
	{
		return false;
	}

	public void UpdateIdolsNow()
	{
	}

	public List<EnemyIdentifier> GetEnemiesOfType(EnemyType type)
	{
		return null;
	}

	public void AddEnemy(EnemyIdentifier eid)
	{
	}

	public void RemoveEnemy(EnemyIdentifier eid)
	{
	}

	private void RemoveEnemy(int index)
	{
	}

	public int GetEnemyRank(EnemyIdentifier eid)
	{
		return 0;
	}
}
