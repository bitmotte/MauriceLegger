using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ULTRAKILL.Portal;
using UnityEngine;

public class Zapper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CZapNextFrame_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Zapper _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CZapNextFrame_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private LineRenderer lr;

	private Rigidbody rb;

	private AudioSource aud;

	[HideInInspector]
	public float damage;

	[HideInInspector]
	public GameObject sourceWeapon;

	public Transform lineStartTransform;

	public Rigidbody connectedRB;

	private ConfigurableJoint joint;

	[SerializeField]
	private GameObject openProngs;

	[SerializeField]
	private GameObject closedProngs;

	public float maxDistance;

	[HideInInspector]
	public float distance;

	[HideInInspector]
	public float charge;

	[HideInInspector]
	public float breakTimer;

	[HideInInspector]
	public bool raycastBlocked;

	private bool broken;

	public bool attached;

	public EnemyIdentifier attachedEnemy;

	public EnemyIdentifierIdentifier hitLimb;

	[SerializeField]
	private GameObject attachSound;

	[SerializeField]
	private Transform lightningPulseOrb;

	private LineRenderer pulseLine;

	[SerializeField]
	private GameObject zapParticle;

	[SerializeField]
	private AudioSource[] distanceWarningSounds;

	[SerializeField]
	private AudioSource cableSnap;

	[SerializeField]
	private AudioSource boostSound;

	[SerializeField]
	private GameObject breakParticle;

	private readonly List<PortalTraversalV2> portalTraversals;

	private LineRendererPortalHelper lineRendererPortalHelper;

	private bool portalJointBroken;

	private float jointLimit;

	private int playerAddedTraversals;

	[Header("Portal Settings")]
	[SerializeField]
	private float portalEdgeMargin;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPlayerPortalTraversed(PortalTravelDetails details)
	{
	}

	[IteratorStateMachine(typeof(_003CZapNextFrame_003Ed__38))]
	private IEnumerator ZapNextFrame()
	{
		return null;
	}

	private void Update()
	{
	}

	private Vector3 GetPositionAlongCable(float t, out Vector3 segmentStart)
	{
		segmentStart = default(Vector3);
		return default(Vector3);
	}

	private float GetTotalLineDistance()
	{
		return 0f;
	}

	private bool CheckLineOfSight()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private void RecalculatePortalIntersections(bool allowMigration = true)
	{
	}

	private bool TryMigrateToAdjacentPortal(int traversalIndex, Vector3 segmentStart, Vector3 direction, float portalPlaneDistance)
	{
		return false;
	}

	private Vector3 ClampToPortalBounds(Portal portal, PortalSide side, Vector3 worldPoint, out bool wasClamped)
	{
		wasClamped = default(bool);
		return default(Vector3);
	}

	private Vector3 ClampToPortalBounds(Portal portal, PortalSide side, Vector3 worldPoint)
	{
		return default(Vector3);
	}

	private void ResetPortalTraversals()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void CheckAttach(Collider other, Vector3 position)
	{
	}

	private void Zap()
	{
	}

	public void Break(bool successful = false)
	{
	}

	public void ChargeBoost(float amount)
	{
	}
}
