using UnityEngine;

namespace ULTRAKILL.Portal
{
	public static class PortalExtensions
	{
		public static bool HasMovedForward(this Portal portal, PortalSide side)
		{
			return false;
		}

		public static bool IsFacingDown(this Portal portal, PortalSide side)
		{
			return false;
		}

		public static bool IsAnyTransformTilted(this Portal portal)
		{
			return false;
		}

		public static bool IsAnyTransformRotated(this Portal portal)
		{
			return false;
		}

		public static Vector3 AdjustIntercept(this Portal portal, PortalSide side, Vector3 worldIntersect, float padding)
		{
			return default(Vector3);
		}
	}
}
