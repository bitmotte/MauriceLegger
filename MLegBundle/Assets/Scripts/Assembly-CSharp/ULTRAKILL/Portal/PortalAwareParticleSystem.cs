using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(ParticleSystem))]
	public sealed class PortalAwareParticleSystem : MonoBehaviour
	{
		private const ParticleSystemCustomData CustomDataStream = ParticleSystemCustomData.Custom1;

		public bool raycastCollision;

		public Bloodsplatter blood;

		public ParticleSystem _system;

		private PortalManagerV2 portalManager;

		public JobHandle responseHandle;

		public float4x4 toWorld;

		public float4x4 toLocal;

		public NativeArray<float4> trailPositions;

		private GCHandle gcHandle;

		private void OnParticleUpdateJobScheduled()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
