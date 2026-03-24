using ULTRAKILL.Portal;
using UnityEngine;

public struct PortalTraversalV2
{
	public Vector3 entrancePoint;

	public Vector3 entranceDirection;

	public Vector3 exitPoint;

	public Vector3 exitDirection;

	public readonly PortalHandle portalHandle;

	public Portal portalObject;

	public override string ToString()
	{
		return null;
	}

	public PortalTraversalV2(Vector3 entrance, Vector3 entranceDir, Vector3 exit, Vector3 exitDir, PortalHandle handle, Portal portal)
	{
		entrancePoint = default(Vector3);
		entranceDirection = default(Vector3);
		exitPoint = default(Vector3);
		exitDirection = default(Vector3);
		portalHandle = default(PortalHandle);
		portalObject = null;
	}
}
