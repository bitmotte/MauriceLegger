namespace Interop.std
{
	public struct set_empty_comparer<T, Allocator> where T : unmanaged where Allocator : unmanaged
	{
		[DisallowEmptyType]
		public Allocator _Allocator;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
