using System.Runtime.CompilerServices;

namespace ULTRAKILL.Portal
{
	public static class PortalSideExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static PortalSide Reverse(this PortalSide side)
		{
			return default(PortalSide);
		}

		public static PortalDirection GetDirection(this PortalSide side)
		{
			return default(PortalDirection);
		}

		public static PortalSideFlags ToFlags(this PortalSide side)
		{
			return default(PortalSideFlags);
		}
	}
}
