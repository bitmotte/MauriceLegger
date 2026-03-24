using System;
using UnityEngine;

[Serializable]
public class SavedQuaternion
{
	public float x;

	public float y;

	public float z;

	public float w;

	public SavedQuaternion(Quaternion quaternion)
	{
	}

	public Quaternion ToQuaternion()
	{
		return default(Quaternion);
	}
}
