using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	[DefaultExecutionOrder(1000)]
	public class PortalAwarePlayerCollider : MonoBehaviour
	{
		private class Clone
		{
			public GameObject GameObject;

			public Transform Transform;

			public CapsuleCollider Collider;

			public Rigidbody Rigidbody;

			public PortalAwarePlayerColliderClone ColliderClone;

			public WallCheck WallCheck;

			public ClimbStep ClimbStep;

			public bool WasActive;
		}

		private static readonly List<PortalHandle> reusablePortalHandles;

		private readonly ConcurrentDictionary<int, Matrix4x4> colliderTravelMatrices;

		private readonly ConcurrentDictionary<int, Plane> colliderPortalPlanes;

		private readonly List<Clone> clones;

		private readonly RaycastHit[] reusableHits;

		private readonly HashSet<PortalHandle> portalsToIgnore;

		private readonly HashSet<int> portalHashCodes;

		private readonly List<(PortalHandle handle, Plane plane)> activePortals;

		private static Comparison<PortalHandle> portalSortComparison;

		private static Vector3 portalSortCenter;

		[SerializeField]
		private CapsuleCollider targetCollider;

		[SerializeField]
		private ClimbStep climbStep;

		[SerializeField]
		private GroundCheckGroup scGroup;

		[SerializeField]
		private GroundCheckGroup gcGroup;

		[SerializeField]
		private WallCheckGroup wcGroup;

		[SerializeField]
		private WallCheck wcTemplate;

		[SerializeField]
		private GroundCheck gcTemplate;

		[SerializeField]
		private GroundCheck scTemplate;

		[SerializeField]
		private LayerMask blockerLayerMask;

		private Rigidbody rb;

		public void IgnorePortalHandle(PortalHandle handle)
		{
		}

		public bool TryGetCrossingPortal(Vector3 from, Vector3 to, out PortalHandle handle, out Vector3 intersection, out Vector3 portalNormal)
		{
			handle = default(PortalHandle);
			intersection = default(Vector3);
			portalNormal = default(Vector3);
			return false;
		}

		private void FixedUpdate()
		{
		}

		private void EnsureClones(int desiredCloneCount)
		{
		}

		private int GetIntersectingPortalHandles(List<PortalHandle> handles)
		{
			return 0;
		}

		private void DeactivateClones()
		{
		}

		private void ActivateClone(Clone clone)
		{
		}

		private void DeactivateClone(Clone clone)
		{
		}

		private void CreateClone()
		{
		}

		private void ApplyCapsuleColliderProperties(CapsuleCollider cc)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void ModifyEvent(PhysicsScene scene, NativeArray<ModifiableContactPair> pairs)
		{
		}
	}
}
