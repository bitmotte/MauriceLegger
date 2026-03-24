using System.Collections.Generic;
using UnityEngine;

public class WallCheckGroup : MonoBehaviour
{
	[SerializeField]
	private List<WallCheck> instances;

	public void AddInstance(WallCheck instance)
	{
	}

	public void RemoveInstance(WallCheck instance)
	{
	}

	public bool TryGetActiveInstance(out WallCheck instance)
	{
		instance = null;
		return false;
	}

	public bool CheckForCols()
	{
		return false;
	}

	public bool OnWall()
	{
		return false;
	}

	public bool CheckForEnemyCols()
	{
		return false;
	}

	private bool IsInstanceValid(WallCheck instance)
	{
		return false;
	}
}
