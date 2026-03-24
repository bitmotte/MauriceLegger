using System;
using System.Runtime.CompilerServices;
using System.Text;
using ULTRAKILL.Portal;

namespace ULTRAKILL.Enemy
{
	public record TargetHandle
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int id => 0;

		public readonly ITarget target;

		public readonly PortalHandleSequence portals;

		public readonly int sequenceIndex;

		public TargetHandle(ITarget target, PortalHandleSequence portals, int sequenceIndex)
		{
		}

		public TargetHandle Then(PortalHandle handle)
		{
			return null;
		}

		public TargetHandle Then(PortalHandleSequence sequence)
		{
			return null;
		}

		public TargetHandle From(PortalHandle handle)
		{
			return null;
		}

		public TargetHandle From(PortalHandleSequence sequence)
		{
			return null;
		}

		public TargetHandle(ITarget target, PortalHandleSequence sequence)
		{
		}

		public TargetHandle(ITarget target, params PortalHandle[] portals)
		{
		}

		public TargetHandle(ITarget target)
		{
		}

		public virtual bool Equals(TargetHandle other)
		{
			return false;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			return null;
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			return false;
		}

		[CompilerGenerated]
		protected TargetHandle(TargetHandle original)
		{
		}
	}
}
