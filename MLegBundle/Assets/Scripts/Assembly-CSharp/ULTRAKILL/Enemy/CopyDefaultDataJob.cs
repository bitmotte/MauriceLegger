using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace ULTRAKILL.Enemy
{
	[BurstCompile]
	public struct CopyDefaultDataJob : IJobFor
	{
		public int stride;

		[ReadOnly]
		public TargetDataArrays defaults;

		public TargetDataArrays targets;

		public void Execute(int index)
		{
		}
	}
}
