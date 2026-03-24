using System.Collections.Generic;
using UnityEngine;

namespace ULTRAKILL.Portal.Geometry
{
	public struct BoundedPlane
	{
		public Vector3 center;

		public Vector3 normal;

		public Vector3 up;

		public Vector3 right;

		public float width;

		public float height;

		public Vector4 AsNormalDistance => default(Vector4);

		public Vector3[] Vertices => null;

		public BoundedPlane(Transform trans, float width, float height)
		{
			center = default(Vector3);
			normal = default(Vector3);
			up = default(Vector3);
			right = default(Vector3);
			this.width = 0f;
			this.height = 0f;
		}

		public BoundedPlane(Vector3 center, Vector3 normal, Vector3 up, Vector3 right, float width, float height)
		{
			this.center = default(Vector3);
			this.normal = default(Vector3);
			this.up = default(Vector3);
			this.right = default(Vector3);
			this.width = 0f;
			this.height = 0f;
		}

		public bool GetSide(params Vector3[] points)
		{
			return false;
		}

		public bool GetSide(Vector3 point)
		{
			return false;
		}

		public Vector2 ProjectTo2D(Vector3 point)
		{
			return default(Vector2);
		}

		public void ClipNormalizedPolygon(Vector2[] points, ref List<Vector2> clippedVerts)
		{
		}

		public Vector3 UnProjectFrom2D(Vector2 point)
		{
			return default(Vector3);
		}

		public bool Contains(Vector3 point)
		{
			return false;
		}
	}
}
