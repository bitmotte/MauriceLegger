using ULTRAKILL.Portal;
using UnityEngine;

public static class PortalTraversalExtensions
{
	public static Vector3 GetPositionInFront(this PortalTraversalV2 trav, float distance)
	{
		return default(Vector3);
	}

	public static bool AllHasFlag(this PortalTraversalV2[] arr, PortalTravellerFlags flag)
	{
		return false;
	}

	public static bool AllHasFlag(this PortalTraversalV2[] arr, PortalTravellerFlags flag, out bool blocked)
	{
		blocked = default(bool);
		return false;
	}
}
