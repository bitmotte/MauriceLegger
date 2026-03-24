using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;

[DefaultExecutionOrder(-200)]
public abstract class MonoSingleton : MonoBehaviour
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	private protected static readonly Dictionary<Type, MonoSingleton> s_Instances;

	private protected MonoSingleton()
	{
	}

	public static MonoSingleton GetInstance(Type type)
	{
		return null;
	}

	public abstract void MakeCurrent();
}
public abstract class MonoSingleton<T> : MonoSingleton where T : MonoSingleton<T>
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	private const int MaxFindCount = 1;

	[EditorBrowsable(EditorBrowsableState.Never)]
	private static int s_FindCount;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("The 'instance' field should not be accessed directly. Please use the 'Instance' property instead.")]
	private static T? instance;

	[EditorBrowsable(EditorBrowsableState.Never)]
	private static readonly SingletonFlags flags;

	public static T? Instance
	{
		get
		{
			return null;
		}
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This setter is obsolete, please use MakeCurrent instead.")]
		protected set
		{
		}
	}

	public static event Action<T>? InstanceChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private static T? GetOrCreateInstance()
	{
		return null;
	}

	[MemberNotNullWhen(true, "Instance")]
	public static bool TryGetInstance([NotNullWhen(true)] out T? instance)
	{
		instance = null;
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private void __internalAwake()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private void OnEnableINTERNAL()
	{
	}

	public sealed override void MakeCurrent()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private static void UpdateInstanceInternal(T newInstance)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Description("Creates an auto instance of this singleton. This method should be implemented as if it were static, never accessing instance data or methods.")]
	protected virtual T CreateAutoInstance()
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected static T CreateDefaultInstance()
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected static T CreateInstanceFromResources(string name)
	{
		return null;
	}
}
