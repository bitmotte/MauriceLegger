using UnityEngine;

namespace Gravity
{
	public class GravityVolume : MonoBehaviour
	{
		public bool updateContinuously;

		public bool resetOnExit;

		protected int playerRequests;

		public Vector3 GravityVector => default(Vector3);

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		protected virtual Vector3 CalculateGravityVector()
		{
			return default(Vector3);
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected virtual void OnDrawGizmos()
		{
		}
	}
}
