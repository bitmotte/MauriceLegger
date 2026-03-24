using UnityEngine;

public class FinalPit : MonoBehaviour
{
	private NewMovement nmov;

	private StatsManager sm;

	private Rigidbody rb;

	private bool rotationReady;

	private GameObject player;

	private bool infoSent;

	public bool rankless;

	public bool secondPit;

	public bool fakeEnd;

	public string targetLevelName;

	private int levelNumber;

	public bool musicFadeOut;

	private Quaternion targetRotation;

	public bool upsideDownFinishChallenge;

	private Quaternion currentWorldRotation;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void SendInfo()
	{
	}
}
