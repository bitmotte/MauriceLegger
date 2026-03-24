using UnityEngine;

public class OnLineOfSight : MonoBehaviour
{
	public UltrakillEvent onLineOfSight;

	private Collider col;

	public bool oneTime;

	[HideInInspector]
	public bool activated;

	[HideInInspector]
	public bool beenActivatedOnce;

	public bool disableOnExit;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Activate()
	{
	}

	private void Deactivate()
	{
	}
}
