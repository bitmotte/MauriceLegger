namespace Interop.std
{
	public struct map<Key, T> where Key : unmanaged where T : unmanaged
	{
		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
	public struct map<Key, T, Comparer, Allocator> where Key : unmanaged where T : unmanaged where Comparer : unmanaged where Allocator : unmanaged
	{
		[DisallowEmptyType]
		public Comparer _Comparer;

		[DisallowEmptyType]
		public Allocator _Allocator;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
