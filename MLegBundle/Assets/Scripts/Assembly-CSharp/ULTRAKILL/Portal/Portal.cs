using Gravity;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class Portal : MonoBehaviour
	{
		public static readonly Matrix4x4 PORTAL_SCALE;

		[Header("Shape")]
		[SerializeReference]
		public IPortalShape shape;

		private PlaneShape planeShape;

		[Header("Linked Portals")]
		public Transform entry;

		public bool usePerceivedGravityOnEnter;

		public bool forceOrthogonalGravityOnEnter;

		public GravityVolume enterGravityVolume;

		[Space]
		public Transform exit;

		public bool usePerceivedGravityOnExit;

		public bool forceOrthogonalGravityOnExit;

		public GravityVolume exitGravityVolume;

		public float disableRange;

		[Header("Events")]
		public UnityEventPortalTravel onEntryTravel;

		public UnityEventPortalTravel onExitTravel;

		[Header("Settings")]
		public PortalTravellerFlags entryTravelFlags;

		public PortalTravellerFlags exitTravelFlags;

		public bool passThroughNonTraversals;

		public const float DEFAULT_OFFSET = 1.5f;

		public bool overrideLinkOffset;

		public float enterOffset;

		public float exitOffset;

		public float additionalSampleThreshold;

		public bool isMultiPanel;

		[Space]
		public PortalClippingMethod clippingMethod;

		public PortalSideFlags renderSettings;

		public bool mirror;

		public bool appearsInRecursions;

		public bool canSeeItself;

		public bool canSeePortalLayer;

		public bool allowCameraTraversals;

		public bool canHearAudio;

		public bool consumeAudio;

		public bool supportInfiniteRecursion;

		public bool updateLimboSkybox;

		[Space]
		public float minimumEntrySideSpeed;

		public float minimumExitSideSpeed;

		public int maxRecursions;

		[HideInInspector]
		public Vector3 entryForward;

		[HideInInspector]
		public Vector3 entryCenter;

		[HideInInspector]
		public Plane entryPlane;

		[HideInInspector]
		public Plane lastEntryPlane;

		[HideInInspector]
		public Matrix4x4 entryToWorld;

		[HideInInspector]
		public Matrix4x4 entryToLocal;

		[HideInInspector]
		public Vector3 exitForward;

		[HideInInspector]
		public Vector3 exitCenter;

		[HideInInspector]
		public Plane exitPlane;

		[HideInInspector]
		public Plane lastExitPlane;

		[HideInInspector]
		public Matrix4x4 exitToWorld;

		[HideInInspector]
		public Matrix4x4 exitToLocal;

		[HideInInspector]
		public Matrix4x4 travelMatrix;

		[HideInInspector]
		public Matrix4x4 travelMatrixReverse;

		private Vector3[] enterPortalVerts;

		private Vector3[] exitPortalVerts;

		public PortalTransform entryTransform;

		public PortalTransform exitTransform;

		public PortalTransform lastEntryTransform;

		public PortalTransform lastExitTransform;

		[Space(10f)]
		public Material overrideSkyboxEnter;

		public Material overrideSkyboxExit;

		[Space(10f)]
		public bool enableOverrideFog;

		public bool useFogEnter;

		public Color overrideFogColorEnter;

		public float overrideFogStartEnter;

		public float overrideFogEndEnter;

		public bool useFogExit;

		public Color overrideFogColorExit;

		public float overrideFogStartExit;

		public float overrideFogEndExit;

		[HideInInspector]
		public RenderTexture fakeEnterTex;

		[HideInInspector]
		public RenderTexture fakeExitTex;

		public Matrix4x4 fakeVPMatrix;

		private bool storeEnterThisFrame;

		private bool storeExitThisFrame;

		private int enterOnscreenIndex;

		private int exitOnscreenIndex;

		public UnityEventPortalTravel onTravel(PortalSide side)
		{
			return null;
		}

		public PortalTravellerFlags GetTravelFlags(PortalSide side)
		{
			return default(PortalTravellerFlags);
		}

		public float LinkOffset(PortalSide side)
		{
			return 0f;
		}

		private void Start()
		{
		}

		public void SetNeedToStoreTexture(int currentOnscreenIndex, int depth, PortalSide side)
		{
		}

		internal void TryStoreTexture(int onscreenHandleIndex, ref Matrix4x4 enterProjectionMatrix, ref Matrix4x4 enterViewMatrix, RenderTexture portalCompositeColor, PortalSide side)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void UpdateTransformData()
		{
		}

		public void SetUpdatedSkyFog(PortalSide side)
		{
		}

		public void SetEnterSkyFog()
		{
		}

		public void SetExitSkyFog()
		{
		}

		private void SetUpdatedSkyFog(bool isEnter)
		{
		}

		public unsafe ref readonly Matrix4x4 GetLastMatrix(PortalSide side, bool toWorld)
		{
			return ref *(Matrix4x4*)null;
		}

		public unsafe ref readonly Matrix4x4 GetCurrentMatrix(PortalSide side, bool toWorld)
		{
			return ref *(Matrix4x4*)null;
		}

		public unsafe ref readonly Plane GetPlaneFast(PortalSide side)
		{
			return ref *(Plane*)null;
		}

		public unsafe ref readonly PlaneShape GetShape()
		{
			return ref *(PlaneShape*)null;
		}

		public unsafe ref readonly Vector3 GetCenter(PortalSide side)
		{
			return ref *(Vector3*)null;
		}

		public unsafe ref readonly Matrix4x4 GetTravelMatrix(PortalSide side)
		{
			return ref *(Matrix4x4*)null;
		}

		public PortalTransform GetTransform(PortalSide side)
		{
			return null;
		}

		private void GenerateVertsFast(PortalSide side, out Vector3[] vertices)
		{
			vertices = null;
		}

		public void GetPortalVerts(PortalSide side, out Vector3[] vertices)
		{
			vertices = null;
		}
	}
}
