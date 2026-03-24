using System.Runtime.InteropServices;
using UnityEngine;

namespace Interop
{
	public struct BatchedColliderResult
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct RigidBodyUnion
		{
			[FieldOffset(0)]
			public unsafe Rigidbody* rigidBody;

			[FieldOffset(0)]
			public unsafe Rigidbody2D* rigidBody2D;
		}

		public Vector3 impactForce;

		public Vector3 forcePosition;

		public RigidBodyUnion anon;
	}
}
