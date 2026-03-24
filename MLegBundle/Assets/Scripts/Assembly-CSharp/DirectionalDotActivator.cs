using UnityEngine;

public class DirectionalDotActivator : MonoBehaviour
{
	public Vector3 dotVector;

	public UltrakillEvent onPositive;

	public bool invertOnNegative;

	[HideInInspector]
	public bool currentStatus;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Check(bool force = false)
	{
	}
}
