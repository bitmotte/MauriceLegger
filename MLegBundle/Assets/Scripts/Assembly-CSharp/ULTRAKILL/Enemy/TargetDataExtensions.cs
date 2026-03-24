using UnityEngine;

namespace ULTRAKILL.Enemy
{
	public static class TargetDataExtensions
	{
		public static TargetData ToData(this TargetDataRef src)
		{
			return default(TargetData);
		}

		public static float SqrDist(this TargetDataRef @this, Vector3 point)
		{
			return 0f;
		}

		public static float DistanceTo(this TargetDataRef @this, Vector3 point)
		{
			return 0f;
		}

		public static bool IsObstructed(this TargetDataRef @this, Vector3 point, LayerMask layerMask, bool toHead = false)
		{
			return false;
		}

		public static bool IsObstructed(this TargetDataRef @this, Vector3 point, LayerMask layerMask, bool toHead, out PhysicsCastResult obstructionResult)
		{
			obstructionResult = default(PhysicsCastResult);
			return false;
		}

		public static bool IsObstructed(this TargetDataRef @this, Vector3 point, LayerMask layerMask, bool toHead, out PhysicsCastResult obstructionResult, out PortalTraversalV2[] traversals)
		{
			obstructionResult = default(PhysicsCastResult);
			traversals = null;
			return false;
		}

		public static Vector3 PredictTargetPosition(this TargetData data, float time, bool includeGravity = false, bool assumeGroundMovement = false)
		{
			return default(Vector3);
		}

		public static Vector3 PredictTargetPosition(this TargetDataRef data, float time, bool includeGravity = false, bool assumeGroundMovement = false)
		{
			return default(Vector3);
		}

		public static Vector3 PredictTargetPosition(ITarget target, in Vector3 position, in Matrix4x4 portalMatrix, in Vector3 velocity, float time, bool includeGravity = false, bool assumeGroundMovement = false)
		{
			return default(Vector3);
		}
	}
}
