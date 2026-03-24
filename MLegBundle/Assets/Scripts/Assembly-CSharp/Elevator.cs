using UnityEngine;

public class Elevator : MonoBehaviour
{
	public Transform[] stops;

	public GameObject[] buttons;

	[HideInInspector]
	public int targetStop;

	private bool activated;

	private Rigidbody rb;

	[SerializeField]
	private Door doors;

	[SerializeField]
	private AudioSource moveAud;

	private float moveAudOrigPitch;

	[SerializeField]
	private AudioSource dingAud;

	public float speed;

	private float currentSpeed;

	private bool waitingForDoors;

	private TimeSince doorsFailsafe;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void MoveToFloor(int target)
	{
	}

	public void TeleportToFloor(int target)
	{
	}

	private void UpdateButtons(int target = -1)
	{
	}
}
