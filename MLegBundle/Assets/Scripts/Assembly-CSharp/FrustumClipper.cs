using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using UnityEngine;

[BurstCompile]
public static class FrustumClipper
{
	internal delegate bool IsInsidePlane_0000176C_0024PostfixBurstDelegate(in Vector3 point, in Vector3 planeNormal, float planeDistance);

	internal static class IsInsidePlane_0000176C_0024BurstDirectCall
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

		public static bool Invoke(in Vector3 point, in Vector3 planeNormal, float planeDistance)
		{
			return false;
		}
	}

	internal delegate void LinePlaneIntersection_0000176D_0024PostfixBurstDelegate(in Vector3 p1, in Vector3 p2, in Vector3 planeNormal, float planeDistance, out Vector3 outVec);

	internal static class LinePlaneIntersection_0000176D_0024BurstDirectCall
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

		public static void Invoke(in Vector3 p1, in Vector3 p2, in Vector3 planeNormal, float planeDistance, out Vector3 outVec)
		{
			outVec = default(Vector3);
		}
	}

	internal unsafe delegate int ClipPolygonWithPlane_0000176E_0024PostfixBurstDelegate(in Vector3 planeNormal, float planeDistance, Vector3* polyIn, Vector3* polyOut, int polyInCount);

	internal static class ClipPolygonWithPlane_0000176E_0024BurstDirectCall
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

		public unsafe static int Invoke(in Vector3 planeNormal, float planeDistance, Vector3* polyIn, Vector3* polyOut, int polyInCount)
		{
			return 0;
		}
	}

	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	private static bool IsInsidePlane(in Vector3 point, in Vector3 planeNormal, float planeDistance)
	{
		return false;
	}

	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	private static void LinePlaneIntersection(in Vector3 p1, in Vector3 p2, in Vector3 planeNormal, float planeDistance, out Vector3 outVec)
	{
		outVec = default(Vector3);
	}

	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	private unsafe static int ClipPolygonWithPlane(in Vector3 planeNormal, float planeDistance, Vector3* polyIn, Vector3* polyOut, int polyInCount)
	{
		return 0;
	}

	public static Vector3[] ClipQuadToCameraFrustum(Plane[] frustumPlanes, Vector3[] polyIn, Vector3[] polyOut, int polyInCount, out int finalCount)
	{
		finalCount = default(int);
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	internal static bool IsInsidePlane_0024BurstManaged(in Vector3 point, in Vector3 planeNormal, float planeDistance)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	internal static void LinePlaneIntersection_0024BurstManaged(in Vector3 p1, in Vector3 p2, in Vector3 planeNormal, float planeDistance, out Vector3 outVec)
	{
		outVec = default(Vector3);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[BurstCompile(CompileSynchronously = true, DisableSafetyChecks = true)]
	internal unsafe static int ClipPolygonWithPlane_0024BurstManaged(in Vector3 planeNormal, float planeDistance, Vector3* polyIn, Vector3* polyOut, int polyInCount)
	{
		return 0;
	}
}
