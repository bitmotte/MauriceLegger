using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ULTRAKILL.Enemy;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.LowLevel;

namespace ULTRAKILL.Portal
{
	[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
	[RequireComponent(typeof(PortalRenderV2))]
	[DefaultExecutionOrder(999)]
	public class PortalManagerV2 : MonoSingleton<PortalManagerV2>
	{
		public delegate void TravelCallback(in PortalTravelDetails details);

		public static class PrintDefaultPlayerLoop
		{
			[RuntimeInitializeOnLoadMethod]
			private static void AppStart()
			{
			}

			private static void RecursivePlayerLoopPrint(PlayerLoopSystem playerLoopSystem, StringBuilder sb, int depth)
			{
			}
		}

		[BurstCompile]
		private struct CopyTransformsJob : IJobParallelForTransform
		{
			[WriteOnly]
			public NativeArray<TransformData> TransformData;

			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		[BurstCompile]
		private struct ApplyTransformsJob : IJobParallelForTransform
		{
			[ReadOnly]
			public NativeArray<TransformData> TransformData;

			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		private struct TransformData
		{
			public float3 Position;

			public quaternion Rotation;

			public bool Valid;
		}

		public int maxRecursions;

		public Camera mainCamera;

		public Camera portalCamera;

		[HideInInspector]
		public PortalRenderV2 render;

		public Action<IPortalTraveller, PortalTravelDetails> OnTargetTravelled;

		private LayerMask empty_lm;

		private List<IPortalTraveller> travellers;

		private Dictionary<int, Vector3> lastTravellerPositions;

		private List<Portal> portalComponents;

		private readonly Dictionary<Transform, int> parTransformKeys;

		private readonly Dictionary<Transform, int> parTargetTransformKeys;

		private TransformAccessArray parTransformAccess;

		private TransformAccessArray parTargetTransformAccess;

		private Transform[] parTransforms;

		private Transform[] parTargetTransforms;

		private IPortalTraveller playerTraveller;

		public List<PortalAwareParticleSystem> systems;

		public NativeList<JobHandle> jobHandles;

		public NativeList<RaycastCommand> commands;

		private List<(IPortalTraveller traveller, PortalTravelDetails details)> travellerTraversals;

		private bool initialized;

		public PortalScene Scene { get; private set; }

		public TargetTracker TargetTracker { get; private set; }

		public PortalNavigation Navigation { get; private set; }

		public PortalParticles Particles { get; private set; }

		public event Action<Camera> RenderFrom
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Reset()
		{
		}

		private void OnDisable()
		{
		}

		public void AddTraveller(IPortalTraveller traveller, CancellationToken token)
		{
		}

		public void AddPlayer(IPortalTraveller traveller)
		{
		}

		public void RemoveTraveller(IPortalTraveller traveller)
		{
		}

		public void UpdateTraveller(IPortalTraveller traveller)
		{
		}

		public void AddTransformAccessPair(Transform clone, Transform target)
		{
		}

		public void RemoveTransformAccessPair(Transform clone)
		{
		}

		private void TraverseAndCallBack(in IPortalTraveller traveller, in PortalTravelDetails details)
		{
		}

		public void TravellerCallback(in IPortalTraveller traveller, in PortalTravelDetails details)
		{
		}

		private void Update()
		{
		}

		private void OnParticleUpdateJobScheduled()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePortalAwareRenderers()
		{
		}

		private void CheckTravellerTraversals(List<(IPortalTraveller, PortalTravelDetails)> traversalCallbacks)
		{
		}

		private bool CheckPlayerTraversals(out (IPortalTraveller traveller, PortalTravelDetails details) result)
		{
			result = default((IPortalTraveller, PortalTravelDetails));
			return false;
		}

		private void OnPreRenderCallback(Camera cam)
		{
		}

		private void Reinitialize(bool resize)
		{
		}

		internal void InitCam()
		{
		}

		public void AddPortal(Portal portal)
		{
		}

		internal void SetPortalOcclusion(bool enabled)
		{
		}
	}
}
