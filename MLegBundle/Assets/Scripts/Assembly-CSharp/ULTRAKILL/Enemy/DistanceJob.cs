using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace ULTRAKILL.Enemy
{
	[BurstCompile]
	public struct DistanceJob : IJobFor
	{
		public int targetCount;

		[ReadOnly]
		public NativeArray<float3> visionOrigins;

		[ReadOnly]
		public NativeArray<VisionTypeFilter> visionFilters;

		[ReadOnly]
		public NativeArray<float3> targetPositions;

		[ReadOnly]
		public NativeArray<TargetType> targetTypes;

		public NativeArray<int> counts;

		[WriteOnly]
		public NativeStream.Writer output;

		public void Execute(int visionIndex)
		{
		}
	}
}
