namespace Interop.std
{
	public struct map_empty_allocator<Key, T, Comparer> where Key : unmanaged where T : unmanaged where Comparer : unmanaged
	{
		[DisallowEmptyType]
		public Comparer _Comparer;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
