using UnityEngine;

public static class PhysicsExtensions
{
	public static void SetCustomGravity(this Rigidbody rigidbody, Vector3 gravity)
	{
	}

	public static bool TryGetCustomGravity(this Rigidbody rigidbody, out Vector3 gravity)
	{
		gravity = default(Vector3);
		return false;
	}

	public static bool GetCustomGravityMode(this Rigidbody rigidbody)
	{
		return false;
	}

	public static void SetCustomGravityMode(this Rigidbody rigidbody, bool useCustomGravity)
	{
	}

	public static bool GetGravityMode(this Rigidbody rigidbody)
	{
		return false;
	}

	public static void SetGravityMode(this Rigidbody rigidbody, bool useGravity)
	{
	}

	public static Vector3 GetGravityDirection(this Rigidbody rigidbody)
	{
		return default(Vector3);
	}

	public static Vector3 GetGravityDirection(this GameObject gameObject)
	{
		return default(Vector3);
	}

	public static Vector3 GetGravityVector(this Rigidbody rigidbody)
	{
		return default(Vector3);
	}

	public static Vector3 GetGravityVector(this GameObject gameObject)
	{
		return default(Vector3);
	}
}
