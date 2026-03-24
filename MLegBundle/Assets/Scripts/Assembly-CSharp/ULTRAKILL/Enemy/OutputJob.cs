using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace ULTRAKILL.Enemy
{
	[BurstCompile]
	public struct OutputJob : IJobFor
	{
		public NativeStream.Reader output;

		[WriteOnly]
		public NativeList<TargetIndexAndDistance> array;

		public void Execute(int index)
		{
		}
	}
}
