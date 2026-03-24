using System.Collections.Generic;
using ULTRAKILL.Portal;
using UnityEngine;

public class ThrownSword : MonoBehaviour
{
	private Rigidbody rb;

	private Collider col;

	public EnemyIdentifier thrownBy;

	public Vector3 targetPos;

	public Transform returnTransform;

	public bool active;

	public float speed;

	private bool returning;

	private bool calledReturn;

	public int type;

	public bool friendly;

	public bool deflected;

	private bool hittingPlayer;

	[HideInInspector]
	public bool thrownAtVoid;

	private TimeSince timeSince;

	private List<EnemyIdentifier> hitEnemies;

	private Stack<PortalHandle> traversedPortals;

	private int difficulty;

	private SimplePortalTraveler portalTraveler;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void OnPortalTraversal(in PortalTravelDetails details)
	{
	}

	public void SetPoints(Vector3 target, Transform origin)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void RecheckPlayerHit()
	{
	}

	private void Return()
	{
	}

	public void GetParried()
	{
	}
}
