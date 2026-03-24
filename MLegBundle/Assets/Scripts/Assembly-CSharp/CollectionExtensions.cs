using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;

public static class CollectionExtensions
{
	public static NativeArray<T> AsNativeArrayUnsafe<T>(this T[] array, out GCHandle handle) where T : unmanaged
	{
		handle = default(GCHandle);
		return default(NativeArray<T>);
	}

	public static NativeArray<T> AsNativeArrayUnsafe<T>(this List<T> list, out GCHandle handle) where T : unmanaged
	{
		handle = default(GCHandle);
		return default(NativeArray<T>);
	}

	public static NativeArray<T> AsNativeArrayUnsafe<T>(this T[] array, int offset, int length, out GCHandle handle) where T : unmanaged
	{
		handle = default(GCHandle);
		return default(NativeArray<T>);
	}
}
