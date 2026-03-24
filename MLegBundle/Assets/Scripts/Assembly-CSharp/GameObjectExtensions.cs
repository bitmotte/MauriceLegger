using System;
using Interop;
using UnityEngine;

public static class GameObjectExtensions
{
	public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject) where T : Component
	{
		return null;
	}

	public static Component GetOrAddComponent(this UnityEngine.GameObject gameObject, Type componentType)
	{
		return null;
	}

	public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject, out bool exists) where T : Component
	{
		exists = default(bool);
		return null;
	}

	public static Component GetOrAddComponent(this UnityEngine.GameObject gameObject, Type componentType, out bool exists)
	{
		exists = default(bool);
		return null;
	}

	public static UnityEngine.GameObject CreateChild(this UnityEngine.GameObject parent)
	{
		return null;
	}

	public static UnityEngine.GameObject CreateChild(this UnityEngine.GameObject parent, string name)
	{
		return null;
	}

	public static T CreateChild<T>(this UnityEngine.GameObject parent) where T : Component
	{
		return null;
	}

	public static T CreateChild<T>(this UnityEngine.GameObject parent, string name) where T : Component
	{
		return null;
	}

	public static int GetFirstAudioFilterIndex(this UnityEngine.GameObject @this)
	{
		return 0;
	}

	public static int GetLastAudioFilterIndex(this UnityEngine.GameObject @this)
	{
		return 0;
	}

	public static void SwapComponents(this UnityEngine.GameObject @this, int index1, int index2)
	{
	}

	private unsafe static UnityEngine.Object GetScriptingObject<T>(T* pointer) where T : unmanaged, Interop.Object.Interface
	{
		return null;
	}
}
