using ULTRAKILL.Portal;
using UnityEngine;

public class PortalTravelFlagsSetter : MonoBehaviour
{
	public Portal target;

	public PortalTravellerFlags entryTravelFlags;

	public PortalTravellerFlags exitTravelFlags;

	[HideInInspector]
	public bool originalValuesGot;

	public bool updateOriginalValuesWhenActivated;

	[HideInInspector]
	public PortalTravellerFlags origEntryTravelFlags;

	[HideInInspector]
	public PortalTravellerFlags origExitTravelFlags;

	private void Awake()
	{
	}

	private void GetValues()
	{
	}

	public void Activate()
	{
	}

	public void Revert()
	{
	}
}
