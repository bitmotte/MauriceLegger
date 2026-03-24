using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace ULTRAKILL.Enemy
{
	[BurstCompile]
	public struct CalculateTargetDataJob : IJobFor
	{
		public int targetCount;

		[ReadOnly]
		public NativeArray<float4x4> matrices;

		public TargetDataArrays arrays;

		public void Execute(int index)
		{
		}
	}
}
