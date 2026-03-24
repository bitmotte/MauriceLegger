using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(LineRenderer))]
public class LineRendererPortalHelper : MonoBehaviour
{
	private class SegmentManager
	{
		private readonly Transform container;

		private readonly List<LineRenderer> renderers;

		private readonly List<GameObject> objects;

		private LineRendererProperties properties;

		public int Count => 0;

		public SegmentManager(Transform parent, LineRendererProperties template)
		{
		}

		public void DisableAll()
		{
		}

		public LineRenderer GetSegment(int index)
		{
			return null;
		}

		public void EnsureSegmentCount(int count)
		{
		}

		private void CreateSegment()
		{
		}

		public void CleanupSegments(int activeCount)
		{
		}

		public void Dispose()
		{
		}
	}

	[Serializable]
	internal struct LineRendererProperties
	{
		public Material material;

		public ShadowCastingMode shadowCastingMode;

		public bool receiveShadows;

		public LightProbeUsage lightProbeUsage;

		public ReflectionProbeUsage reflectionProbeUsage;

		public int sortingLayerID;

		public int sortingOrder;

		public bool allowOcclusionWhenDynamic;

		public MaterialPropertyBlock propertyBlock;

		public bool hasPropertyBlock;

		public Gradient gradient;

		public AnimationCurve widthCurve;

		public Color startColor;

		public Color endColor;

		public float startWidth;

		public float endWidth;

		public float widthMultiplier;

		public LineAlignment alignment;

		public LineTextureMode textureMode;

		public int numCapVertices;

		public int numCornerVertices;

		public Vector2 textureScale;

		public void CopyFrom(LineRenderer source)
		{
		}

		public void CopyDynamicFrom(LineRenderer source)
		{
		}

		public void ApplyBasicPropertiesTo(LineRenderer target)
		{
		}

		public void ApplyTo(LineRenderer target)
		{
		}
	}

	[Tooltip("If true, uses intermediate positions (as in, excluding the first and last position) from the original LineRenderer as world-space offsets relative to the straight line path between segments.")]
	public bool useIntermediatePositionsAsOffsets;

	private LineRenderer originalLineRenderer;

	private Transform segmentsContainer;

	private readonly List<PortalTraversalV2> traversals;

	private LineRendererProperties properties;

	private SegmentManager segmentManager;

	private Vector3 originalStartPoint;

	private Vector3 originalEndPoint;

	private readonly List<Vector3> originalIntermediatePoints;

	private readonly List<Vector3> tempSegmentPoints;

	public static LineRendererPortalHelper GetOrCreateHelper(LineRenderer lr)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public void UpdateTraversals(IList<PortalTraversalV2> newTraversals)
	{
	}

	public void DisableSegments()
	{
	}

	public void UpdatePropertyBlock(MaterialPropertyBlock propertyBlock)
	{
	}

	private void FetchOriginalPoints()
	{
	}

	private void RebuildSegments()
	{
	}

	private float CalculateTotalPathLength()
	{
		return 0f;
	}

	private void BuildSegmentGeometry(float totalPathLength)
	{
	}

	private void BuildSegmentPoints(Vector3 segStart, Vector3 segEnd, float tSegStart, float tSegEnd, int numShapePoints)
	{
	}

	private void AddIntermediatePointsWithOffsets(Vector3 segStart, Vector3 segEnd, float tSegStart, float tSegEnd, int numShapePoints)
	{
	}

	private void ConfigureSegmentRenderer(int segmentIndex, float tSegStart, float tSegEnd)
	{
	}

	private void ApplySegmentVisualProperties(LineRenderer lr, float tSegStart, float tSegEnd)
	{
	}

	private void ApplyColorProperties(LineRenderer lr, float tSegStart, float tSegEnd)
	{
	}

	private void ApplyWidthProperties(LineRenderer lr, float tSegStart, float tSegEnd)
	{
	}
}
