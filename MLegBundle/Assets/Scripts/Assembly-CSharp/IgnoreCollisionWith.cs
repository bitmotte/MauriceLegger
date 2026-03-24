using UnityEngine;

public class IgnoreCollisionWith : MonoBehaviour
{
	[HideInInspector]
	public bool gotValues;

	[HideInInspector]
	public Collider[] cols;

	[HideInInspector]
	private bool ignoring;

	public Collider[] targets;

	public bool includeOwnChildren;

	private void Awake()
	{
	}

	private void GetValues()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Ignore(bool ignore)
	{
	}
}
