using System.Collections.Generic;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class PortalAwareRendererClone : MonoBehaviour
	{
		private static readonly List<Vector4> tempClipPlanes;

		private static MaterialPropertyBlock _propertyBlock;

		public PortalAwareRenderer.Clone Owner;

		public PortalAwareRendererTarget Target;

		public Transform TargetTransform;

		public GameObject TargetObject;

		public PortalAwareRenderer PortalAwareRenderer;

		private Collider collider;

		private Renderer renderer;

		private bool hasCollider;

		private bool hasRenderer;

		private Material cachedTargetMaterial;

		private GameObject gameObj;

		public void SetCollider(Collider collider)
		{
		}

		public void SetRenderer(Renderer renderer)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}
	}
}
