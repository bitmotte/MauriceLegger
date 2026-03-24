using ULTRAKILL.Portal;
using UnityEngine;

public class PhysicalShockwaveCollisionProxy : MonoBehaviour
{
	public PhysicalShockwave receiver;

	public PortalHandle portalHandle;

	public Transform previousOrigin;

	public Collider collider;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}
}
