using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class PortalParticles : IDisposable
	{
		public PortalScene scene;

		public readonly List<PortalAwareParticleSystem> systems;

		public NativeList<RaycastCommand> commands;

		public NativeList<IntersectionAndIndex> intersections;

		public NativeList<RaycastHit> hits;

		public NativeList<JobHandle> commandJobs;

		public NativeList<BloodsplatterMetadata> bloodMeta;

		public JobHandle createBloodHandle;

		private bool disposed;

		public void Initialize(PortalScene scene)
		{
		}

		public void ScheduleJobs(ref NativeList<JobHandle> portalDependent)
		{
		}

		public void CompleteJobs()
		{
		}

		public void Register(PortalAwareParticleSystem system)
		{
		}

		public void Deregister(PortalAwareParticleSystem system)
		{
		}

		public void Dispose()
		{
		}
	}
}
