using UnityEngine;

namespace Gravity
{
	public class GradualGravityVolume : GravityVolume
	{
		public Vector3 customGravityDown;

		public Vector3 proprotionalAxis;

		private void Update()
		{
		}

		protected override Vector3 CalculateGravityVector()
		{
			return default(Vector3);
		}

		protected override void OnDrawGizmos()
		{
		}
	}
}
