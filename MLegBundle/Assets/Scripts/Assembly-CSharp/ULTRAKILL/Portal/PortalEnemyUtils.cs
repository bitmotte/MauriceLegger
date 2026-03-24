using ULTRAKILL.Enemy;
using UnityEngine;
using UnityEngine.AI;

namespace ULTRAKILL.Portal
{
	public static class PortalEnemyUtils
	{
		public static bool GetPortalVisionPos(this NavMeshAgent nma, AcquirePortalVisionState state, Vector3 currentPos, out Vector3 closestPos)
		{
			closestPos = default(Vector3);
			return false;
		}

		public static bool CalcNavPosToPortalProjection_TargetWithPortalNormal(Vector3 currentPos, TargetData target, int areaMask, out Vector3 navPos)
		{
			navPos = default(Vector3);
			return false;
		}

		public static bool CalcNavPosToPortalProjection_TargetToPortalCenter(Vector3 currentPos, TargetData target, int areaMask, out Vector3 navPos)
		{
			navPos = default(Vector3);
			return false;
		}

		private static bool FindClosestNavMeshPoint(Vector3 point, int areaMask, out Vector3 navMeshPos)
		{
			navMeshPos = default(Vector3);
			return false;
		}

		public static bool IsTargetInPortalOrth(this TargetData target)
		{
			return false;
		}

		public static bool IsRayObstructedByHitOrPortal(Vector3 origin, Vector3 direction, float distance, int collissionMask, out Vector3 endPos, out Vector3 endDirection, out PortalTraversalV2[] portalTraversals, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
		{
			endPos = default(Vector3);
			endDirection = default(Vector3);
			portalTraversals = null;
			return false;
		}
	}
}
