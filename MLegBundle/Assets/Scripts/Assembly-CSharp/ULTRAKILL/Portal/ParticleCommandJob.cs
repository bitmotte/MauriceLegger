using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public struct ParticleCommandJob : IJobParticleSystem
	{
		private PhysicsScene scene;

		public float4x4 toWorld;

		public QueryParameters parameters;

		[NativeDisableContainerSafetyRestriction]
		[WriteOnly]
		public NativeSlice<RaycastCommand> raycasts;

		public void Execute(ParticleSystemJobData jobData)
		{
		}
	}
}
