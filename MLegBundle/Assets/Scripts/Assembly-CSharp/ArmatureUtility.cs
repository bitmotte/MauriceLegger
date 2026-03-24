using System;
using Unity.Collections;
using UnityEngine;

public static class ArmatureUtility
{
	public static void ComputeLocalBounds(Mesh mesh, Span<Bounds> bounds)
	{
	}

	public static void ComputeLocalBounds(Mesh mesh, Span<Bounds> bounds, ReadOnlySpan<Matrix4x4> bindPoses)
	{
	}

	private static void ComputeLocalBounds<TIndex>(Mesh mesh, Span<Bounds> bounds, ReadOnlySpan<Matrix4x4> bindPoses) where TIndex : unmanaged, IConvertible
	{
	}

	public static void ComputeLocalBounds(ReadOnlySpan<byte> bonesPerVertex, ReadOnlySpan<BoneWeight1> boneWeights, ReadOnlySpan<Matrix4x4> bindPoses, NativeSlice<Vector3> vertices, ReadOnlySpan<int> triangles, Span<Bounds> bounds)
	{
	}

	public static void ComputeLocalBounds(ReadOnlySpan<byte> bonesPerVertex, ReadOnlySpan<BoneWeight1> boneWeights, ReadOnlySpan<Matrix4x4> bindPoses, NativeSlice<Vector3> vertices, ReadOnlySpan<ushort> triangles, Span<Bounds> bounds)
	{
	}

	private static void ComputeLocalBounds<TIndex>(ReadOnlySpan<byte> bonesPerVertex, ReadOnlySpan<BoneWeight1> boneWeights, ReadOnlySpan<Matrix4x4> bindPoses, NativeSlice<Vector3> vertices, ReadOnlySpan<TIndex> triangles, Span<Bounds> bounds) where TIndex : unmanaged, IConvertible
	{
	}
}
