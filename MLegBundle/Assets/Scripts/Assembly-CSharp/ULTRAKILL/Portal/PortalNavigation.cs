using Unity.Collections;
using UnityEngine;

namespace ULTRAKILL.Portal
{
	public class PortalNavigation
	{
		private NativeList<BoxcastCommand> boxcastCommands;

		private const int STACK_THRESHOLD = 64;

		private float linkRemovalTimer;

		public bool TryGetNavPoint(PortalHandle handle, out Vector3 point)
		{
			point = default(Vector3);
			return false;
		}

		public void GenerateLinks(PortalScene scene, PortalIdentifier identifier)
		{
		}

		public void Sync(PortalScene scene)
		{
		}

		public void RemoveQueuedLinks(PortalScene scene)
		{
		}
	}
}
