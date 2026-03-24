using System.Collections.Generic;
using UnityEngine;

public class BloodAbsorberChild : MonoBehaviour, IBloodstainReceiver
{
	[HideInInspector]
	public BloodAbsorber bloodGroup;

	private MeshRenderer mRend;

	private void Start()
	{
	}

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

	public void ProcessWasherSpray(ref List<ParticleCollisionEvent> pEvents, Vector3 position)
	{
	}

	bool IBloodstainReceiver.HandleBloodstainHit(in RaycastHit hit)
	{
		return false;
	}
}
