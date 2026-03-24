using UnityEngine;

namespace ULTRAKILL.Portal
{
	public struct PortalTravelDetails
	{
		public PortalHandleSequence portalSequence;

		public PortalTraversalV2[] additionalTraversals;

		public PortalHandle enterHandle;

		public PortalHandle exitHandle;

		public Matrix4x4 enterToExit;

		public bool isIntersectTraversal;

		public Vector3 intersection;

		public bool isLinkTraversal;

		public float navDistance;

		public bool calculateLinkEndPos;

		public bool blocked;

		public static PortalTravelDetails WithInteresction(PortalHandleSequence portalSequence, PortalTraversalV2[] additionalTraversals, Matrix4x4 enterToExit, Vector3 intersection)
		{
			return default(PortalTravelDetails);
		}

		public static PortalTravelDetails WithNavOffset(PortalHandle portalHandle, Matrix4x4 enterToExit, float navDistance, bool calculateLinkEndPos)
		{
			return default(PortalTravelDetails);
		}
	}
}
