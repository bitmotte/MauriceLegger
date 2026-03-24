namespace Interop.core
{
	public struct vector<T> where T : unmanaged
	{
		private const ulong k_reference_bit = 1uL;

		private const int k_capacity_shift = 1;

		public unsafe T* m_ptr;

		public allocator<T> m_allocator;

		public nuint m_size;

		public nuint m_capacity;

		public unsafe readonly ref T this[nuint index] => ref *(T*)null;

		public unsafe readonly ref T this[nint index] => ref *(T*)null;

		public unsafe readonly T* data()
		{
			//IL_0002: Expected I, but got O
			return (T*)unchecked((nint)0);
		}

		public readonly nuint size()
		{
			return 0u;
		}

		public readonly nuint capacity()
		{
			return 0u;
		}
	}
	public struct vector<T, Allocator> where T : unmanaged where Allocator : unmanaged
	{
		private const ulong k_reference_bit = 1uL;

		private const int k_capacity_shift = 1;

		public unsafe T* m_ptr;

		public Allocator m_allocator;

		public nuint m_size;

		public nuint m_capacity;

		public unsafe readonly ref T this[nuint index] => ref *(T*)null;

		public unsafe readonly ref T this[nint index] => ref *(T*)null;

		public unsafe readonly T* data()
		{
			//IL_0002: Expected I, but got O
			return (T*)unchecked((nint)0);
		}

		public readonly nuint size()
		{
			return 0u;
		}

		public readonly nuint capacity()
		{
			return 0u;
		}
	}
}
