using UnityEngine;

namespace ULTRAKILL.Portal.Geometry
{
	public class PortalTransform
	{
		public Vector3 center;

		public Vector3 forward;

		public Vector3 up;

		public Vector3 right;

		public Vector3 left;

		public Vector3 down;

		public Vector3 back;

		public Matrix4x4 toLocal;

		public Matrix4x4 toWorld;

		public PortalTransform()
		{
		}

		public PortalTransform(Matrix4x4 toLocal, Matrix4x4 toWorld)
		{
		}

		public unsafe ref readonly Matrix4x4 GetMatrix(bool toWorld)
		{
			return ref *(Matrix4x4*)null;
		}

		public void UpdateTransform(ref Matrix4x4 entryToLocal, ref Matrix4x4 entryToWorld)
		{
		}

		public Vector3 WorldToLocal(Vector3 world)
		{
			return default(Vector3);
		}

		public Vector3 LocalToWorld(Vector3 local)
		{
			return default(Vector3);
		}

		public bool HasMovedForward(PortalTransform other)
		{
			return false;
		}

		internal void CopyFrom(PortalTransform copyTransform)
		{
		}
	}
}
