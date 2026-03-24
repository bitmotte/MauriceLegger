using UnityEngine;

public class OnCameraVisible : MonoBehaviour
{
	public UltrakillEvent onVisible;

	private Renderer rend;

	private bool isVisible;

	private bool forceFirstCheck;

	private Camera cam;

	private Plane[] frustumPlanes;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
