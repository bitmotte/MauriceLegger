using ULTRAKILL.Portal;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(PortalIdentifier))]
public sealed class PortalAudioOutput : VirtualAudioOutput
{
	private PortalManagerV2 _portalManager;

	private PortalIdentifier _identifier;

	private Portal _portal;

	private Matrix4x4 _travelMatrix;

	private void Awake()
	{
	}

	protected override void UpdateCachedValuesCore()
	{
	}

	public override Vector3 GetOutputPosition(AudioListener mainListener, VirtualAudioListener listener, Vector3 position)
	{
		return default(Vector3);
	}
}
