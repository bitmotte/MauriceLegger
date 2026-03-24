using Unity.Burst;
using Unity.Mathematics;

namespace ULTRAKILL.Portal.Native
{
	[BurstCompile]
	public struct PortalVertices
	{
		public float3 v0;

		public float3 v1;

		public float3 v2;

		public float3 v3;

		public PortalVertices(float4x4 trans, float2 dim)
		{
			v0 = default(float3);
			v1 = default(float3);
			v2 = default(float3);
			v3 = default(float3);
		}

		public bool IsBehindPlane(float3 origin, float3 normal)
		{
			return false;
		}
	}
}
