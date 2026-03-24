using UnityEngine;

public class FinalDoorOpener : MonoBehaviour
{
	public bool startTimer;

	public bool startMusic;

	[HideInInspector]
	public bool opened;

	private bool opening;

	private bool closed;

	private FinalDoor fd;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void GoTime()
	{
	}

	public void Close()
	{
	}
}
