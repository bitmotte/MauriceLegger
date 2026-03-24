namespace Interop
{
	public struct dynamic_bitset
	{
		public MemLabelId m_label;

		public unsafe uint* m_bits;

		public nuint m_num_bits;

		public nuint m_num_blocks;
	}
}
