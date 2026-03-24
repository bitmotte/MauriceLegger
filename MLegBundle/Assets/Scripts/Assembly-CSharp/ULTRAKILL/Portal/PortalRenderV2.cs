using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

namespace ULTRAKILL.Portal
{
	public class PortalRenderV2 : MonoBehaviour
	{
		private struct OnscreenPortalData
		{
			public ushort handleIndex;

			public int depth;

			public int parentOnscreenIndex;

			public int depthSortedIndex;
		}

		private struct Vertex
		{
			public Vector3 position;

			public Vector2 uv;

			public Vertex(Vector3 position, Vector2 uv)
			{
				this.position = default(Vector3);
				this.uv = default(Vector2);
			}
		}

		public enum PortalLightType
		{
			Player = 0,
			Enemy = 1,
			Environment = 2
		}

		public struct RenderData
		{
			public Vector3 viewPos;

			public Quaternion viewRot;

			public Matrix4x4 enterViewMatrix;

			public Matrix4x4 cullingMatrix;

			public Matrix4x4 enterProjectionMatrix;

			public Matrix4x4 parentViewMatrix;

			public ushort parentIndex;

			public ushort handelIndex;

			internal Matrix4x4 parentProjectionMatrix;

			internal Matrix4x4 exitProjectionMatrix;

			public ushort onscreenIndex;

			internal bool inMirroredSpace;

			internal bool canSeeItself;

			internal bool outMirroredSpace;

			internal int cullingMask;

			internal Matrix4x4 correctedMirrorProjection;

			internal Matrix4x4 parentCorrectedMirrorProjection;

			internal int depth;

			internal int maxDepth;

			internal bool useFog;

			internal Color fogColor;

			internal float fogStart;

			internal float fogEnd;
		}

		private struct FogData
		{
			internal bool useFog;

			internal Color fogColor;

			internal float fogStart;

			internal float fogEnd;
		}

		private struct PrepassData
		{
			public int handleIndex;

			public ushort parentHandleIndex;

			public Matrix4x4 viewMatrix;

			public ushort onscreenIndex;

			public Matrix4x4 obliqueProj;

			public Matrix4x4 nonObliqueVP;

			public Matrix4x4 correctedMirrorProjection;

			public bool inMirroredSpace;

			public PrepassData(int handleIndex, ushort parentHandleIndex, Matrix4x4 viewMatrix, ushort onscreenIndex, Matrix4x4 obliqueProj, Matrix4x4 nonObliqueVP, Matrix4x4 correctedMirrorProjection, bool inMirroredSpace)
			{
				this.handleIndex = 0;
				this.parentHandleIndex = 0;
				this.viewMatrix = default(Matrix4x4);
				this.onscreenIndex = 0;
				this.obliqueProj = default(Matrix4x4);
				this.nonObliqueVP = default(Matrix4x4);
				this.correctedMirrorProjection = default(Matrix4x4);
				this.inMirroredSpace = false;
			}
		}

		private struct DepthComparer : IComparer<int>
		{
			public List<OnscreenPortalData> Data;

			public int Compare(int a, int b)
			{
				return 0;
			}
		}

		private const int EVENT_BEGIN_READBACK = 1001;

		private const int EVENT_FETCH_RESULTS = 1002;

		[Space(10f)]
		public bool doOcclusionPass;

		public Material portalCompositeMaterial;

		public Material portalMaterial;

		public Material portalBitset64DownsampleMat;

		public Material fakeRecursionCopy;

		public PortalScene scene;

		public float obliqueCutoff;

		public float minPortalPixelArea;

		private Plane[] frustumPlanes;

		[HideInInspector]
		public Mesh totalPortalMesh;

		private Camera mainCam;

		private Camera portalCam;

		private List<PrepassData> prepassPortals;

		private List<Vector3[]> portalVerts;

		private List<RenderData> portalRenders;

		private CommandBuffer cb;

		private RenderTexture portalCompositeColor;

		private RenderTexture portalCompositeOutlineData;

		private RenderTargetIdentifier[] portalCompositeIdentifiers;

		private CommandBuffer recursionPortalDraw;

		private CommandBuffer bloodOilCB;

		private RenderTexture portalCompositeDepth;

		private RenderTargetIdentifier portalCompositeDepthIdentifier;

		[HideInInspector]
		public bool needsInit;

		private int lastWidth;

		private int lastHeight;

		private PostProcessV2_Handler pph;

		[SerializeField]
		private Mesh occluderMesh;

		private RenderTexture portalOcclusionData;

		private RenderTargetIdentifier portalOcclusionDataIdentifier;

		private RenderTexture[] portalCompositeOcclusionData;

		private RenderTargetIdentifier[] portalCompositeOcclusionDataIdentifiers;

		private int bitsetMaxMip;

		private AsyncGPUReadbackRequest occlusionReadback;

		private List<OnscreenPortalData> onscreenPortalData;

		private List<Matrix4x4> cullingFrusta;

		private Vector3[] clipBufferA;

		private Vector3[] clipBufferB;

		private List<float> nearClips;

		private int portalDepthID;

		private int portalOcclusionDataID;

		private int portalCompositeColorID;

		private int portalCompositeOutlineDatahID;

		private int portalDrawBitID;

		private int portalVPMatrixID;

		private int portalCompositeOcclusionDataID;

		private List<Vertex> portalMeshVertices;

		private List<ushort> portalMeshIndices;

		private VertexAttributeDescriptor[] vertexDescriptor;

		private Matrix4x4 defaultProjectionMatrix;

		private FogData defaultFogData;

		public static readonly int[] quadTriangleIndices;

		private static readonly ManualResetEventSlim waitHandle;

		private float maxDistance;

		private ulong occlusionBitset;

		private Matrix4x4 mirrorMatrix;

		private CommandBuffer mainPortalDraw;

		private List<(Light light, PortalLightType type)> tempPortalLights;

		private List<(Light light, PortalLightType type, Matrix4x4 travelMatrix, Vector4 portalPlane)> portalLights;

		private Vector4[] globalPortalLightPositions;

		private Vector4[] globalPortalLightColors;

		private Vector4[] globalPortalLightAttens;

		private Vector4[] globalPortalLightDirs;

		private Vector4[] globalPortalLightPlanes;

		private int portalLightCount;

		private Vector3[] reusableVerts;

		private Vector3[] zeroVerts;

		private bool[] visibility;

		private readonly List<int> indexCache;

		[DllImport("SameFrameReadback")]
		private static extern void BeginReadback_NonBlocking(IntPtr sourceTexture);

		[DllImport("SameFrameReadback")]
		private unsafe static extern void GetData_Blocking(long* result);

		[DllImport("SameFrameReadback")]
		private static extern IntPtr GetRenderEventFunc();

		[DllImport("SameFrameReadback")]
		private static extern IntPtr GetRenderEventAndDataFunc();

		private void Start()
		{
		}

		private void InitializeMesh()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Setup(PortalScene scene, Camera mainCam, Camera portalCam)
		{
		}

		internal void AddPortalAwareLight(Light thisLight, PortalLightType lightType)
		{
		}

		private void UpdatePortalLights()
		{
		}

		public void RebuildMesh()
		{
		}

		private void SetupRenderData(Camera enterCam, int depth, PortalHandle ignorePortal, Matrix4x4 parentViewMatrix, ushort parentHandleIndex, Matrix4x4 parentProjectionMatrix, bool inMirroredSpace, Matrix4x4 inCorrectedMirrorProjection, Matrix4x4 parentCorrectedMirrorProjection, int maxDepth, int parentOnscreenIndex, ref FogData lastFogData)
		{
		}

		private void PopulateSortedIndices()
		{
		}

		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlaneCameraSpace)
		{
			return default(Matrix4x4);
		}

		public static void DebugFrustum(Matrix4x4 viewM, Matrix4x4 projM, Color color)
		{
		}

		public static void DebugFrustum2(Matrix4x4 viewM, Matrix4x4 projM, Color color)
		{
		}

		public ushort GetOnscreenPortals(ref Vector3 enterPos, ref Vector3 enterForward, ref Matrix4x4 enterViewM, ref Matrix4x4 enterCullM, PortalHandle ignoreHandle, int depth, int parentOnscreenIndex, out ushort startIndex)
		{
			startIndex = default(ushort);
			return 0;
		}

		private void DebugRect(float minX, float maxX, float minY, float maxY, float nearClip, Matrix4x4 enterViewMatrix)
		{
		}

		private void DestroyTextures()
		{
		}

		public void Initialize(bool forceInit = false)
		{
		}

		private Matrix4x4 MakeProjectionMatrixFlippedZ(Matrix4x4 proj)
		{
			return default(Matrix4x4);
		}

		private void DepthPrepass()
		{
		}

		private static void OnOcclusionReadbackCompleted(AsyncGPUReadbackRequest request)
		{
		}

		private static Vector4 IndexToBitMask(int index)
		{
			return default(Vector4);
		}

		public void Render(Camera cam)
		{
		}

		internal void SetPortalOcclusion(bool enabled)
		{
		}

		internal void GetOcclusionResults()
		{
		}
	}
}
