using System.Collections.Generic;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class PortalAwareRendererTarget : MonoBehaviour
	{
		public readonly List<Transform> Clones;

		public PortalAwareRenderer Owner;

		private Collider collider;

		private Renderer renderer;

		private bool hasCollider;

		private bool hasRenderer;

		public void SetCollider(Collider collider)
		{
		}

		public void SetRenderer(Renderer renderer)
		{
		}

		public bool TryGetCollider(out Collider collider)
		{
			collider = null;
			return false;
		}

		public bool TryGetRenderer(out Renderer renderer)
		{
			renderer = null;
			return false;
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
