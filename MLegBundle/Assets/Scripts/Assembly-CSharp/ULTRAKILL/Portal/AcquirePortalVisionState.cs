using ULTRAKILL.Enemy;

namespace ULTRAKILL.Portal
{
	public class AcquirePortalVisionState
	{
		public TargetData target { get; private set; }

		public AcquirePortalVisionType type { get; private set; }

		public bool started { get; private set; }

		public bool completed { get; private set; }

		public void SetType(AcquirePortalVisionType type)
		{
		}

		public void Start()
		{
		}

		public void Complete()
		{
		}

		public void Reset(AcquirePortalVisionType type = AcquirePortalVisionType.NONE, TargetData target = default(TargetData))
		{
		}
	}
}
