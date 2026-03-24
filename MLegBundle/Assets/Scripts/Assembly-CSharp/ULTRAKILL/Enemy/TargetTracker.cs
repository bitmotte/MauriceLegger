using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using ULTRAKILL.Portal;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace ULTRAKILL.Enemy
{
	[BurstCompile]
	public class TargetTracker : IDisposable
	{
		internal delegate int CountPermutations_00002B0C_0024PostfixBurstDelegate(int count, int depth);

		internal static class CountPermutations_00002B0C_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static int Invoke(int count, int depth)
			{
				return 0;
			}
		}

		private PortalScene scene;

		public NativeArray<float> distances;

		public NativeArray<bool> valid;

		private TargetDataArrays defaults;

		private TargetDataArrays arrays;

		public readonly List<ITarget> targets;

		public readonly List<ITarget> newTargets;

		public readonly List<ITarget> removalTargets;

		public List<Vision> visions;

		private CalculateTargetDataJob calculateTargetDataJob;

		public JobHandle calculateTargetDataHandle;

		public JobHandle outputVisionHandle;

		private NativeList<TargetIndexAndDistance> targetsList;

		private NativeArray<int> startIndices;

		private NativeArray<int> counts;

		private NativeStream targetStream;

		private NativeArray<float3> visionOrigins;

		private NativeArray<VisionTypeFilter> visionFilters;

		public int targetCount { get; private set; }

		public void SetScene(PortalScene scene)
		{
		}

		public TargetDataRef GetTargetDataRef(Span<float4x4> matricesSpan, Span<PortalHandleSequence> sequenceSpan, int index)
		{
			return default(TargetDataRef);
		}

		private Matrix4x4 GetTravelMatrix(PortalHandleSequence sequence)
		{
			return default(Matrix4x4);
		}

		[BurstCompile]
		private static int CountPermutations(int count, int depth)
		{
			return 0;
		}

		public int IndexFromSequence(NativeList<PortalHandle> handles, PortalHandleSequence sequence)
		{
			return 0;
		}

		public TargetData CalculateData(TargetHandle handle)
		{
			return default(TargetData);
		}

		public TargetDataRef GetDataReference(TargetHandle handle)
		{
			return default(TargetDataRef);
		}

		public void RegisterTarget(ITarget target, CancellationToken token)
		{
		}

		public void RegisterVision(Vision vision, CancellationToken token)
		{
		}

		public void UpdateData()
		{
		}

		private void UpdateTargets()
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static int CountPermutations_0024BurstManaged(int count, int depth)
		{
			return 0;
		}
	}
}
