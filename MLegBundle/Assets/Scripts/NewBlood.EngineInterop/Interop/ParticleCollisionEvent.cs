using UnityEngine;

namespace Interop
{
	public struct ParticleCollisionEvent
	{
		[NativeTypeName("Vector3f")]
		public Vector3 m_Intersection;

		[NativeTypeName("Vector3f")]
		public Vector3 m_Normal;

		[NativeTypeName("Vector3f")]
		public Vector3 m_Velocity;

		public int m_ColliderInstanceID;

		public int m_RigidBodyOrColliderInstanceID;
	}
}
