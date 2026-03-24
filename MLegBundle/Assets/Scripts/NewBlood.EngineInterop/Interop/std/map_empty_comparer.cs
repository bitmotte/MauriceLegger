namespace Interop.std
{
	public struct map_empty_comparer<Key, T, Allocator> where Key : unmanaged where T : unmanaged where Allocator : unmanaged
	{
		[DisallowEmptyType]
		public Allocator _Allocator;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
