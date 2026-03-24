using System.Diagnostics.CodeAnalysis;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public static class MeshExtensions
{
	public static VertexAttributeDescriptor GetVertexAttributeDescriptor(this Mesh.MeshData data, VertexAttribute attribute)
	{
		return default(VertexAttributeDescriptor);
	}

	public static NativeSlice<T> GetVertexAttributeSlice<T>(this Mesh.MeshData data, VertexAttribute attribute) where T : struct
	{
		return default(NativeSlice<T>);
	}

	private static NativeSlice<T> InternalGetVertexAttributeSlice<T>(Mesh.MeshData data, VertexAttributeDescriptor format) where T : struct
	{
		return default(NativeSlice<T>);
	}

	[DoesNotReturn]
	private static void ThrowExceptionForInvalidVertexAttributeSliceType<T>()
	{
	}
}
