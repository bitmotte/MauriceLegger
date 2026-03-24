using System;
using UnityEngine;

[Serializable]
public class SavedVector3
{
	public float x;

	public float y;

	public float z;

	public static SavedVector3 Zero => null;

	public static SavedVector3 One => null;

	public SavedVector3(Vector3 vector3)
	{
	}

	public Vector3 ToVector3()
	{
		return default(Vector3);
	}
}
