namespace Interop.std
{
	public struct set_empty_allocator<T, Comparer> where T : unmanaged where Comparer : unmanaged
	{
		[DisallowEmptyType]
		public Comparer _Comparer;

		public unsafe void* _Myhead;

		public nuint _Mysize;
	}
}
