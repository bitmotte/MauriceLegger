using UnityEngine;

namespace Interop
{
	public struct TransformInfo
	{
		[NativeTypeName("Matrix4x4f")]
		public Matrix4x4 worldMatrix;

		[NativeTypeName("Matrix4x4f")]
		public Matrix4x4 prevWorldMatrix;

		[NativeTypeName("AABB")]
		public Bounds worldAABB;

		[NativeTypeName("AABB")]
		public Bounds localAABB;

		public int motionVectorFrameIndex;

		public TransformType transformType;

		public ushort lateBatchIndex;
	}
}
