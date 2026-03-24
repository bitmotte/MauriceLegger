using UnityEngine;

namespace ULTRAKILL.Portal.Geometry
{
	public struct PlaneShape : IPortalShape
	{
		public static readonly Plane LocalPlane;

		public float width;

		public float height;

		public bool IsValid => false;

		public readonly float GetBoundingRadius()
		{
			return 0f;
		}

		public static bool DidCross(in PlaneShape shape, in Vector3 a, in Vector3 b, out Vector3 intersection)
		{
			intersection = default(Vector3);
			return false;
		}

		public bool DidCross(Vector3 a, Vector3 b, out Vector3 intersection)
		{
			intersection = default(Vector3);
			return false;
		}

		public void DrawDebug(PortalTransform trans, float duration = 0f, Color color = default(Color))
		{
		}

		public readonly PortalMeshData GenerateMesh(PortalTransform trans)
		{
			return default(PortalMeshData);
		}

		public readonly Vector3[] GetVertices(PortalTransform trans)
		{
			return null;
		}

		public readonly Vector3 GetClosestLocalPoint(Vector3 point)
		{
			return default(Vector3);
		}
	}
}
