using Unity.Mathematics;

namespace ULTRAKILL.Portal.Native
{
	public struct PortalRay
	{
		public float3 start;

		public float3 direction;

		public float distanceSq;

		public PortalRay(float3 start, float3 end)
		{
			this.start = default(float3);
			direction = default(float3);
			distanceSq = 0f;
		}

		public PortalRay(float3 start, float3 direction, float distance)
		{
			this.start = default(float3);
			this.direction = default(float3);
			distanceSq = 0f;
		}
	}
}
