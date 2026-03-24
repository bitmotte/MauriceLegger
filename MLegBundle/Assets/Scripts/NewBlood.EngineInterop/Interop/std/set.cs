namespace Interop.std
{
	public struct set<T> where T : unmanaged
	{
		public struct iterator
		{
			public unsafe void* node;
		}

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
	public struct set<T, Comparer, Allocator> where T : unmanaged where Comparer : unmanaged where Allocator : unmanaged
	{
		[DisallowEmptyType]
		public Comparer _Comparer;

		[DisallowEmptyType]
		public Allocator _Allocator;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
