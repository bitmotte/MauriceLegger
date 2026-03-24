using ULTRAKILL.Portal;
using ULTRAKILL.Portal.Geometry;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(PortalIdentifier))]
public sealed class PortalAudioListener : VirtualAudioListener
{
	private PortalManagerV2 _portalManager;

	private PortalIdentifier _identifier;

	private Portal _portal;

	private PlaneShape _shape;

	private PortalTransform _transform;

	private void Awake()
	{
	}

	protected override void UpdateCachedValuesCore()
	{
	}

	public override Vector3 GetInputPosition(Vector3 position)
	{
		return default(Vector3);
	}
}
