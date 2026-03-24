using UnityEngine;

public class EnemyIdentifierIdentifier : MonoBehaviour
{
	[HideInInspector]
	public EnemyIdentifier eid;

	private bool deactivated;

	private Vector3 startPos;

	public int bloodAbsorberCount;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Detach(Transform zone)
	{
	}

	public void GoLimp()
	{
	}

	public void DetachChildren(Transform parent, bool recursive, bool setParent = true)
	{
	}

	public void SetupForHellBath()
	{
	}

	public void Break()
	{
	}

	public void Break(bool reparentToChild = true, bool destroy = false)
	{
	}

	private void DestroyLimbIfNotTouchedBloodAbsorber()
	{
	}

	private void SlowCheck()
	{
	}
}
