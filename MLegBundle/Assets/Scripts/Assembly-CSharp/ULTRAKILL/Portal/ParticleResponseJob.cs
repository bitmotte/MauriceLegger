using Interop;
using ULTRAKILL.Portal.Native;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public struct ParticleResponseJob : IJobParticleSystem
	{
		public float4x4 toLocal;

		public float4x4 toWorld;

		[ReadOnly]
		public NativePortalScene scene;

		[NativeDisableContainerSafetyRestriction]
		[ReadOnly]
		public NativeSlice<IntersectionAndIndex> intersections;

		[NativeDisableContainerSafetyRestriction]
		[ReadOnly]
		public NativeSlice<RaycastHit> hits;

		[NativeDisableUnsafePtrRestriction]
		public unsafe ParticleTrails* trails;

		public void Execute(ParticleSystemJobData jobData)
		{
		}
	}
}
