using System;
using System.Collections.Generic;
using ULTRAKILL.Enemy;
using UnityEngine;
using plog;

public class TargetIndex<TKey, TValue> where TValue : IComparable<TValue>
{
	private static readonly plog.Logger Log;

	private readonly Func<TargetData, TValue> comparator;

	private readonly Func<TargetData, TKey> keySelector;

	private readonly Dictionary<TKey, TValue> items;

	public TargetIndex(Func<TargetData, TValue> comp, Func<TargetData, TKey> keySel)
	{
	}

	public void Reset()
	{
	}

	public bool Contains(TKey item)
	{
		return false;
	}

	public TValue Of(TargetData item)
	{
		return default(TValue);
	}
}
public static class TargetIndex
{
	public static TargetIndex<Vector3, float> MakeDistanceIndex(Func<Vector3> sourcePosSupllier, bool fromHead = false)
	{
		return null;
	}
}
