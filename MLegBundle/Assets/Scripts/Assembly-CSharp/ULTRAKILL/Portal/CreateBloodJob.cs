using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public struct CreateBloodJob : IJobFor
	{
		[ReadOnly]
		public NativeArray<RaycastHit> hits;

		[ReadOnly]
		public NativeArray<IntersectionAndIndex> intersections;

		[ReadOnly]
		public NativeArray<BloodsplatterMetadata> shouldCreate;

		[WriteOnly]
		public NativeQueue<BloodstainCreateCommand>.ParallelWriter queue;

		public void Execute(int index)
		{
		}
	}
}
