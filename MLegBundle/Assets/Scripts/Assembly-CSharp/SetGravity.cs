using UnityEngine;

public class SetGravity : MonoBehaviour
{
	public Vector3 target;

	public bool oneTime;

	[HideInInspector]
	public bool activated;

	public bool activateOnEnable;

	public bool deactivateOnDisable;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Activate()
	{
	}

	public void Revert()
	{
	}
}
