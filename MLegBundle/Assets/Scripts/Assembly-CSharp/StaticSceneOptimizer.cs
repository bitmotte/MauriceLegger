using System;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[ExecuteInEditMode]
[ConfigureSingleton(SingletonFlags.NoAutoInstance)]
[DefaultExecutionOrder(int.MaxValue)]
public class StaticSceneOptimizer : MonoSingleton<StaticSceneOptimizer>
{
	public enum BakingMode
	{
		Stationary = 0
	}

	private struct VertexData
	{
		public Vector3 position;

		public half4 normal;

		public Color32 color;

		public half2 uv0;

		public half4 mainAtlasRect;

		public half4 blendAtlasRect;

		public float lightData;
	}

	public struct LightData
	{
		public Vector4 lightPosition_attenX;

		public Vector4 lightDir_attenY;

		public Vector4 lightColor_attenZ;
	}

	public struct FullLightData
	{
		public Vector4 lightPosition_shadowFormat;

		public Vector4 lightAtten_shadowIndex;

		public Vector4 lightDir_shadowStrength;

		public Vector4 lightColor;

		public Matrix4x4 viewMatrix;

		public Matrix4x4 projectionMatrix;
	}

	public BakingMode bakeMode;

	[Space(10f)]
	[SerializeField]
	private StaticSceneData bakedDataAsset;

	[SerializeField]
	private List<Texture2D> devTexturesToSpot;

	[SerializeField]
	public List<Type> ignoreTypes;

	[HideInInspector]
	[SerializeField]
	private int ignoreCount;

	public bool warnNonStaticLights;

	public bool warnLightInGoreZone;

	public bool warnNonStaticObjects;

	public bool warnWrongObjectLayers;

	public bool warnNotUsingMasterShader;

	public bool warnMismatchedShaderKeywords;

	public bool warnMissingMeshFilter;

	public bool warnMissingMesh;

	public bool warnSubmeshIssues;

	public bool warnOddNegativeScaling;

	public bool randomColorAtlas;

	[HideInInspector]
	[SerializeField]
	private BakingMode currentBakedMode;

	[HideInInspector]
	[SerializeField]
	public Light[] globalLights;

	[HideInInspector]
	[SerializeField]
	public List<MeshRenderer> staticMRends;

	[HideInInspector]
	[SerializeField]
	private int bakedTextureCount;

	[HideInInspector]
	[SerializeField]
	private bool nothingBaked;

	[HideInInspector]
	[SerializeField]
	private bool isDirty;

	[HideInInspector]
	[SerializeField]
	private bool uv0Baked;

	[HideInInspector]
	[SerializeField]
	private bool uv1Baked;

	private Shader masterShader;

	[HideInInspector]
	[SerializeField]
	public Material batchMaterialOutdoors;

	[HideInInspector]
	[SerializeField]
	private Material batchMaterialEnvironment;

	private int enviroLayer;

	private int enviroBakedLayer;

	private int outdoorLayer;

	private int outdoorBakedLayer;

	private List<Material> reusableMaterials;

	private HashSet<int> testHashes;

	private ComputeBuffer cbMRLightIndices;

	private ComputeBuffer cbGlobalLightsData;

	private ComputeBuffer cbGlobalFullLightsData;

	private RenderTexture directionalShadows;

	private RenderTexture pointSpotShadows;

	private List<string> testKeywords;

	private List<Light> testLights;

	private List<MeshRenderer> tempMRends;

	private List<Color> reusableColors;

	private List<Vector3> reusablePositions;

	private List<Vector3> reusableNormals;

	private readonly string VERTEX_LIGHTING;

	private readonly string VERTEX_BLENDING;

	private readonly string FOG_OFF;

	private readonly string FOG_ON;

	public bool usedComputeShadersAtStart;

	private List<string> failureReasons;

	private Transform[] lightTransforms;

	private bool[] lightIsDirectionalBools;

	private Vector3[] lightAttens;

	private LightData[] lightDataArray;

	private static readonly Action<Renderer, int, int> s_SetStaticBatchInfo;

	[HideInInspector]
	[SerializeField]
	private bool bakeCompleted => false;

	public static void SetStaticBatchInfo(Renderer renderer, int firstSubMesh, int subMeshCount)
	{
	}

	private void SetupMaterial(bool isBaking = false)
	{
	}

	private void Start()
	{
	}

	private void FixPosition()
	{
	}

	private void SetupMeshes()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateRain(bool doEnable)
	{
	}

	private void InitializeGlobalBuffer()
	{
	}

	private void UpdateLightBuffer()
	{
	}

	public void GetSurfaceType(MeshRenderer mRend)
	{
	}

	private void OnDestroy()
	{
	}
}
