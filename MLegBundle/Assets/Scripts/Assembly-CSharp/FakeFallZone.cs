using UnityEngine;

public class FakeFallZone : MonoBehaviour
{
	private int requests;

	public float heightControlAmount;

	[SerializeField]
	private GameObject freeFallHud;

	public RectTransform freeFallMarker;

	public float markerHeight;

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}
}
