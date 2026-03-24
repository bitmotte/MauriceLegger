using System.Runtime.InteropServices;

namespace Interop.core
{
	public struct basic_string
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct StringRepresentationUnion
		{
			[FieldOffset(0)]
			public StackAllocatedRepresentation m_embedded;

			[FieldOffset(0)]
			public HeapAllocatedRepresentation m_heap;
		}

		public struct StackAllocatedRepresentation
		{
			public unsafe fixed sbyte data[25];
		}

		public struct HeapAllocatedRepresentation
		{
			public unsafe sbyte* data;

			public nuint capacity;

			public nuint size;
		}

		public StringRepresentationUnion m_data;

		public StringRepresentation m_data_repr;

		public MemLabelId m_label;
	}
}
