using UnityEngine;

public class PlayerPusher : MonoBehaviour
{
	public Vector3 force;

	public bool oneTime;

	[HideInInspector]
	public bool activated;

	private void OnTriggerEnter(Collider other)
	{
	}
}
