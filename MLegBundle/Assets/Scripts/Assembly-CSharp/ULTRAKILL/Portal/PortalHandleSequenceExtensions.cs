using System.Collections.Generic;

namespace ULTRAKILL.Portal
{
	public static class PortalHandleSequenceExtensions
	{
		public static PortalHandleSequence Then(this PortalHandleSequence seq, PortalHandle thenHandle)
		{
			return default(PortalHandleSequence);
		}

		public static PortalHandleSequence StartFrom(this PortalHandleSequence seq, PortalHandle fromHandle)
		{
			return default(PortalHandleSequence);
		}

		public static PortalHandleSequence ToPortalHandleSequence(this IEnumerable<PortalHandle> handles)
		{
			return default(PortalHandleSequence);
		}

		public static bool AllHasFlag(this PortalHandleSequence seq, PortalTravellerFlags flag)
		{
			return false;
		}
	}
}
