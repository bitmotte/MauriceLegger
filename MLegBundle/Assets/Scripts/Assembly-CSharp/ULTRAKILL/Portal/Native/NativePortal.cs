using Unity.Burst;
using Unity.Mathematics;

namespace ULTRAKILL.Portal.Native
{
	[BurstCompile]
	public struct NativePortal
	{
		public static readonly float4x4 ScaleMatrix;

		public PortalHandle handle;

		public float2 dimensions;

		public NativePortalTransform transform;

		public PortalVertices vertices;

		public float4x4 travelMatrix;
	}
}
