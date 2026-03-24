using UnityEngine;

public struct BoundedPlane
{
	public Vector3 center;

	public Vector3 normal;

	public Vector3 up;

	public Vector3 right;

	public float width;

	public float height;

	public Vector4 AsNormalDistance => default(Vector4);

	public Vector4 AsFlippedNormalDistance => default(Vector4);

	public Vector3 min => default(Vector3);

	public Vector3 max => default(Vector3);

	public BoundedPlane(Vector3 center, Vector3 normal, Vector3 up, Vector3 right, float width, float height)
	{
		this.center = default(Vector3);
		this.normal = default(Vector3);
		this.up = default(Vector3);
		this.right = default(Vector3);
		this.width = 0f;
		this.height = 0f;
	}

	public BoundedPlane(Transform transform, float width, float height)
	{
		center = default(Vector3);
		normal = default(Vector3);
		up = default(Vector3);
		right = default(Vector3);
		this.width = 0f;
		this.height = 0f;
	}

	public Vector3 ToBasis(Vector3 point, bool position = true)
	{
		return default(Vector3);
	}

	public Vector3 FromBasis(Vector3 basis, bool position = true)
	{
		return default(Vector3);
	}

	public float GetDistance(Vector3 point)
	{
		return 0f;
	}

	public bool GetSide(Vector3 point)
	{
		return false;
	}

	public Vector2 ProjectTo2D(Vector3 point)
	{
		return default(Vector2);
	}

	public bool Contains(Vector3 point)
	{
		return false;
	}
}
