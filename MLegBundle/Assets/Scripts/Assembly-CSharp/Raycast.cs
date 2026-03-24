using plog;

public class Raycast : ICastable
{
	private static readonly Logger Log;

	public bool Cast(PortalCastStateV2 state, out PhysicsCastResult result)
	{
		result = default(PhysicsCastResult);
		return false;
	}

	public PhysicsCastResult[] CastAll(PortalCastStateV2 state)
	{
		return null;
	}
}
