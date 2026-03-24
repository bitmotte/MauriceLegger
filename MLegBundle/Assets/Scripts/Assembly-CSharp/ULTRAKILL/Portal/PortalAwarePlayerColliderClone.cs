using UnityEngine;

namespace ULTRAKILL.Portal
{
	[DefaultExecutionOrder(1001)]
	public class PortalAwarePlayerColliderClone : MonoBehaviour
	{
		public Rigidbody TargetRigidbody;

		public Matrix4x4 TravelMatrix;

		public Plane PortalPlane;

		private Vector3 accumulatedVelocityChange;

		private int lastFixedFrame;

		private const float MaxVelocityChangePerFrame = 30f;

		private void OnCollisionStay(Collision collision)
		{
		}
	}
}
