using System;
using UnityEngine;

public struct PhysicsCastResult : IComparable<PhysicsCastResult>, IEquatable<PhysicsCastResult>
{
	public float distance;

	public Vector3 point;

	public Vector3 direction;

	public Vector3 normal;

	public Transform transform;

	public Collider collider;

	public Rigidbody rigidbody;

	public bool IsValid => false;

	public PhysicsCastResult(RaycastHit hit)
	{
		distance = 0f;
		point = default(Vector3);
		direction = default(Vector3);
		normal = default(Vector3);
		transform = null;
		collider = null;
		rigidbody = null;
	}

	public static PhysicsCastResult Empty()
	{
		return default(PhysicsCastResult);
	}

	public static PhysicsCastResult FromRaycastHit(RaycastHit hit)
	{
		return default(PhysicsCastResult);
	}

	public static PhysicsCastResult FromPoints(Vector3 start, Vector3 end)
	{
		return default(PhysicsCastResult);
	}

	public static PhysicsCastResult FromCollider(Collider col)
	{
		return default(PhysicsCastResult);
	}

	public static PhysicsCastResult FromDirectionDistance(Vector3 origin, Vector3 direction, float distance)
	{
		return default(PhysicsCastResult);
	}

	public int CompareTo(PhysicsCastResult other)
	{
		return 0;
	}

	public bool Equals(PhysicsCastResult other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(PhysicsCastResult left, PhysicsCastResult right)
	{
		return false;
	}

	public static bool operator !=(PhysicsCastResult left, PhysicsCastResult right)
	{
		return false;
	}

	public static implicit operator bool(PhysicsCastResult result)
	{
		return false;
	}
}
