using System;
using System.Runtime.CompilerServices;
using ULTRAKILL.Portal.Geometry;
using Unity.Burst;
using UnityEngine;

namespace ULTRAKILL.Portal.Native
{
	[BurstCompile]
	public static class NativePortalExtensions
	{
		internal delegate void CalculateData_00002A91_0024PostfixBurstDelegate(ref NativePortal portal, in int instanceId, in PlaneShape plane, in Vector3 position, in Quaternion rotation, in int componentIndex, in PortalSide side);

		internal static class CalculateData_00002A91_0024BurstDirectCall
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

			public static void Invoke(ref NativePortal portal, in int instanceId, in PlaneShape plane, in Vector3 position, in Quaternion rotation, in int componentIndex, in PortalSide side)
			{
			}
		}

		internal delegate bool Raycast_00002A92_0024PostfixBurstDelegate(in NativePortal portal, in PortalRay ray, out NativePortalIntersection intersection, bool allowBackfaces = false);

		internal static class Raycast_00002A92_0024BurstDirectCall
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

			public static bool Invoke(in NativePortal portal, in PortalRay ray, out NativePortalIntersection intersection, bool allowBackfaces = false)
			{
				intersection = default(NativePortalIntersection);
				return false;
			}
		}

		[BurstCompile]
		public static void CalculateData(this ref NativePortal portal, in int instanceId, in PlaneShape plane, in Vector3 position, in Quaternion rotation, in int componentIndex, in PortalSide side)
		{
		}

		[BurstCompile]
		public static bool Raycast(this in NativePortal portal, in PortalRay ray, out NativePortalIntersection intersection, bool allowBackfaces = false)
		{
			intersection = default(NativePortalIntersection);
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void CalculateData_0024BurstManaged(this ref NativePortal portal, in int instanceId, in PlaneShape plane, in Vector3 position, in Quaternion rotation, in int componentIndex, in PortalSide side)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static bool Raycast_0024BurstManaged(this in NativePortal portal, in PortalRay ray, out NativePortalIntersection intersection, bool allowBackfaces = false)
		{
			intersection = default(NativePortalIntersection);
			return false;
		}
	}
}
