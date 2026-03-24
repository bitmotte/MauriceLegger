using ULTRAKILL.Portal.Native;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public struct ParticleIntersectionJob : IJobFor
	{
		[ReadOnly]
		public NativePortalScene scene;

		[NativeDisableContainerSafetyRestriction]
		[ReadOnly]
		public NativeArray<RaycastCommand> rays;

		[NativeDisableContainerSafetyRestriction]
		public NativeArray<IntersectionAndIndex> intersections;

		public void Execute(int index)
		{
		}
	}
}
