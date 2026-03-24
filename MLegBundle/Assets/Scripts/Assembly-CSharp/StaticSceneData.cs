using System.Collections.Generic;
using UnityEngine;

public class StaticSceneData : ScriptableObject
{
	public Texture2D mainTexAtlas;

	public Texture2D blendTexAtlas;

	public List<Mesh> bakedMeshes;

	public List<int> backingMeshHashes;

	public List<int> mrLightIndices;

	public List<ushort> mrMeshIndices;

	public List<ushort> firstSubMesh;

	public void ClearData()
	{
	}
}
