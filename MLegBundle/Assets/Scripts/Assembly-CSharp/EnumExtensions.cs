using System;
using System.Runtime.CompilerServices;

public static class EnumExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool HasAnyFlag<T>(this T self, T flags) where T : unmanaged, Enum
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool HasAllFlags<T>(this T self, T flags) where T : unmanaged, Enum
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAnyFlag(byte a, byte b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAnyFlag(ushort a, ushort b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAnyFlag(uint a, uint b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAnyFlag(ulong a, ulong b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAllFlags(byte a, byte b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAllFlags(ushort a, ushort b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAllFlags(uint a, uint b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool HasAllFlags(ulong a, ulong b)
	{
		return false;
	}
}
