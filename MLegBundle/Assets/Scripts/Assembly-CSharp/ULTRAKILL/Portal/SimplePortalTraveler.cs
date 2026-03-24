using System;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class SimplePortalTraveler : MonoBehaviour, IPortalTraveller
	{
		[Header("Transforms")]
		public bool transformPosition;

		public bool transformRotation;

		public bool transformVelocity;

		[Header("Extras")]
		public bool clearTrail;

		[HideInInspector]
		public Rigidbody rb;

		[HideInInspector]
		public TrailRenderer trail;

		private PortalManagerV2 pm;

		public PortalManagerV2.TravelCallback onTravel;

		public Func<PortalTravelDetails, bool?> onTravelOverride;

		public PortalManagerV2.TravelCallback onTravelBlocked;

		private Vector3 cachedRbPos;

		private Vector3 cachedRbVel;

		public PortalTravellerType travellerType { get; private set; }

		public int id => 0;

		public int? targetId { get; set; }

		public Vector3 travellerPosition => default(Vector3);

		public Vector3 travellerVelocity => default(Vector3);

		public void SetType(PortalTravellerType type)
		{
		}

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CacheTravelerValues()
		{
		}

		public bool? OnTravel(PortalTravelDetails details)
		{
			return null;
		}

		public void Travel(PortalTravelDetails details)
		{
		}

		public void OnTeleportBlocked(PortalTravelDetails details)
		{
		}
	}
}
