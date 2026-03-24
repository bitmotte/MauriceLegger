using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace BeamHitInterpolation
{
	[BurstCompile]
	public static class BeamHitInterpolator
	{
		internal delegate void FindBestTimeAndMinDistSq_00002D8C_0024PostfixBurstDelegate(in float3 point, in float3 startA, in float3 endA, in float3 startB, in float3 endB, int iterations, out float bestTime, out float minDistSq);

		internal static class FindBestTimeAndMinDistSq_00002D8C_0024BurstDirectCall
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

			public static void Invoke(in float3 point, in float3 startA, in float3 endA, in float3 startB, in float3 endB, int iterations, out float bestTime, out float minDistSq)
			{
				bestTime = default(float);
				minDistSq = default(float);
			}
		}

		internal delegate float DistanceSqPointSegment_00002D8D_0024PostfixBurstDelegate(in float3 point, in float3 segmentStart, in float3 segmentEnd);

		internal static class DistanceSqPointSegment_00002D8D_0024BurstDirectCall
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

			public static float Invoke(in float3 point, in float3 segmentStart, in float3 segmentEnd)
			{
				return 0f;
			}
		}

		internal delegate void ClosestPointOnSegment_00002D8E_0024PostfixBurstDelegate(in float3 point, in float3 segmentStart, in float3 segmentEnd, out float3 closest);

		internal static class ClosestPointOnSegment_00002D8E_0024BurstDirectCall
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

			public static void Invoke(in float3 point, in float3 segmentStart, in float3 segmentEnd, out float3 closest)
			{
				closest = default(float3);
			}
		}

		internal delegate void CalculateSweptObb_00002D8F_0024PostfixBurstDelegate(in float3 prevOrigin, in float3 prevEnd, in float3 currOrigin, in float3 currEnd, in float radius, out float3 center, out float3 halfExtents, out quaternion orientation);

		internal static class CalculateSweptObb_00002D8F_0024BurstDirectCall
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

			public static void Invoke(in float3 prevOrigin, in float3 prevEnd, in float3 currOrigin, in float3 currEnd, in float radius, out float3 center, out float3 halfExtents, out quaternion orientation)
			{
				center = default(float3);
				halfExtents = default(float3);
				orientation = default(quaternion);
			}
		}

		private const float EpsilonSq = 1E-12f;

		private const float ConvergenceThresholdSq = 1E-06f;

		private const int MaxOverlapResults = 50;

		private const int TimeSearchIterations = 7;

		private const int RefinementIterations = 3;

		private const bool EnableDebugDrawing = false;

		private static readonly Color ObbColor;

		private static readonly Color RayAColor;

		private static readonly Color RayBColor;

		public static void HitInterpolated(Ray rayA, float distanceA, Ray rayB, float distanceB, float beamRadius, LayerMask hitMask, List<InterpolatedHit> results, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
		{
		}

		private static bool ValidateSweptHit(Collider collider, float3 prevOrigin, float3 prevEnd, float3 currOrigin, float3 currEnd, float radius, out float3 finalPointOnCollider, out float3 finalClosestPointOnAxis, out float finalMinDistSq, out float effectiveRadius, out float optimalTime)
		{
			finalPointOnCollider = default(float3);
			finalClosestPointOnAxis = default(float3);
			finalMinDistSq = default(float);
			effectiveRadius = default(float);
			optimalTime = default(float);
			return false;
		}

		[BurstCompile]
		private static void FindBestTimeAndMinDistSq(in float3 point, in float3 startA, in float3 endA, in float3 startB, in float3 endB, int iterations, out float bestTime, out float minDistSq)
		{
			bestTime = default(float);
			minDistSq = default(float);
		}

		[BurstCompile]
		private static float DistanceSqPointSegment(in float3 point, in float3 segmentStart, in float3 segmentEnd)
		{
			return 0f;
		}

		[BurstCompile]
		private static void ClosestPointOnSegment(in float3 point, in float3 segmentStart, in float3 segmentEnd, out float3 closest)
		{
			closest = default(float3);
		}

		[BurstCompile]
		private static void CalculateSweptObb(in float3 prevOrigin, in float3 prevEnd, in float3 currOrigin, in float3 currEnd, in float radius, out float3 center, out float3 halfExtents, out quaternion orientation)
		{
			center = default(float3);
			halfExtents = default(float3);
			orientation = default(quaternion);
		}

		private static InterpolatedHit CreateInterpolatedHit(Collider collider, float3 finalPointOnCollider, float3 finalClosestPointOnAxis, float finalMinDistSq)
		{
			return null;
		}

		[Conditional("UNITY_EDITOR")]
		private static void DrawObbDebug(float3 center, float3 halfExtents, quaternion orientation)
		{
		}

		[Conditional("UNITY_EDITOR")]
		private static void DrawRaysDebug(float3 originA, float3 endA, float3 originB, float3 endB)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void FindBestTimeAndMinDistSq_0024BurstManaged(in float3 point, in float3 startA, in float3 endA, in float3 startB, in float3 endB, int iterations, out float bestTime, out float minDistSq)
		{
			bestTime = default(float);
			minDistSq = default(float);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static float DistanceSqPointSegment_0024BurstManaged(in float3 point, in float3 segmentStart, in float3 segmentEnd)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void ClosestPointOnSegment_0024BurstManaged(in float3 point, in float3 segmentStart, in float3 segmentEnd, out float3 closest)
		{
			closest = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateSweptObb_0024BurstManaged(in float3 prevOrigin, in float3 prevEnd, in float3 currOrigin, in float3 currEnd, in float radius, out float3 center, out float3 halfExtents, out quaternion orientation)
		{
			center = default(float3);
			halfExtents = default(float3);
			orientation = default(quaternion);
		}
	}
}
