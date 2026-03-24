using System;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace ULTRAKILL.Portal.Geometry
{
	[BurstCompile]
	public static class PlaneShapeExtensions
	{
		internal delegate void GetClosestPoint_00002AB0_0024PostfixBurstDelegate(in PlaneShape shape, in float3 center, in float3 right, in float3 up, in float3 forward, in Vector3 point, out float3 closest);

		internal static class GetClosestPoint_00002AB0_0024BurstDirectCall
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

			public static void Invoke(in PlaneShape shape, in float3 center, in float3 right, in float3 up, in float3 forward, in Vector3 point, out float3 closest)
			{
				closest = default(float3);
			}
		}

		[BurstCompile]
		public static void GetClosestPoint(this in PlaneShape shape, in float3 center, in float3 right, in float3 up, in float3 forward, in Vector3 point, out float3 closest)
		{
			closest = default(float3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile]
		internal static void GetClosestPoint_0024BurstManaged(this in PlaneShape shape, in float3 center, in float3 right, in float3 up, in float3 forward, in Vector3 point, out float3 closest)
		{
			closest = default(float3);
		}
	}
}
