using System;
using UnityEngine;

public static class ComponentExtensions
{
	public static T GetOrAddComponent<T>(this Component component) where T : Component
	{
		return null;
	}

	public static Component GetOrAddComponent(this Component component, Type componentType)
	{
		return null;
	}

	public static T GetOrAddComponent<T>(this Component component, out bool exists) where T : Component
	{
		exists = default(bool);
		return null;
	}

	public static Component GetOrAddComponent(this Component component, Type componentType, out bool exists)
	{
		exists = default(bool);
		return null;
	}

	public static bool MoveComponentUp(this Component component)
	{
		return false;
	}

	public static bool MoveComponentDown(this Component component)
	{
		return false;
	}
}
