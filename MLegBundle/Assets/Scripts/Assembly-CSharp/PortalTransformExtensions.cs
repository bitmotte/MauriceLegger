using ULTRAKILL.Portal.Geometry;
using UnityEngine;

public static class PortalTransformExtensions
{
	public static bool IsTilted(this PortalTransform portalTrans)
	{
		return false;
	}

	public static bool IsRotated(this PortalTransform portalTrans)
	{
		return false;
	}

	public static bool IsFacingDown(this PortalTransform portalTrans)
	{
		return false;
	}

	public static bool IsFloor(this PortalTransform transform)
	{
		return false;
	}

	public static Vector3 GetPositionInFrontOfLocalIntersect(this PortalTransform transform, Vector3 localPortalIntersect, float distance)
	{
		return default(Vector3);
	}

	public static Vector3 GetPositionInFront(this PortalTransform transform, Vector3 worldPortalIntersect, float distance)
	{
		return default(Vector3);
	}
}
