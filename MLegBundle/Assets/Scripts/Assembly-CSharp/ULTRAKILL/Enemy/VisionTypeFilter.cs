namespace ULTRAKILL.Enemy
{
	public struct VisionTypeFilter
	{
		private int mask;

		public VisionTypeFilter(params TargetType[] types)
		{
			mask = 0;
		}

		public readonly bool HasType(TargetType type)
		{
			return false;
		}
	}
}
