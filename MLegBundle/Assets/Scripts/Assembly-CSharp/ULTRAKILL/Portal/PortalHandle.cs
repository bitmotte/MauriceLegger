using System;

namespace ULTRAKILL.Portal
{
	public struct PortalHandle : IEquatable<PortalHandle>
	{
		public const int NoneIndex = 65535;

		public ushort portalIndex;

		public PortalSide side;

		public int instanceId;

		public static readonly PortalHandle None;

		public PortalHandle(ushort portalIndex, int instanceId, PortalSide side)
		{
			this.portalIndex = 0;
			this.side = default(PortalSide);
			this.instanceId = 0;
		}

		public readonly PortalHandle Reverse()
		{
			return default(PortalHandle);
		}

		public override readonly string ToString()
		{
			return null;
		}

		public override readonly int GetHashCode()
		{
			return 0;
		}

		public override readonly bool Equals(object? obj)
		{
			return false;
		}

		public readonly bool Equals(PortalHandle other)
		{
			return false;
		}

		public readonly bool IsValid()
		{
			return false;
		}

		public readonly bool IsValid(PortalScene scene)
		{
			return false;
		}

		public static bool operator ==(PortalHandle left, PortalHandle right)
		{
			return false;
		}

		public static bool operator !=(PortalHandle left, PortalHandle right)
		{
			return false;
		}
	}
}
