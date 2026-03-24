using System;
using System.Collections.Generic;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class PortalAwareRenderer : MonoBehaviour
	{
		private enum ObjectType
		{
			Undefined = 0,
			Enemy = 1,
			Player = 2
		}

		public sealed class Clone
		{
			public readonly Dictionary<Transform, Transform> ObjectsLookup;

			public PortalAwareRenderer PortalAwareRenderer;

			public Transform Transform;

			public GameObject GameObject;

			private PortalHandle? portalHandle;

			public bool TryGetPortalHandle(out PortalHandle result)
			{
				result = default(PortalHandle);
				return false;
			}

			public void SetPortalHandle(PortalHandle? handle)
			{
			}
		}

		public sealed class SkinnedMeshBone
		{
			public readonly BoxCollider Collider;

			public readonly Vector3 BaseOffset;

			public readonly bool HasCopyPosRot;

			public readonly int ChildCount;

			private readonly bool hasLCPR;

			private readonly LateCopyPositionAndRotation lcpr;

			public SkinnedMeshBone(BoxCollider collider, int childCount)
			{
			}

			public bool TryGetLCPR(out LateCopyPositionAndRotation lcpr)
			{
				lcpr = null;
				return false;
			}
		}

		public const int MaxClipPlanes = 4;

		private static readonly List<Material> reusableMaterials;

		private static readonly Dictionary<Transform, Transform> targetLookup;

		private static readonly HashSet<PortalHandle> clipPlanePortalHandles;

		private static readonly HashSet<int> parentPortalHashCodes;

		private static readonly Vector4[] targetClipPlanes;

		private static readonly Vector3[] obbVertices;

		private static readonly Vector3[] portalVertices;

		private static readonly Vector3[] satAxes;

		private static MaterialPropertyBlock _propertyBlock;

		private static Comparison<PortalHandle> portalSortComparison;

		private static Vector3 portalSortCenter;

		private readonly List<PortalHandle> activePortals;

		private readonly List<Transform> targetObjects;

		private readonly List<Renderer> targetRenderers;

		private readonly List<Clone> clones;

		private List<SkinnedMeshBone> smrBoundingBones;

		private HashSet<Renderer> targetRenderersToIgnore;

		[SerializeField]
		private ObjectType objectType;

		[SerializeField]
		private bool useAdvancedSkinnedBoundsCheck;

		private Transform cachedTransform;

		private int activeCloneCount;

		private bool initializedTargets;

		private PortalAwareRenderer parent;

		private bool hasParent;

		private PortalHandle parentPortalHandle;

		private Bounds? boundsOverride;

		private int clipPlaneCount;

		private Func<PortalAwareRenderer, PortalHandle, bool> portalHandleFilter;

		public static bool IntersectCachedShapes()
		{
			return false;
		}

		public static void CacheBoneVertices(BoxCollider coll, SkinnedMeshBone bone)
		{
		}

		public static void CacheBoundsVertices(ref Vector3 center, ref Vector3 extents)
		{
		}

		public static void CacheBoxVertices(ref Vector3 center, ref Vector3 up, ref Vector3 right, ref Vector3 forward)
		{
		}

		public static void CachePortalVertices(Portal portal, PortalTransform portalTransform, Vector3 portalCenter)
		{
		}

		public static void SetClipPlaneKeyword(Renderer renderer, bool enabled)
		{
		}

		public static void SetClipPlaneKeyword(Material material, bool enabled)
		{
		}

		public void SetPortalHandleFilter(Func<PortalAwareRenderer, PortalHandle, bool> filter)
		{
		}

		public void ClearPortalHandleFilter()
		{
		}

		public void SetBoundsOverride(Bounds bounds)
		{
		}

		public void ClearBoundsOverride()
		{
		}

		private void RecursiveFindTargets(Transform targetObj)
		{
		}

		private void RecursiveClone(Clone clone, Transform targetTransform)
		{
		}

		private int GetIntersectingPortalHandles(List<PortalHandle> handles)
		{
			return 0;
		}

		private void LateUpdate()
		{
		}

		private void Think(bool allowChildUpdates = false)
		{
		}

		private void DeactivateClones()
		{
		}

		private void ActivateClone(Clone clone)
		{
		}

		private void DeactivateClone(Clone clone)
		{
		}

		private void Cleanup()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void EnsureClones(int desiredCloneCount)
		{
		}

		private Clone CreateClone()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void TryInitializeTargets()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
