using System;
using System.Collections.Generic;
using ULTRAKILL.Enemy;
using ULTRAKILL.Portal;
using UnityEngine;

public class MassSpear : MonoBehaviour
{
	[Obsolete]
	public EnemyTarget target;

	public TargetHandle targetHandle;

	private LineRenderer lr;

	private Rigidbody rb;

	public bool hittingPlayer;

	public bool hitPlayer;

	public bool beenStopped;

	private bool returning;

	private bool deflected;

	public Transform originPoint;

	private NewMovement nmov;

	public float spearHealth;

	[HideInInspector]
	public int difficulty;

	public GameObject breakMetalSmall;

	private AudioSource aud;

	public AudioClip hit;

	public AudioClip stop;

	private Mass mass;

	public float speedMultiplier;

	public float damageMultiplier;

	private Stack<PortalHandle> traversedPortals;

	private Vector3 lastPosition;

	private float distanceTravelled;

	private SimplePortalTraveler portalTraveler;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void OnPortalTraversal(in PortalTravelDetails details)
	{
	}

	private void HurtEnemy(GameObject target, EnemyIdentifier eid = null)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DelayedPlayerCheck()
	{
	}

	public void GetHurt(float damage)
	{
	}

	public void Deflected()
	{
	}

	private void Return()
	{
	}

	private void CheckForDistance()
	{
	}
}
