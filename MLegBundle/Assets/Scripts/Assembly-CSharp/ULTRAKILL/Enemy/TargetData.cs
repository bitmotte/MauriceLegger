using ULTRAKILL.Portal;
using UnityEngine;
using System.Runtime.CompilerServices;

namespace ULTRAKILL.Enemy
{
	public struct TargetData
	{
		public static readonly TargetData None;

		public TargetHandle handle;

		public Vector3 position;

		public Vector3 headPosition;

		public Quaternion rotation;

		public Vector3 velocity;

		public Vector3 realPosition;

		public Vector3 realHeadPosition;

		public Matrix4x4 portalMatrix;

		public readonly bool isAcrossPortals => false;

		public readonly ITarget target => null;

		public unsafe ref readonly PortalHandleSequence portals => ref Unsafe.NullRef<PortalHandleSequence>();

		public readonly bool isValid()
		{
			return false;
		}

		public static TargetData For(ref TargetHandle handle)
		{
			return default(TargetData);
		}

		public void ResetToDefault()
		{
		}

		public static implicit operator TargetHandle(TargetData data)
		{
			return null;
		}

		public readonly float DistanceTo(Vector3 point, bool fromHead = false)
		{
			return 0f;
		}

		public readonly bool IsObstructed(Vector3 point, LayerMask layerMask, bool toHead = false)
		{
			return false;
		}

		public readonly bool IsObstructed(Vector3 point, LayerMask layerMask, bool toHead, out PhysicsCastResult obstructionResult, out PortalTraversalV2[] traversals)
		{
			obstructionResult = default(PhysicsCastResult);
			traversals = null;
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
