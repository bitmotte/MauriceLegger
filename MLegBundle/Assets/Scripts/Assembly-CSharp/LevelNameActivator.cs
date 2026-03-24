using UnityEngine;

public class LevelNameActivator : MonoBehaviour
{
	private Collider col;

	private bool activateOnCollision;

	public float delay;

	[HideInInspector]
	public bool activated;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void GoTime()
	{
	}
}
