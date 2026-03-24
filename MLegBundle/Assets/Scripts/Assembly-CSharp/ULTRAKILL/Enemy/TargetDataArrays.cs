using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace ULTRAKILL.Enemy
{
	public struct TargetDataArrays : IDisposable
	{
		[NoAlias]
		public NativeArray<float3> positions;

		[NoAlias]
		public NativeArray<float3> headPositions;

		[NoAlias]
		public NativeArray<float3> velocities;

		[NoAlias]
		public NativeArray<quaternion> rotations;

		[NoAlias]
		public NativeArray<TargetType> types;

		public void Set(int index, Vector3 position, Vector3 headPosition, Vector3 velocity, Quaternion rotation, TargetType type)
		{
		}

		public void Allocate(int count, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
		}

		public void Dispose(JobHandle handle)
		{
		}

		public void Dispose()
		{
		}

		public void CopyTo(ref TargetDataArrays other, int index)
		{
		}
	}
}
