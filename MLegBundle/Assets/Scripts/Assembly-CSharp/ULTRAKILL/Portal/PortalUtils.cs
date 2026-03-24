using ULTRAKILL.Portal.Geometry;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public static class PortalUtils
	{
		public static void AddForceAtPositionPortalAware(PhysicsCastResult hit, Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		public static void AddForceAtPositionPortalAware(RaycastHit hit, Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		public static void AddForceAtPositionPortalAware(GameObject obj, Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		public static void AddForcePortalAware(PhysicsCastResult hit, Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public static void AddForcePortalAware(RaycastHit hit, Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public static void AddForcePortalAware(GameObject obj, Vector3 force, ForceMode mode = ForceMode.Force, bool searchParent = false)
		{
		}

		public static Portal GetPortalObject(PortalHandle handle)
		{
			return null;
		}

		public static PortalTransform GetTransform(PortalHandle handle, bool reverseSide)
		{
			return null;
		}

		public static Matrix4x4 GetTravelMatrix(PortalHandle handle)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 GetTravelMatrix(PortalHandleSequence handles)
		{
			return default(Matrix4x4);
		}

		public static Matrix4x4 GetTravelMatrix(PortalTraversalV2[] traversals)
		{
			return default(Matrix4x4);
		}

		public static PortalIdentifier GetPortalIdentifier(this PortalHandle handle)
		{
			return null;
		}

		public static PortalIdentifier GetPortalIdentifier(this PortalScene scene, PortalHandle handle)
		{
			return null;
		}

		public static bool IsPointInFront(this PortalTransform transform, Vector3 point)
		{
			return false;
		}

		public static bool IsInFrontOfPortal(this Vector3 point, PortalTransform transform)
		{
			return false;
		}

		public static bool IsCompletelyInFrontOf(this PortalTransform portal, Collider col)
		{
			return false;
		}

		public static bool IsPartiallyInFrontOf(this Collider col, PortalTransform portal)
		{
			return false;
		}

		public static bool IsCompletelyInFrontOfSphere(this PortalTransform portal, SphereCollider col)
		{
			return false;
		}

		public static bool IsPartiallyInFrontOfSphere(this SphereCollider col, PortalTransform portal)
		{
			return false;
		}

		private static bool IsAnyPointInFront(this PortalTransform portal, Vector3[] points)
		{
			return false;
		}

		private static Vector3[] BoundsToWorldPoints(Bounds bounds)
		{
			return null;
		}

		public static bool FindClosestLinkPositions(this PortalIdentifier portalId, Vector3 point, out Vector3 entryPos, out Vector3 exitPos)
		{
			entryPos = default(Vector3);
			exitPos = default(Vector3);
			return false;
		}

		public static void GenerateLineRendererSegments(this MonoBehaviour caller, LineRenderer lr, PortalTraversalV2[] portalTraversals)
		{
		}
	}
}
