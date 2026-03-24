using UnityEngine;

public class BloodDestroyer : MonoBehaviour, IBloodstainReceiver
{
	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public bool HandleBloodstainHit(in RaycastHit hit)
	{
		return false;
	}

	bool IBloodstainReceiver.HandleBloodstainHit(in RaycastHit hit)
	{
		return false;
	}
}
