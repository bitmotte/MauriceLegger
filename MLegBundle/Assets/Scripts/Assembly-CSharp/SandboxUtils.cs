using System.Collections.Generic;
using Sandbox;
using UnityEngine;
using plog;

public static class SandboxUtils
{
	private static readonly plog.Logger Log;

	public const float SnapGrid = 0.5f;

	private const float MeshDensity = 0.25f;

	private const float UvScale = 1f;

	private const float PreviewBlockUvScale = 0.05f;

	public static void StripForPreview(Transform target, Material newMaterial = null, bool first = true)
	{
	}

	public static SpawnableInstance GetProp(GameObject from, bool ignoreManipulationBlock = false)
	{
		return null;
	}

	public static void SetLayerDeep(Transform target, int layer)
	{
	}

	private static Material[] ToMaterialArray(Material material, int length)
	{
		return null;
	}

	public static Vector3 SnapPos(Vector3 pos)
	{
		return default(Vector3);
	}

	public static Vector3 SnapPos(Vector3 pos, Vector3 offset, float snapDensity = 0.5f)
	{
		return default(Vector3);
	}

	public static Vector3 SnapRotation(Vector3 rot)
	{
		return default(Vector3);
	}

	public static Mesh GenerateProceduralMesh(Vector3 size, bool simple)
	{
		return null;
	}

	public static void AddFaceToMesh(ref List<Vector3> vertices, ref List<int> tris, ref List<Vector2> uvs, Vector3[] quadPoints, bool repeatUVs = false, Vector2? uvCords = null, Vector2? uvSizeMod = null, float uvScaleOverride = 1f)
	{
	}

	public static float PolyClamp(float a, float b, float i, float units)
	{
		return 0f;
	}

	public static void SmallerBigger(Vector3 a, Vector3 b, out Vector3 smaller, out Vector3 bigger)
	{
		smaller = default(Vector3);
		bigger = default(Vector3);
	}

	public static GameObject CreateFinalBlock(SpawnableObject proceduralTemplate, Vector3 position, Vector3 size, bool liquid = false)
	{
		return null;
	}
}
