using ULTRAKILL.Portal.Native;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public struct PortalVisionJob : IJobFor
	{
		[ReadOnly]
		public NativeArray<PortalHandle> handles;

		[ReadOnly]
		public NativeArray<float4x4> transforms;

		[ReadOnly]
		public NativeArray<PortalVertices> verts;

		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<bool> visionPossible;

		public void Execute(int index)
		{
		}
	}
}
