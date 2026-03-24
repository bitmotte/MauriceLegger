using ULTRAKILL.Portal;
using UnityEngine;
using UnityEngine.AI;

public class GroundWave : MonoBehaviour
{
	private NavMeshAgent nma;

	private AudioSource aud;

	private float originalPitch;

	public EnemyTarget target;

	public float lifetime;

	public float fadeOutSpeed;

	public float speedMultiplier;

	public bool startAtFullSpeed;

	public float fadeOutTime;

	private float currentFadeOutTime;

	private Vector3 originalScale;

	[SerializeField]
	private HurtZone hurtzone;

	[SerializeField]
	private Transform faceDirection;

	[HideInInspector]
	public EnemyIdentifier eid;

	[HideInInspector]
	public int difficulty;

	private Animator anim;

	private bool inGrabRange;

	private SimplePortalTraveler portalTraveler;

	private Rigidbody rb;

	private bool isTraversingLink;

	private bool hasCrossed;

	private Vector3 traversalVelocity;

	private float traversalSpeed;

	private float postTeleportDistance;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnPortalTravel(in PortalTravelDetails details)
	{
	}

	public void TrackTick()
	{
	}

	public void Disappear()
	{
	}

	public void DisappearWithSpeed(float newFadeOutSpeed = 1f)
	{
	}

	public void DisappearOnAndBelowDifficulty(int diff)
	{
	}
}
