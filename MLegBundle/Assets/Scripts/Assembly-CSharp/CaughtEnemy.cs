using UnityEngine;

public class CaughtEnemy
{
	public EnemyIdentifier original;

	public SavedEnemy savedEnemy;

	public Vector3 position;

	public Quaternion rotation;

	public GameObject puppet;

	public CaughtEnemy(EnemyIdentifier newOriginal, SavedEnemy newSaved)
	{
	}

	public void UpdatePosition(Vector3 newPosition, Quaternion newRotation)
	{
	}

	public void UpdatePuppet(GameObject newPuppet)
	{
	}
}
