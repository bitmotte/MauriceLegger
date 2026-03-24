using System.Collections.Generic;
using ULTRAKILL.Portal;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;
using plog;

public static class PortalPhysicsV2
{
	private static readonly plog.Logger Log;

	private static readonly PortalTraversalV2[] EmptyTraversals;

	private static readonly ICastable RaycastCastable;

	private static List<PortalTraversalV2> traversalsList;

	private static List<(PortalHandle, Vector3, float)> datas;

	public static bool ProjectThroughPortals(Vector3 startPos, Vector3 direction, int layerMask, out PhysicsCastResult hit, out Vector3 endPoint, out PortalTraversalV2[] traversals)
	{
		hit = default(PhysicsCastResult);
		endPoint = default(Vector3);
		traversals = null;
		return false;
	}

	public static void ProjectThroughPortals(PortalScene scene, Vector3 startPos, Vector3 endPos, out Vector3 endPoint, out Quaternion endRotation, out PortalTraversalV2[] traversals)
	{
		endPoint = default(Vector3);
		endRotation = default(Quaternion);
		traversals = null;
	}

	public static void ProjectThroughPortals(Vector3 startPos, Vector3 endPos, out Vector3 endPoint, out Quaternion endRotation, out PortalTraversalV2[] traversals)
	{
		endPoint = default(Vector3);
		endRotation = default(Quaternion);
		traversals = null;
	}

	public static void ProjectThroughPortals(Vector3 startPos, Vector3 endPos, out Vector3 endPoint, out Quaternion endRotation)
	{
		endPoint = default(Vector3);
		endRotation = default(Quaternion);
	}

	public static bool SphereCast(Vector3 origin, Vector3 direction, float maxDistance, float radius, int layerMask, out PhysicsCastResult hitInfo, out PortalTraversalV2[] portalTraversals, out Vector3 endPoint, bool ignorePortalMargin = true, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		hitInfo = default(PhysicsCastResult);
		portalTraversals = null;
		endPoint = default(Vector3);
		return false;
	}

	public static PhysicsCastResult[] SphereCastAll(Vector3 origin, Vector3 direction, float maxDistance, float radius, int layerMask, out PortalTraversalV2[] portalTraversals, out Vector3 endPoint, bool ignorePortalMargin = true, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		portalTraversals = null;
		endPoint = default(Vector3);
		return null;
	}

	public static bool IsInPortalGeometryMargin(Portal portal, PortalSide side, Vector3 worldIntersect, float margin = 0f)
	{
		return false;
	}

	public static bool IsInPortalShapeMargin(PlaneShape shape, Vector3 localIntersect, float margin = 0f)
	{
		return false;
	}

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		return false;
	}

	public static bool Raycast(Vector3 origin, Vector3 direction, out PhysicsCastResult hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		hitInfo = default(PhysicsCastResult);
		return false;
	}

	public static bool Raycast(Vector3 origin, Vector3 direction, out PhysicsCastResult hitInfo, out Vector3 endPoint, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		hitInfo = default(PhysicsCastResult);
		endPoint = default(Vector3);
		return false;
	}

	public static bool Raycast(PortalScene scene, Vector3 origin, Vector3 direction, float maxDistance, int layerMask, out PhysicsCastResult hitInfo, out PortalTraversalV2[] portalTraversals, out Vector3 endPoint, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		hitInfo = default(PhysicsCastResult);
		portalTraversals = null;
		endPoint = default(Vector3);
		return false;
	}

	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, out PhysicsCastResult hitInfo, out PortalTraversalV2[] portalTraversals, out Vector3 endPoint, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		hitInfo = default(PhysicsCastResult);
		portalTraversals = null;
		endPoint = default(Vector3);
		return false;
	}

	public static bool Raycast(PortalCastStateV2 state, out PortalTraversalV2[] portalTraversals, out PhysicsCastResult result, out Vector3 endPoint)
	{
		portalTraversals = null;
		result = default(PhysicsCastResult);
		endPoint = default(Vector3);
		return false;
	}

	public static PhysicsCastResult[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, out PortalTraversalV2[] portalTraversals, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		portalTraversals = null;
		return null;
	}

	public static PhysicsCastResult[] RaycastAll(PortalCastStateV2 state, out PortalTraversalV2[] portalTraversals)
	{
		portalTraversals = null;
		return null;
	}

	public static Vector3 Offset(Vector3 origin, Vector3 offset, out PortalHandle handle)
	{
		handle = default(PortalHandle);
		return default(Vector3);
	}

	internal static bool PortalCast(PortalScene scene, ICastable castable, PortalCastStateV2 state, out PortalTraversalV2[] portalTraversals, out PhysicsCastResult result, out Vector3 endPoint)
	{
		portalTraversals = null;
		result = default(PhysicsCastResult);
		endPoint = default(Vector3);
		return false;
	}

	internal static PhysicsCastResult[] PortalCastAll(ICastable castable, PortalCastStateV2 state, out PortalTraversalV2[] portalTraversals)
	{
		portalTraversals = null;
		return null;
	}
}
