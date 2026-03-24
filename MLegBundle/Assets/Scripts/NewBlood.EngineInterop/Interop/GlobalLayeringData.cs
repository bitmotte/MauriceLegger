namespace Interop
{
	public struct GlobalLayeringData
	{
		public uint layerAndOrder;

		public uint sortingGroupAll;

		public uint order
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}

		public uint id
		{
			readonly get
			{
				return 0u;
			}
			set
			{
			}
		}
	}
}
