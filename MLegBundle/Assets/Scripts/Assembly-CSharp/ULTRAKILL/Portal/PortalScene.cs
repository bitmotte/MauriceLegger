using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ULTRAKILL.Portal.Geometry;
using ULTRAKILL.Portal.Native;
using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	[BurstCompile]
	public class PortalScene : IDisposable
	{
		public struct PortalRaySegment
		{
			public PortalHandle handle;

			public float3 start;

			public float3 end;

			public float3 direction;
		}

		internal delegate void CalculateMatrices_000029C3_0024PostfixBurstDelegate(int depth, in NativeArray<NativePortal> singleMatrices, ref NativeArray<float4x4> matrices);

		internal static class CalculateMatrices_000029C3_0024BurstDirectCall
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

			public static void Invoke(int depth, in NativeArray<NativePortal> singleMatrices, ref NativeArray<float4x4> matrices)
			{
			}
		}

		internal delegate void Internal_FindCrossedPortals_000029C9_0024PostfixBurstDelegate(in NativePortalScene lastScene, in NativePortalScene currentScene, in float3 a, in float3 b, ref NativeList<NativePortalIntersection> intersections);

		internal static class Internal_FindCrossedPortals_000029C9_0024BurstDirectCall
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

			public static void Invoke(in NativePortalScene lastScene, in NativePortalScene currentScene, in float3 a, in float3 b, ref NativeList<NativePortalIntersection> intersections)
			{
			}
		}

		internal delegate void Internal_FindPortalsBetween_000029CC_0024PostfixBurstDelegate(in NativePortalScene currentScene, in float3 start, in float3 end, ref NativeList<NativePortalIntersection> intersections, bool allowBackfaces = false);

		internal static class Internal_FindPortalsBetween_000029CC_0024BurstDirectCall
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

			public static void Invoke(in NativePortalScene currentScene, in float3 start, in float3 end, ref NativeList<NativePortalIntersection> intersections, bool allowBackfaces = false)
			{
			}
		}

		internal delegate void Internal_TraversePortalSequence_000029CD_0024PostfixBurstDelegate(in NativePortalScene currentScene, in float3 start, in float3 end, in float3 realEnd, ref NativeList<PortalRaySegment> segments, in NativeList<PortalHandle> handles, out bool result);

		internal static class Internal_TraversePortalSequence_000029CD_0024BurstDirectCall
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

			public static void Invoke(in NativePortalScene currentScene, in float3 start, in float3 end, in float3 realEnd, ref NativeList<PortalRaySegment> segments, in NativeList<PortalHandle> handles, out bool result)
			{
				result = default(bool);
			}
		}

		public const int visionPortalDepth = 2;

		public List<Portal> portalComponents;

		public List<PortalIdentifier> identifiers;

		public Dictionary<PortalHandle, PortalIdentifier> portalIdentifiersLookup;

		public List<PortalHandleSequence> portalSequences;

		public List<bool> culledSequences;

		public NativeArray<float4x4> handleMatrices;

		public NativeArray<float4x4> sequenceMatrices;

		public NativeList<PortalHandle> handles;

		public NativeList<PortalHandle> renderHandles;

		private NativeList<PortalHandle> sequenceHandleCache;

		private NativeList<PortalRaySegment> raySegmentCache;

		public NativeList<bool> visionPossible;

		public NativePortalScene lastScene;

		public NativePortalScene nativeScene;

		private PortalVisionJob visionJob;

		private NativeList<NativePortalIntersection> intersections;

		private static readonly float4x4 Burst_PortalScale;

		[BurstCompile]
		public static void CalculateMatrices(int depth, in NativeArray<NativePortal> singleMatrices, ref NativeArray<float4x4> matrices)
		{
		}

		private void UpdatePortalSequences(int depth, int lastNumAddedSquences, NativeList<PortalHandle> portalHandles)
		{
		}

		public void DrawDebug()
		{
		}

		public bool IsTraversable(Portal portal, PortalSide side, bool asEnemy = false)
		{
			return false;
		}

		public float GetMinimumPassThroughSpeed(Portal portal, PortalSide side)
		{
			return 0f;
		}

		[BurstCompile]
		private static void Internal_FindCrossedPortals(in NativePortalScene lastScene, in NativePortalScene currentScene, in float3 a, in float3 b, ref NativeList<NativePortalIntersection> intersections)
		{
		}

		public bool FindCrossedPortals(Vector3 lastPos, Vector3 pos, out List<(PortalHandle, Vector3, float)> hitPortals)
		{
			hitPortals = null;
			return false;
		}

		public bool FindCrossedPortal(Vector3 lastPos, Vector3 pos, out PortalHandle handle, out Vector3 intersection)
		{
			handle = default(PortalHandle);
			intersection = default(Vector3);
			return false;
		}

		[BurstCompile]
		private static void Internal_FindPortalsBetween(in NativePortalScene currentScene, in float3 start, in float3 end, ref NativeList<NativePortalIntersection> intersections, bool allowBackfaces = false)
		{
		}

		[BurstCompile]
		private static void Internal_TraversePortalSequence(in NativePortalScene currentScene, in float3 start, in float3 end, in float3 realEnd, ref NativeList<PortalRaySegment> segments, in NativeList<PortalHandle> handles, out bool result)
		{
			result = default(bool);
		}

		private static int GetIndexFromHandle(in PortalHandle handle)
		{
			return 0;
		}

		public bool TraversePortalSequence(Vector3 start, Vector3 end, Vector3 realEnd, PortalHandleSequence sequence, out NativeList<PortalRaySegment> outSegments)
		{
			outSegments = default(NativeList<PortalRaySegment>);
			return false;
		}

		public bool FindPortalsBetween(Vector3 start, Vector3 end, ref List<(PortalHandle, Vector3, float)> hitPortals, bool allowBackfaces = false)
		{
			return false;
		}

		public bool FindPortalBetween(Vector3 start, Vector3 end, out PortalHandle hitPortal, out Vector3 intersection, out float distance, bool allowBackfaces = false)
		{
			hitPortal = default(PortalHandle);
			intersection = default(Vector3);
			distance = default(float);
			return false;
		}

		public Matrix4x4 GetTravelMatrix(PortalHandle handle)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetTravelMatrix(in PortalHandleSequence travelHandles)
		{
			return default(Matrix4x4);
		}

		public Matrix4x4 GetTravelMatrix(PortalTraversalV2[] travelHandles)
		{
			return default(Matrix4x4);
		}

		public IPortalShape GetShape(PortalHandle handle)
		{
			return null;
		}

		public Portal GetPortalObject(PortalHandle handle)
		{
			return null;
		}

		public string GetPortalName(PortalHandle handle)
		{
			return null;
		}

		public void Sync(List<Portal> portals)
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateMatrices_0024BurstManaged(int depth, in NativeArray<NativePortal> singleMatrices, ref NativeArray<float4x4> matrices)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void Internal_FindCrossedPortals_0024BurstManaged(in NativePortalScene lastScene, in NativePortalScene currentScene, in float3 a, in float3 b, ref NativeList<NativePortalIntersection> intersections)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void Internal_FindPortalsBetween_0024BurstManaged(in NativePortalScene currentScene, in float3 start, in float3 end, ref NativeList<NativePortalIntersection> intersections, bool allowBackfaces = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void Internal_TraversePortalSequence_0024BurstManaged(in NativePortalScene currentScene, in float3 start, in float3 end, in float3 realEnd, ref NativeList<PortalRaySegment> segments, in NativeList<PortalHandle> handles, out bool result)
		{
			result = default(bool);
		}
	}
}
