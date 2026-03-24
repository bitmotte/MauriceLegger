namespace Interop
{
	public struct GrowableBuffer
	{
		public enum GrowMode
		{
			Fixed = 0,
			DoubleOnGrow = 1
		}

		public MemLabelId m_label;

		public unsafe sbyte* m_Buffer;

		public nuint m_Capacity;

		public nuint m_Size;

		public nuint m_GrowStepSize;

		public GrowMode m_GrowMode;
	}
}
