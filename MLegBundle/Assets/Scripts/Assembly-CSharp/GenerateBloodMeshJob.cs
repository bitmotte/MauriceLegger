using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[BurstCompile]
public struct GenerateBloodMeshJob : IJobParallelFor
{
	public struct VertexData
	{
		public float3 position;

		public half4 normal_Offset;

		public half2 uv;

		public float3 center;
	}

	[ReadOnly]
	public NativeArray<BloodsplatterManager.InstanceProperties> props;

	public Mesh.MeshData meshData;

	public bool isUInt16;

	public void Execute(int index)
	{
	}
}
